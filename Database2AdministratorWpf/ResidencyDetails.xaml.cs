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
    /// Interaction logic for ResidencyDetails.xaml
    /// </summary>
    public partial class ResidencyDetails : Window
    {
        private readonly string _residencyId;
        private Residency residency;

        private readonly Repository repository;

        public ResidencyDetails(string residencyId)
        {
            _residencyId = residencyId;
            InitializeComponent();
            repository = new Repository();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtCount.Text.ToString(), out int count))
            {
                MessageBox.Show("Invalid count");
                return;
            }

            if (!int.TryParse(txtNights.Text.ToString(), out int nights))
            {
                MessageBox.Show("Invalid nights");
                return;
            }

            var cost = repository.CalculateResidencyCost(_residencyId, count, nights);

            SetCostString(count, nights, cost);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            residency = repository.ReadResidency(_residencyId);
            lblResidencyName.Content = residency.Name;
        }

        private void SetCostString(int count, int nights, double cost)
        {
            lblCost.Content = "Cost of " + nights + "night for " + count + " person in " + residency.Name + " is " + cost + "$";
        }
    }
}
