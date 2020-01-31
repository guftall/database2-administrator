namespace Database2Administrator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOlympics = new System.Windows.Forms.TabPage();
            this.dgvOlympics = new System.Windows.Forms.DataGridView();
            this.olympicnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicsponsorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicwebsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictwitterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicfacebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympiclogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicseasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympicenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictorchimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictorchcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictorchdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictorchdesignerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olympictorchcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.happencountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enOlympicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olympicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.olympicDataSet = new Database2Administrator.olympicDataSet();
            this.tabAthletes = new System.Windows.Forms.TabPage();
            this.dgvAthletes = new System.Windows.Forms.DataGridView();
            this.athleteidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteteamidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletebirthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteheightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletedateofdeathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteimageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athletegenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enAthleteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.enAthleteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.en_AthleteTableAdapter = new Database2Administrator.olympicDataSetTableAdapters.En_AthleteTableAdapter();
            this.en_OlympicTableAdapter = new Database2Administrator.olympicDataSetTableAdapters.En_OlympicTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddAthlete = new System.Windows.Forms.Button();
            this.btnAddOlympic = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabOlympics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlympics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enOlympicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympicDataSet)).BeginInit();
            this.tabAthletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enAthleteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enAthleteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOlympics);
            this.tabControl1.Controls.Add(this.tabAthletes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOlympics
            // 
            this.tabOlympics.Controls.Add(this.dgvOlympics);
            this.tabOlympics.Location = new System.Drawing.Point(4, 22);
            this.tabOlympics.Name = "tabOlympics";
            this.tabOlympics.Padding = new System.Windows.Forms.Padding(3);
            this.tabOlympics.Size = new System.Drawing.Size(773, 364);
            this.tabOlympics.TabIndex = 0;
            this.tabOlympics.Text = "Olympics";
            this.tabOlympics.UseVisualStyleBackColor = true;
            // 
            // dgvOlympics
            // 
            this.dgvOlympics.AllowUserToAddRows = false;
            this.dgvOlympics.AllowUserToDeleteRows = false;
            this.dgvOlympics.AutoGenerateColumns = false;
            this.dgvOlympics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOlympics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.olympicnameDataGridViewTextBoxColumn,
            this.olympicsponsorsDataGridViewTextBoxColumn,
            this.olympicwebsiteDataGridViewTextBoxColumn,
            this.olympictwitterDataGridViewTextBoxColumn,
            this.olympicfacebookDataGridViewTextBoxColumn,
            this.olympiclogoDataGridViewTextBoxColumn,
            this.olympicyearDataGridViewTextBoxColumn,
            this.olympicseasonDataGridViewTextBoxColumn,
            this.olympicstartdateDataGridViewTextBoxColumn,
            this.olympicenddateDataGridViewTextBoxColumn,
            this.olympictorchimageDataGridViewTextBoxColumn,
            this.olympictorchcostDataGridViewTextBoxColumn,
            this.olympictorchdescriptionDataGridViewTextBoxColumn,
            this.olympictorchdesignerDataGridViewTextBoxColumn,
            this.olympictorchcountryDataGridViewTextBoxColumn,
            this.happencountryDataGridViewTextBoxColumn});
            this.dgvOlympics.DataSource = this.enOlympicBindingSource;
            this.dgvOlympics.Location = new System.Drawing.Point(3, 6);
            this.dgvOlympics.MultiSelect = false;
            this.dgvOlympics.Name = "dgvOlympics";
            this.dgvOlympics.Size = new System.Drawing.Size(764, 352);
            this.dgvOlympics.TabIndex = 0;
            // 
            // olympicnameDataGridViewTextBoxColumn
            // 
            this.olympicnameDataGridViewTextBoxColumn.DataPropertyName = "olympic_name";
            this.olympicnameDataGridViewTextBoxColumn.HeaderText = "olympic_name";
            this.olympicnameDataGridViewTextBoxColumn.Name = "olympicnameDataGridViewTextBoxColumn";
            // 
            // olympicsponsorsDataGridViewTextBoxColumn
            // 
            this.olympicsponsorsDataGridViewTextBoxColumn.DataPropertyName = "olympic_sponsors";
            this.olympicsponsorsDataGridViewTextBoxColumn.HeaderText = "olympic_sponsors";
            this.olympicsponsorsDataGridViewTextBoxColumn.Name = "olympicsponsorsDataGridViewTextBoxColumn";
            // 
            // olympicwebsiteDataGridViewTextBoxColumn
            // 
            this.olympicwebsiteDataGridViewTextBoxColumn.DataPropertyName = "olympic_website";
            this.olympicwebsiteDataGridViewTextBoxColumn.HeaderText = "olympic_website";
            this.olympicwebsiteDataGridViewTextBoxColumn.Name = "olympicwebsiteDataGridViewTextBoxColumn";
            // 
            // olympictwitterDataGridViewTextBoxColumn
            // 
            this.olympictwitterDataGridViewTextBoxColumn.DataPropertyName = "olympic_twitter";
            this.olympictwitterDataGridViewTextBoxColumn.HeaderText = "olympic_twitter";
            this.olympictwitterDataGridViewTextBoxColumn.Name = "olympictwitterDataGridViewTextBoxColumn";
            // 
            // olympicfacebookDataGridViewTextBoxColumn
            // 
            this.olympicfacebookDataGridViewTextBoxColumn.DataPropertyName = "olympic_facebook";
            this.olympicfacebookDataGridViewTextBoxColumn.HeaderText = "olympic_facebook";
            this.olympicfacebookDataGridViewTextBoxColumn.Name = "olympicfacebookDataGridViewTextBoxColumn";
            // 
            // olympiclogoDataGridViewTextBoxColumn
            // 
            this.olympiclogoDataGridViewTextBoxColumn.DataPropertyName = "olympic_logo";
            this.olympiclogoDataGridViewTextBoxColumn.HeaderText = "olympic_logo";
            this.olympiclogoDataGridViewTextBoxColumn.Name = "olympiclogoDataGridViewTextBoxColumn";
            // 
            // olympicyearDataGridViewTextBoxColumn
            // 
            this.olympicyearDataGridViewTextBoxColumn.DataPropertyName = "olympic_year";
            this.olympicyearDataGridViewTextBoxColumn.HeaderText = "olympic_year";
            this.olympicyearDataGridViewTextBoxColumn.Name = "olympicyearDataGridViewTextBoxColumn";
            // 
            // olympicseasonDataGridViewTextBoxColumn
            // 
            this.olympicseasonDataGridViewTextBoxColumn.DataPropertyName = "olympic_season";
            this.olympicseasonDataGridViewTextBoxColumn.HeaderText = "olympic_season";
            this.olympicseasonDataGridViewTextBoxColumn.Name = "olympicseasonDataGridViewTextBoxColumn";
            // 
            // olympicstartdateDataGridViewTextBoxColumn
            // 
            this.olympicstartdateDataGridViewTextBoxColumn.DataPropertyName = "olympic_start_date";
            this.olympicstartdateDataGridViewTextBoxColumn.HeaderText = "olympic_start_date";
            this.olympicstartdateDataGridViewTextBoxColumn.Name = "olympicstartdateDataGridViewTextBoxColumn";
            // 
            // olympicenddateDataGridViewTextBoxColumn
            // 
            this.olympicenddateDataGridViewTextBoxColumn.DataPropertyName = "olympic_end_date";
            this.olympicenddateDataGridViewTextBoxColumn.HeaderText = "olympic_end_date";
            this.olympicenddateDataGridViewTextBoxColumn.Name = "olympicenddateDataGridViewTextBoxColumn";
            // 
            // olympictorchimageDataGridViewTextBoxColumn
            // 
            this.olympictorchimageDataGridViewTextBoxColumn.DataPropertyName = "olympic_torch_image";
            this.olympictorchimageDataGridViewTextBoxColumn.HeaderText = "olympic_torch_image";
            this.olympictorchimageDataGridViewTextBoxColumn.Name = "olympictorchimageDataGridViewTextBoxColumn";
            // 
            // olympictorchcostDataGridViewTextBoxColumn
            // 
            this.olympictorchcostDataGridViewTextBoxColumn.DataPropertyName = "olympic_torch_cost";
            this.olympictorchcostDataGridViewTextBoxColumn.HeaderText = "olympic_torch_cost";
            this.olympictorchcostDataGridViewTextBoxColumn.Name = "olympictorchcostDataGridViewTextBoxColumn";
            // 
            // olympictorchdescriptionDataGridViewTextBoxColumn
            // 
            this.olympictorchdescriptionDataGridViewTextBoxColumn.DataPropertyName = "olympic_torch_description";
            this.olympictorchdescriptionDataGridViewTextBoxColumn.HeaderText = "olympic_torch_description";
            this.olympictorchdescriptionDataGridViewTextBoxColumn.Name = "olympictorchdescriptionDataGridViewTextBoxColumn";
            // 
            // olympictorchdesignerDataGridViewTextBoxColumn
            // 
            this.olympictorchdesignerDataGridViewTextBoxColumn.DataPropertyName = "olympic_torch_designer";
            this.olympictorchdesignerDataGridViewTextBoxColumn.HeaderText = "olympic_torch_designer";
            this.olympictorchdesignerDataGridViewTextBoxColumn.Name = "olympictorchdesignerDataGridViewTextBoxColumn";
            // 
            // olympictorchcountryDataGridViewTextBoxColumn
            // 
            this.olympictorchcountryDataGridViewTextBoxColumn.DataPropertyName = "olympic_torch_country";
            this.olympictorchcountryDataGridViewTextBoxColumn.HeaderText = "olympic_torch_country";
            this.olympictorchcountryDataGridViewTextBoxColumn.Name = "olympictorchcountryDataGridViewTextBoxColumn";
            // 
            // happencountryDataGridViewTextBoxColumn
            // 
            this.happencountryDataGridViewTextBoxColumn.DataPropertyName = "happen_country";
            this.happencountryDataGridViewTextBoxColumn.HeaderText = "happen_country";
            this.happencountryDataGridViewTextBoxColumn.Name = "happencountryDataGridViewTextBoxColumn";
            // 
            // enOlympicBindingSource
            // 
            this.enOlympicBindingSource.DataMember = "En_Olympic";
            this.enOlympicBindingSource.DataSource = this.olympicDataSetBindingSource;
            // 
            // olympicDataSetBindingSource
            // 
            this.olympicDataSetBindingSource.DataSource = this.olympicDataSet;
            this.olympicDataSetBindingSource.Position = 0;
            // 
            // olympicDataSet
            // 
            this.olympicDataSet.DataSetName = "olympicDataSet";
            this.olympicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabAthletes
            // 
            this.tabAthletes.Controls.Add(this.dgvAthletes);
            this.tabAthletes.Location = new System.Drawing.Point(4, 22);
            this.tabAthletes.Name = "tabAthletes";
            this.tabAthletes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAthletes.Size = new System.Drawing.Size(773, 364);
            this.tabAthletes.TabIndex = 1;
            this.tabAthletes.Text = "Athletes";
            this.tabAthletes.UseVisualStyleBackColor = true;
            // 
            // dgvAthletes
            // 
            this.dgvAthletes.AllowUserToAddRows = false;
            this.dgvAthletes.AllowUserToDeleteRows = false;
            this.dgvAthletes.AutoGenerateColumns = false;
            this.dgvAthletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAthletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteidDataGridViewTextBoxColumn,
            this.athleteteamidDataGridViewTextBoxColumn,
            this.athletenameDataGridViewTextBoxColumn,
            this.athletebirthdateDataGridViewTextBoxColumn,
            this.athleteheightDataGridViewTextBoxColumn,
            this.athleteweightDataGridViewTextBoxColumn,
            this.athletedateofdeathDataGridViewTextBoxColumn,
            this.athleteimageDataGridViewTextBoxColumn,
            this.athletegenderDataGridViewTextBoxColumn});
            this.dgvAthletes.DataSource = this.enAthleteBindingSource1;
            this.dgvAthletes.Location = new System.Drawing.Point(6, 6);
            this.dgvAthletes.MultiSelect = false;
            this.dgvAthletes.Name = "dgvAthletes";
            this.dgvAthletes.Size = new System.Drawing.Size(761, 352);
            this.dgvAthletes.TabIndex = 0;
            // 
            // athleteidDataGridViewTextBoxColumn
            // 
            this.athleteidDataGridViewTextBoxColumn.DataPropertyName = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.HeaderText = "athlete_id";
            this.athleteidDataGridViewTextBoxColumn.Name = "athleteidDataGridViewTextBoxColumn";
            // 
            // athleteteamidDataGridViewTextBoxColumn
            // 
            this.athleteteamidDataGridViewTextBoxColumn.DataPropertyName = "athlete_team_id";
            this.athleteteamidDataGridViewTextBoxColumn.HeaderText = "athlete_team_id";
            this.athleteteamidDataGridViewTextBoxColumn.Name = "athleteteamidDataGridViewTextBoxColumn";
            // 
            // athletenameDataGridViewTextBoxColumn
            // 
            this.athletenameDataGridViewTextBoxColumn.DataPropertyName = "athlete_name";
            this.athletenameDataGridViewTextBoxColumn.HeaderText = "athlete_name";
            this.athletenameDataGridViewTextBoxColumn.Name = "athletenameDataGridViewTextBoxColumn";
            // 
            // athletebirthdateDataGridViewTextBoxColumn
            // 
            this.athletebirthdateDataGridViewTextBoxColumn.DataPropertyName = "athlete_birthdate";
            this.athletebirthdateDataGridViewTextBoxColumn.HeaderText = "athlete_birthdate";
            this.athletebirthdateDataGridViewTextBoxColumn.Name = "athletebirthdateDataGridViewTextBoxColumn";
            // 
            // athleteheightDataGridViewTextBoxColumn
            // 
            this.athleteheightDataGridViewTextBoxColumn.DataPropertyName = "athlete_height";
            this.athleteheightDataGridViewTextBoxColumn.HeaderText = "athlete_height";
            this.athleteheightDataGridViewTextBoxColumn.Name = "athleteheightDataGridViewTextBoxColumn";
            // 
            // athleteweightDataGridViewTextBoxColumn
            // 
            this.athleteweightDataGridViewTextBoxColumn.DataPropertyName = "athlete_weight";
            this.athleteweightDataGridViewTextBoxColumn.HeaderText = "athlete_weight";
            this.athleteweightDataGridViewTextBoxColumn.Name = "athleteweightDataGridViewTextBoxColumn";
            // 
            // athletedateofdeathDataGridViewTextBoxColumn
            // 
            this.athletedateofdeathDataGridViewTextBoxColumn.DataPropertyName = "athlete_date_of_death";
            this.athletedateofdeathDataGridViewTextBoxColumn.HeaderText = "athlete_date_of_death";
            this.athletedateofdeathDataGridViewTextBoxColumn.Name = "athletedateofdeathDataGridViewTextBoxColumn";
            // 
            // athleteimageDataGridViewTextBoxColumn
            // 
            this.athleteimageDataGridViewTextBoxColumn.DataPropertyName = "athlete_image";
            this.athleteimageDataGridViewTextBoxColumn.HeaderText = "athlete_image";
            this.athleteimageDataGridViewTextBoxColumn.Name = "athleteimageDataGridViewTextBoxColumn";
            // 
            // athletegenderDataGridViewTextBoxColumn
            // 
            this.athletegenderDataGridViewTextBoxColumn.DataPropertyName = "athlete_gender";
            this.athletegenderDataGridViewTextBoxColumn.HeaderText = "athlete_gender";
            this.athletegenderDataGridViewTextBoxColumn.Name = "athletegenderDataGridViewTextBoxColumn";
            // 
            // enAthleteBindingSource1
            // 
            this.enAthleteBindingSource1.DataMember = "En_Athlete";
            this.enAthleteBindingSource1.DataSource = this.olympicDataSetBindingSource;
            // 
            // enAthleteBindingSource
            // 
            this.enAthleteBindingSource.DataMember = "En_Athlete";
            this.enAthleteBindingSource.DataSource = this.olympicDataSetBindingSource;
            // 
            // en_AthleteTableAdapter
            // 
            this.en_AthleteTableAdapter.ClearBeforeFill = true;
            // 
            // en_OlympicTableAdapter
            // 
            this.en_OlympicTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(799, 34);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(799, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddAthlete
            // 
            this.btnAddAthlete.Location = new System.Drawing.Point(799, 114);
            this.btnAddAthlete.Name = "btnAddAthlete";
            this.btnAddAthlete.Size = new System.Drawing.Size(108, 34);
            this.btnAddAthlete.TabIndex = 3;
            this.btnAddAthlete.Text = "Add Athlete";
            this.btnAddAthlete.UseVisualStyleBackColor = true;
            this.btnAddAthlete.Click += new System.EventHandler(this.btnAddAthlete_Click);
            // 
            // btnAddOlympic
            // 
            this.btnAddOlympic.Location = new System.Drawing.Point(799, 154);
            this.btnAddOlympic.Name = "btnAddOlympic";
            this.btnAddOlympic.Size = new System.Drawing.Size(108, 34);
            this.btnAddOlympic.TabIndex = 4;
            this.btnAddOlympic.Text = "Add Olympic";
            this.btnAddOlympic.UseVisualStyleBackColor = true;
            this.btnAddOlympic.Click += new System.EventHandler(this.btnAddOlympic_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(799, 364);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(108, 34);
            this.btnRefreshList.TabIndex = 5;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(941, 415);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnAddOlympic);
            this.Controls.Add(this.btnAddAthlete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Olympic Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOlympics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOlympics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enOlympicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olympicDataSet)).EndInit();
            this.tabAthletes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAthletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enAthleteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enAthleteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOlympics;
        private System.Windows.Forms.TabPage tabAthletes;
        private System.Windows.Forms.DataGridView dgvOlympics;
        private System.Windows.Forms.BindingSource olympicDataSetBindingSource;
        private olympicDataSet olympicDataSet;
        private System.Windows.Forms.BindingSource enAthleteBindingSource;
        private olympicDataSetTableAdapters.En_AthleteTableAdapter en_AthleteTableAdapter;
        private System.Windows.Forms.BindingSource enOlympicBindingSource;
        private olympicDataSetTableAdapters.En_OlympicTableAdapter en_OlympicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicsponsorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicwebsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictwitterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicfacebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympiclogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicseasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympicenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictorchimageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictorchcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictorchdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictorchdesignerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn olympictorchcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn happencountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAthletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteteamidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletebirthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteheightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletedateofdeathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteimageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athletegenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource enAthleteBindingSource1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddAthlete;
        private System.Windows.Forms.Button btnAddOlympic;
        private System.Windows.Forms.Button btnRefreshList;
    }
}

