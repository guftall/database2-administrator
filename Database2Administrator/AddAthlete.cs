using Database2Administrator.Dto;
using System;
using System.Windows.Forms;

namespace Database2Administrator
{
    public partial class AddAthlete : Form
    {
        private Repository repository;

        public AddAthlete()
        {
            InitializeComponent();
            repository = new Repository();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Athlete athlete = new Athlete();
            athlete.TeamId = txtTeamId.Text.ToString();
            athlete.Name = txtName.Text.ToString();
            athlete.Image = txtImage.Text.ToString();
            athlete.Birthdate = dtpBirthdate.Value;
            if (rbFemale.Checked)
            {
                athlete.Gender = 1;
            }
            else if (rbMale.Checked)
            {
                athlete.Gender = 2;
            }

            repository.InsertAthlete(athlete);

            MessageBox.Show("Athlete inserted");
            this.Close();
        }
    }
}
