using Database2Administrator.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database2Administrator
{
    public partial class AddOlympic : Form
    {
        private Repository repository;
        public AddOlympic()
        {
            InitializeComponent();
            this.repository = new Repository();
        }

        private void AddOlympic_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var olympic = new Olympic();
            olympic.Name = txtName.Text.ToString();
            olympic.Sponsors = txtSponsors.Text.ToString();
            olympic.Website = txtWebsite.Text.ToString();
            olympic.Twitter = txtTwitter.Text.ToString();
            olympic.Facebook = txtFacebook.Text.ToString();
            olympic.Logo = txtLogo.Text.ToString();
            olympic.Country = txtCountry.Text.ToString();

            olympic.TorchImage = txtTourchImage.Text.ToString();

            if (!int.TryParse(txtTourchCost.Text.ToString(), out int cost))
            {
                MessageBox.Show("Invalid cost");
                return;
            }

            olympic.TorchCost = cost;
            olympic.TorchDescription = txtTourchDescription.Text.ToString();
            olympic.TorchDesigner = txtTourchDesigner.Text.ToString();

            repository.InsertOlympic(olympic);
            MessageBox.Show("Olympic inserted");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
