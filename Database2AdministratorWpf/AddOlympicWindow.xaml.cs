using Database2AdministratorWpf.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Database2AdministratorWpf
{
    /// <summary>
    /// Interaction logic for AddOlympicWindow.xaml
    /// </summary>
    public partial class AddOlympicWindow : Window
    {
        private Repository repository;

        public AddOlympicWindow()
        {
            InitializeComponent();
            repository = new Repository();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var olympic = new Olympic();
            olympic.Name = txtName.Text.ToString();
            olympic.Sponsors = txtSponsors.Text.ToString();
            olympic.Website = txtWebsite.Text.ToString();
            olympic.Twitter = txtTwitter.Text.ToString();
            olympic.Facebook = txtFacebook.Text.ToString();
            olympic.Logo = txtLogo.Text.ToString();
            olympic.Country = cbCountry.SelectedItem.ToString();
            if (!int.TryParse(txtYear.Text.ToString(), out int year))
            {
                MessageBox.Show("Invalid Year");
                return;
            }
            olympic.Year = year;

            olympic.TorchImage = txtTorchImage.Text.ToString();

            if (!int.TryParse(txtTorchCost.Text.ToString(), out int cost))
            {
                MessageBox.Show("Invalid cost");
                return;
            }

            olympic.TorchCost = cost;
            olympic.TorchDescription = txtTorchDescription.Text.ToString();
            olympic.TorchDesigner = txtTorchDesigner.Text.ToString();
            olympic.TorchCountry = cbTorchCountry.SelectedItem.ToString();

            repository.InsertOlympic(olympic);
            MessageBox.Show("Olympic inserted");
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var countries = repository.ReadCountries();

            cbCountry.Items.Clear();
            cbTorchCountry.Items.Clear();

            foreach (var country in countries)
            {
                cbCountry.Items.Add(country.Name);
                cbTorchCountry.Items.Add(country.Name);
            }
            cbCountry.SelectedIndex = 0;
            cbTorchCountry.SelectedIndex = 0;
        }
    }
}
