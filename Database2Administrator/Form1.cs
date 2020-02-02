using Database2Administrator.Dto;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Database2Administrator
{
    public partial class Form1 : Form
    {
        private Olympic olympic;
        private Athlete athlete;
        private string selectedOlympicName;
        private string selectedAthleteId;
        private Repository repository;

        public Form1()
        {
            InitializeComponent();
            repository = new Repository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'olympicDataSet.En_Olympic' table. You can move, or remove it, as needed.
            this.en_OlympicTableAdapter.Fill(this.olympicDataSet.En_Olympic);
            // TODO: This line of code loads data into the 'olympicDataSet.En_Athlete' table. You can move, or remove it, as needed.
            this.en_AthleteTableAdapter.Fill(this.olympicDataSet.En_Athlete);

           
            dgvOlympics.CellEndEdit += dgvOlympics_CellEndEdit;
            dgvOlympics.SelectionChanged += dgvOlympics_SelectionChanged;
            
            dgvAthletes.CellEndEdit += dgvAthletes_CellEndEdit;
            dgvAthletes.SelectionChanged += dgvAthletes_SelectionChanged;

            this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
        }


        // Add this event handler to the DataGridView
        private void dgvOlympics_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOlympics.RowCount - e.RowIndex == 2)
                return;

            var row = dgvOlympics.Rows[e.RowIndex];
            olympic = ExtractOlympicFromRow(row);
        }

        // Add this event handler to the DataGridView
        private void dgvAthletes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAthletes.RowCount - e.RowIndex == 2)
                return;
            
            var row = dgvAthletes.Rows[e.RowIndex];
            athlete = ExtractAthleteFromRow(row);
        }

        private void dgvOlympics_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dgvOlympics.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = dgvOlympics.SelectedRows[0];
            if (row == null) return;

            var olympicName = row.Cells[0].Value.ToString();
            selectedOlympicName = olympicName;
        }

        private void dgvAthletes_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dgvAthletes.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = dgvAthletes.SelectedRows[0];
            if (row == null) return;

            var athleteId = row.Cells[0].Value.ToString();
            selectedAthleteId = athleteId;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabOlympics")
            {
                repository.UpdateOlympic(olympic);
                olympic = null;
            }
            else if (tabControl1.SelectedTab.Name == "tabAthletes")
            {
                repository.UpdateAthlete(athlete);
                athlete = null;
            }

            MessageBox.Show("Record Updated Successfully");
        }
       

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl1.SelectedTab.Name);
            if (tabControl1.SelectedTab.Name == "tabOlympics")
            {
                repository.RemoveOlympic(selectedOlympicName);
                selectedOlympicName = null;
                ReloadOlympics();
            }
            else if (tabControl1.SelectedTab.Name == "tabAthletes")
            {
                repository.RemoveAthlete(selectedAthleteId);
                selectedAthleteId = null;
                ReloadAthletes();
            }
            else
            {
                MessageBox.Show("Tab not recognized!");
            }
        }


        private Olympic ExtractOlympicFromRow(DataGridViewRow row)
        {
            var olympic = new Olympic();

            olympic.Name = row.Cells[0].Value.ToString();
            olympic.Sponsors = row.Cells[1].Value.ToString();
            olympic.Website = row.Cells[2].Value.ToString();
            olympic.Twitter = row.Cells[3].Value.ToString();
            olympic.Facebook = row.Cells[4].Value.ToString();
            olympic.Logo = row.Cells[5].Value.ToString();
            if (!int.TryParse(row.Cells[6].Value.ToString(), out int year))
            {
                MessageBox.Show("Invalid year");
                return olympic;
            }

            olympic.Year = year;

            return olympic;
        }

        private Athlete ExtractAthleteFromRow(DataGridViewRow row)
        {
            var athlete = new Athlete();

            athlete.Id = row.Cells[0].Value.ToString();
            athlete.TeamId = row.Cells[1].Value.ToString();
            athlete.Name = row.Cells[2].Value.ToString();
            athlete.Birthdate = Convert.ToDateTime(row.Cells[3].Value.ToString());
            athlete.Image = row.Cells[7].Value.ToString();
            athlete.Gender = int.Parse(row.Cells[8].Value.ToString());

            return athlete;
        }

        private void btnAddAthlete_Click(object sender, EventArgs e)
        {
            var addForm = new AddAthlete();
            addForm.ShowDialog();
            ReloadAthletes();
        }

        private void btnAddOlympic_Click(object sender, EventArgs e)
        {
            var addOlympicForm = new AddOlympic();
            addOlympicForm.ShowDialog();
            ReloadOlympics();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            ReloadAthletes();
            ReloadOlympics();
        }

        private void ReloadAthletes()
        {
            if (repository.con.State != ConnectionState.Open)
                repository.con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from En_Athlete", repository.con);
            adapt.Fill(dt);
            dgvAthletes.DataSource = dt;
            repository.con.Close();
        }

        private void ReloadOlympics()
        {
            if (repository.con.State != ConnectionState.Open)
                repository.con.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from En_Olympic", repository.con);
            adapt.Fill(dt);
            dgvOlympics.DataSource = dt;
            repository.con.Close();
        }
    }
}
