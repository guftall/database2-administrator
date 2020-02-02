using Database2AdministratorWpf.Dto;
using System.Windows;

namespace Database2AdministratorWpf
{
    /// <summary>
    /// Interaction logic for AddAthlete.xaml
    /// </summary>
    public partial class AddAthlete : Window
    {
        private Repository repository;

        public AddAthlete()
        {
            InitializeComponent();
            repository = new Repository();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbSport.Items.Clear();

            var sports = repository.ReadSports();

            foreach (var sport in sports)
            {
                cbSport.Items.Add(sport.Name);
            }
            cbSport.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Athlete athlete = new Athlete();
            athlete.TeamId = txtTeamId.Text.ToString();
            athlete.Name = txtName.Text.ToString();
            athlete.Image = txtImage.Text.ToString();
            if (!dpBirthdate.SelectedDate.HasValue)
            {
                MessageBox.Show("Invalid date");
            }

            athlete.Birthdate = dpBirthdate.SelectedDate.Value;
            if (rbFemale.IsChecked.Value)
            {
                athlete.Gender = 1;
            }
            else if (rbMale.IsChecked.Value)
            {
                athlete.Gender = 2;
            }

            var sport = new Sport();
            sport.Name = cbSport.SelectedItem.ToString();

            repository.InsertAthlete(athlete, sport);

            MessageBox.Show("Athlete inserted");
            this.Close();
        }
    }
}
