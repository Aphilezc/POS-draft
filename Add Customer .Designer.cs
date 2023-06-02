
namespace TryParse1
{
    partial class Add_Customer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CusName = new System.Windows.Forms.Label();
            this.CusSurname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.cusType = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cusMailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cusAddress = new System.Windows.Forms.TextBox();
            this.CusRegion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CityCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cusCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custStreetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst8DataSet = new TryParse1.GroupWst8DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.cusTableAdapter = new TryParse1.GroupWst8DataSetTableAdapters.CusTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst8DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(179, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 0;
            // 
            // CusName
            // 
            this.CusName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CusName.AutoSize = true;
            this.CusName.Location = new System.Drawing.Point(20, 71);
            this.CusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(82, 13);
            this.CusName.TabIndex = 1;
            this.CusName.Text = "Customer Name";
            this.CusName.Click += new System.EventHandler(this.label1_Click);
            // 
            // CusSurname
            // 
            this.CusSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CusSurname.AutoSize = true;
            this.CusSurname.Location = new System.Drawing.Point(20, 108);
            this.CusSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CusSurname.Name = "CusSurname";
            this.CusSurname.Size = new System.Drawing.Size(96, 13);
            this.CusSurname.TabIndex = 3;
            this.CusSurname.Text = "Customer Surname";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(179, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // phoneNo
            // 
            this.phoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.phoneNo.Location = new System.Drawing.Point(179, 142);
            this.phoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(154, 20);
            this.phoneNo.TabIndex = 4;
            // 
            // cusType
            // 
            this.cusType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cusType.AutoSize = true;
            this.cusType.Location = new System.Drawing.Point(20, 195);
            this.cusType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cusType.Name = "cusType";
            this.cusType.Size = new System.Drawing.Size(78, 13);
            this.cusType.TabIndex = 7;
            this.cusType.Text = "Customer Type";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Location = new System.Drawing.Point(179, 190);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // cusMailAddress
            // 
            this.cusMailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cusMailAddress.Location = new System.Drawing.Point(179, 235);
            this.cusMailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cusMailAddress.Name = "cusMailAddress";
            this.cusMailAddress.Size = new System.Drawing.Size(154, 20);
            this.cusMailAddress.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer Email Address";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Street Address";
            // 
            // cusAddress
            // 
            this.cusAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cusAddress.Location = new System.Drawing.Point(457, 71);
            this.cusAddress.Margin = new System.Windows.Forms.Padding(2);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(667, 20);
            this.cusAddress.TabIndex = 13;
            // 
            // CusRegion
            // 
            this.CusRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CusRegion.Location = new System.Drawing.Point(457, 129);
            this.CusRegion.Margin = new System.Windows.Forms.Padding(2);
            this.CusRegion.Name = "CusRegion";
            this.CusRegion.Size = new System.Drawing.Size(667, 20);
            this.CusRegion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Region";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // CityCode
            // 
            this.CityCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CityCode.Location = new System.Drawing.Point(457, 225);
            this.CityCode.Margin = new System.Windows.Forms.Padding(2);
            this.CityCode.Name = "CityCode";
            this.CityCode.Size = new System.Drawing.Size(667, 20);
            this.CityCode.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "City Code";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 17;
            // 
            // cusCity
            // 
            this.cusCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cusCity.Location = new System.Drawing.Point(457, 180);
            this.cusCity.Margin = new System.Windows.Forms.Padding(2);
            this.cusCity.Name = "cusCity";
            this.cusCity.Size = new System.Drawing.Size(667, 20);
            this.cusCity.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 184);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custSurnameDataGridViewTextBoxColumn,
            this.custPhoneNoDataGridViewTextBoxColumn,
            this.cusTypeDataGridViewTextBoxColumn,
            this.custEmailAddressDataGridViewTextBoxColumn,
            this.custStreetAddressDataGridViewTextBoxColumn,
            this.custRegionDataGridViewTextBoxColumn,
            this.custCityDataGridViewTextBoxColumn,
            this.custCityCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1303, 122);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.custNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // custSurnameDataGridViewTextBoxColumn
            // 
            this.custSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustSurname";
            this.custSurnameDataGridViewTextBoxColumn.HeaderText = "CustSurname";
            this.custSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custSurnameDataGridViewTextBoxColumn.Name = "custSurnameDataGridViewTextBoxColumn";
            this.custSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.custSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // custPhoneNoDataGridViewTextBoxColumn
            // 
            this.custPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "CustPhoneNo";
            this.custPhoneNoDataGridViewTextBoxColumn.HeaderText = "CustPhoneNo";
            this.custPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custPhoneNoDataGridViewTextBoxColumn.Name = "custPhoneNoDataGridViewTextBoxColumn";
            this.custPhoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.custPhoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusTypeDataGridViewTextBoxColumn
            // 
            this.cusTypeDataGridViewTextBoxColumn.DataPropertyName = "Cus_Type";
            this.cusTypeDataGridViewTextBoxColumn.HeaderText = "Cus_Type";
            this.cusTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusTypeDataGridViewTextBoxColumn.Name = "cusTypeDataGridViewTextBoxColumn";
            this.cusTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // custEmailAddressDataGridViewTextBoxColumn
            // 
            this.custEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "CustEmailAddress";
            this.custEmailAddressDataGridViewTextBoxColumn.HeaderText = "CustEmailAddress";
            this.custEmailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custEmailAddressDataGridViewTextBoxColumn.Name = "custEmailAddressDataGridViewTextBoxColumn";
            this.custEmailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.custEmailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // custStreetAddressDataGridViewTextBoxColumn
            // 
            this.custStreetAddressDataGridViewTextBoxColumn.DataPropertyName = "CustStreetAddress";
            this.custStreetAddressDataGridViewTextBoxColumn.HeaderText = "CustStreetAddress";
            this.custStreetAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custStreetAddressDataGridViewTextBoxColumn.Name = "custStreetAddressDataGridViewTextBoxColumn";
            this.custStreetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.custStreetAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // custRegionDataGridViewTextBoxColumn
            // 
            this.custRegionDataGridViewTextBoxColumn.DataPropertyName = "CustRegion";
            this.custRegionDataGridViewTextBoxColumn.HeaderText = "CustRegion";
            this.custRegionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custRegionDataGridViewTextBoxColumn.Name = "custRegionDataGridViewTextBoxColumn";
            this.custRegionDataGridViewTextBoxColumn.ReadOnly = true;
            this.custRegionDataGridViewTextBoxColumn.Width = 125;
            // 
            // custCityDataGridViewTextBoxColumn
            // 
            this.custCityDataGridViewTextBoxColumn.DataPropertyName = "CustCity";
            this.custCityDataGridViewTextBoxColumn.HeaderText = "CustCity";
            this.custCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custCityDataGridViewTextBoxColumn.Name = "custCityDataGridViewTextBoxColumn";
            this.custCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.custCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // custCityCodeDataGridViewTextBoxColumn
            // 
            this.custCityCodeDataGridViewTextBoxColumn.DataPropertyName = "CustCityCode";
            this.custCityCodeDataGridViewTextBoxColumn.HeaderText = "CustCityCode";
            this.custCityCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custCityCodeDataGridViewTextBoxColumn.Name = "custCityCodeDataGridViewTextBoxColumn";
            this.custCityCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.custCityCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cusBindingSource
            // 
            this.cusBindingSource.DataMember = "Cus";
            this.cusBindingSource.DataSource = this.groupWst8DataSet;
            // 
            // groupWst8DataSet
            // 
            this.groupWst8DataSet.DataSetName = "GroupWst8DataSet";
            this.groupWst8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1154, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cusTableAdapter
            // 
            this.cusTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1183, 155);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "Show records";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(329, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Add New Customer";
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 451);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cusCity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CityCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CusRegion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cusAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cusMailAddress);
            this.Controls.Add(this.cusType);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.CusSurname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Customer";
            this.Load += new System.EventHandler(this.Add_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst8DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.Label CusSurname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.Label cusType;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cusMailAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cusAddress;
        private System.Windows.Forms.TextBox CusRegion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CityCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cusCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GroupWst8DataSet groupWst8DataSet;
        private System.Windows.Forms.BindingSource cusBindingSource;
        private GroupWst8DataSetTableAdapters.CusTableAdapter cusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custStreetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
    }
}