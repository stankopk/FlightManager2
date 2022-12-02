namespace FlightManager.Views
{
    partial class BookingsView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flightsDBDataSet = new FlightManager.FlightsDBDataSet();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsTableAdapter = new FlightManager.FlightsDBDataSetTableAdapters.BookingsTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBusinessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.personalIDDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.isBusinessDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bookingsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // flightsDBDataSet
            // 
            this.flightsDBDataSet.DataSetName = "FlightsDBDataSet";
            this.flightsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.flightsDBDataSet;
            // 
            // bookingsTableAdapter
            // 
            this.bookingsTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalIDDataGridViewTextBoxColumn
            // 
            this.personalIDDataGridViewTextBoxColumn.DataPropertyName = "PersonalID";
            this.personalIDDataGridViewTextBoxColumn.HeaderText = "PersonalID";
            this.personalIDDataGridViewTextBoxColumn.Name = "personalIDDataGridViewTextBoxColumn";
            this.personalIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isBusinessDataGridViewCheckBoxColumn
            // 
            this.isBusinessDataGridViewCheckBoxColumn.DataPropertyName = "IsBusiness";
            this.isBusinessDataGridViewCheckBoxColumn.HeaderText = "IsBusiness";
            this.isBusinessDataGridViewCheckBoxColumn.Name = "isBusinessDataGridViewCheckBoxColumn";
            this.isBusinessDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // BookingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookingsView";
            this.Text = "BookingsView";
            this.Load += new System.EventHandler(this.BookingsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FlightsDBDataSet flightsDBDataSet;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private FlightsDBDataSetTableAdapters.BookingsTableAdapter bookingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBusinessDataGridViewCheckBoxColumn;
    }
}