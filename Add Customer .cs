using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TryParse1
{
    
    public partial class Add_Customer : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Add_Customer()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst8DataSet.Cus' table. You can move, or remove it, as needed.
           // this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);

            // Connect to the SQL database
           /* string connectionString = "GroupWst8ConnectionString";
           connectionString = new GroupWst8ConnectionString(connectionString);
            GroupWst8ConnectionStringOpen();

            // Retrieve data from the SQL database
            string query = "SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            dataAdapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Set the DataTable as the data source for the DataGridView
            dataGridView.DataSource = dataTable;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cusTableAdapter.InsertCustomer(CusName.Text,CusSurname.Text, phoneNo.Text, textBox4.Text, cusMailAddress.Text, cusAddress.Text, CusRegion.Text, cusCity.Text, int.Parse(CityCode.Text));
            cusTableAdapter.InsertQuery1(textBox1.Text, textBox2.Text, phoneNo.Text, textBox4.Text, cusMailAddress.Text, cusAddress.Text, CusRegion.Text, cusCity.Text);
            this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);
            // Get the selected row index
            // int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            /* // Get the new data from the TextBoxes
             string CustName = CusName.Text;
             string CustSurname = CusSurname.Text;
             //string Custaddress = cusAddress.Text;
             string CustPhoneNo = phoneNo.Text;
             string CusType = textBox4.Text;
             string CustEmailAddress = cusMailAddress.Text;
             string CustStreetAddress = cusAddress.Text;
             string CustRegion = CusRegion.Text;
             string CustCity = cusCity.Text;
             string CusCityCode = CityCode.Text;*/

            // Get the new data from the TextBoxes
            /* dataGridView1.Rows.Add(int.Parse(cusId.Text),
                CusName.Text,
             CusSurname.Text,

            int.Parse(phoneNo.Text),
             textBox4.Text,
              cusMailAddress.Text,
            cusAddress.Text,
          CusRegion.Text,
             cusCity.Text,
            CityCode.Text);*/

            // this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);
            //dataGridView2.Rows.Add(cusId.Text);




            // this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);
        }
    }
}
