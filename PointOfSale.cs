using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryParse1
{
    public partial class PointOfSale : Form
    {
        public static int custID;

        public PointOfSale()
        {
            InitializeComponent();
           WindowState = FormWindowState.Maximized; 

        }

        private void CusSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            cusTableAdapter2.FillByCustPhoneNo(groupWst8DataSet.Cus, CusSearchTxtBox.Text);
            
            /* cus1TableAdapter.FillByPhoneNmbr(groupWst8DataSet.Cus1, CusSearchTxtBox.Text);
            
            // enables the Add Customer Button if there are no customer matches according to the customer search
            if (dataGridView1 != null)
            {
                AddCusBtn.Enabled = false;
            }
            else
            {
                AddCusBtn.Enabled = true;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst8DataSet.InvTable' table. You can move, or remove it, as needed.
            this.invTableTableAdapter.Fill(this.groupWst8DataSet1.InvTable);
            // TODO: This line of code loads data into the 'groupWst8DataSet.Inv' table. You can move, or remove it, as needed.
            this.invTableAdapter.FillByProdName(this.groupWst8DataSet.Inv);
          
            // TODO: This line of code loads data into the 'groupWst8DataSet1.Prod' table. You can move, or remove it, as needed.
            this.prodTableAdapter.Fill(this.groupWst8DataSet1.Prod);
            // TODO: This line of code loads data into the 'groupWst8DataSet.CusSaleDetail' table. You can move, or remove it, as needed.
            this.cusSaleDetailTableAdapter.Fill(this.groupWst8DataSet.CusSaleDetail);
            // TODO: This line of code loads data into the 'groupWst8DataSet.Prod' table. You can move, or remove it, as needed.
           // this.cusTableAdapter1.Fill(this.groupWst8DataSet.Cus);

            // TODO: This line of code loads data into the 'groupWst8DataSet.Prod' table. You can move, or remove it, as needed.
            this.prodTableAdapter.Fill(this.groupWst8DataSet.Prod);

            // TimeLabel.Text = DateTime.Now.ToString();
            //TimeLabel.Text = CurrentDateTime.ToString(); 
            timer1.Start();
            comboBox1.SelectedIndex = -1;
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem.ToString();


            /*Code to filter search by customer Type
             if (comboBox1.Items.Count > 1)
            {
                cusTableAdapter.FillByCusType(groupWst8DataSet.Cus, comboBox1.Text);
            }*/
           
               
        }

    
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //When a row is double clicked, the sales tab will open
            tabControl1.SelectedIndex = 1;

            /*DataRow dr;
            dr = groupWst8DataSet.Cus.NewRow(); 

           for (int i =0; i< dr.ItemArray.Length; i++)
            {
                dr[i] = dataGridView1.CurrentRow.Cells[i].Value; 
            }
             //dataGridView2.ClearSelection(); clears the selection before adding
            groupWst8DataSet.Cus.Rows.Add(dr);*/


        }

        private void EditCusBtn_Click(object sender, EventArgs e)
        {
           /* EditCusGroupBox.Enabled = true;
            dataGridView2.Enabled = true;
            
            /*DataRow dr;
            dr = groupWst8DataSet.Cus.NewRow();

            dr[1] = dataGridView1.CurrentRow.Cells[1].Value;
            dr[2] = dataGridView1.CurrentRow.Cells[2].Value;
            dr[3] = dataGridView1.CurrentRow.Cells[3].Value;
            dr[4] = dataGridView1.CurrentRow.Cells[4].Value;
            dr[5] = dataGridView1.CurrentRow.Cells[5].Value;

            groupWst8DataSet.Cus.Rows.Add(dr);*/
        }

        private void AddCusBtn_Click(object sender, EventArgs e)
        {
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProdSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            prodTableAdapter.FillByProdName(groupWst8DataSet.Prod, ProdSearchTxtBox.Text); 
        }

        private void MenuDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Displays the sale records of the selected customer
            cusSaleTableAdapter2.FillByCustID(groupWst8DataSet.CusSale, (int)dataGridView1.CurrentRow.Cells[0].Value);
            custID= (int)dataGridView1.CurrentRow.Cells[0].Value;
            //TimeLabel.Text = DateTime.Now.ToString();
           // CustLabel.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //Displays the selected customer's name and surname on the Order GroupBox's text field
            CusOrderGroupBox.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tabControl1.SelectedIndex = 1; 
        }

        private void ViewCusRecBtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogOuT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to log out? You will have to log in again to uilise these resources.", "Confirm log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login newlogin = new Login();
                newlogin.Show();
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ////Displays the sale records of the selected customer
            //cusSaleTableAdapter2.FillByCustID(groupWst8DataSet.CusSale, (int)dataGridView1.CurrentRow.Cells[0].Value);

            ////TimeLabel.Text = DateTime.Now.ToString();
            //// CustLabel.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();

            ////Displays the selected customer's name and surname on the Order GroupBox's text field
            //CusOrderGroupBox.Text = "ORDER FOR:  " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add_Customer newcustomer = new Add_Customer();
            newcustomer.Show();
            //  cusTableAdapter2.InsertCustomer()
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add_Customer newcustomer = new Add_Customer();
            newcustomer.Show();
        }

        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //producttable
         }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("hello");
           /* DataRow dr;
            dr = groupWst8DataSet1.Inv.NewRow();
            dr[0] = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            dr[1] = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            groupWst8DataSet1.Inv.Rows.Add(dr);*/

            DataRow dr;
            dr = groupWst8DataSet.Cus.NewRow();

            for (int i = 1; i < dr.ItemArray.Length; i++)
            {
                dr[i] = dataGridView1.CurrentRow.Cells[i].Value;
            }

            groupWst8DataSet1.Inv.Rows.Add(dr);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("hi aphile");
            DataRow dr;
            dr = groupWst8DataSet.Cus.NewRow();

            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                dr[i] = dataGridView1.CurrentRow.Cells[i].Value;
            }
            groupWst8DataSet1.Inv.Rows.Add(dr);
            
            //.InsertQuery1(textBox1.Text, textBox2.Text, phoneNo.Text, textBox4.Text, cusMailAddress.Text, cusAddress.Text, CusRegion.Text, cusCity.Text);
           // this.cusTableAdapter.Fill(this.groupWst8DataSet.Cus);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //clear
        }

        private void dataGridView4_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRow dr;
            dr = groupWst8DataSet1.InvTable.NewRow();

            
            
            dr[0] = dataGridView4.CurrentRow.Cells[1].Value;
           // string sellprice = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dr[1] = dataGridView4.CurrentRow.Cells[2].Value;
            dr[2] = dataGridView4.CurrentRow.Cells[3].Value;
          dr[3] = dataGridView4.CurrentRow.Cells[0].Value;
            dr[5] = custID;

            groupWst8DataSet1.InvTable.Rows.Add(dr);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //deletebutton
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////finaliseorder
            foreach (DataGridViewRow row in invTableDataGridView.Rows)
            {
                int SelectedQuantity = Convert.ToInt32(invTableDataGridView.CurrentRow.Cells[5].Value);
                decimal ProdSellingPrice = Convert.ToInt32(invTableDataGridView.CurrentRow.Cells[2].Value);
                decimal SubTotal = SelectedQuantity * ProdSellingPrice;

                row.Cells[6].Value = SubTotal;
               
            }
            decimal total = getTotal();
            TotalTxtBox.Text = total.ToString();

            // now lets record it in the cus sale detail table
            MessageBox.Show("You are about to get the receipt");
            cusSaleDetailTableAdapter.InsertCusSaleDetail(int.Parse("5019"), int.Parse("332"), int.Parse("4"), int.Parse("35"));
            MessageBox.Show("The recipet is ready");
            // but this is not correct way, we should do an iteration for every item in the order table





            //DataRow dr;
            ////dr = groupWst8DataSet1.InvTable.NewRow();

            //dr[0] = dataGridView4.CurrentRow.Cells[1].Value;
            
            ////dr[1] = dataGridView4.CurrentRow.Cells[2].Value;
            ////dr[2] = dataGridView4.CurrentRow.Cells[3].Value;
            //////dr[3] = dataGridView4.CurrentRow.Cells[0].Value;
            ////dr[5] = custID;
            ////invTableDataGridView.CurrentRow.Cells[6].Value = SubTotal;

            ////orderTotaltext.Text = sum.ToString("C2");
            ////getQuantity.Text = totalquantity.ToString("N2");

        }
        private decimal getTotal()

        {

            decimal sum = 0;

            foreach (DataGridViewRow row in invTableDataGridView.Rows)

            {

                decimal subtotal;

                if (decimal.TryParse(row.Cells[6].Value?.ToString(), out subtotal))

                {

                    sum += subtotal;

                }

            }

            return sum; 
        }

            private void TotalTxtBox_TextChanged(object sender, EventArgs e)
        {
            //taltextbox
        }

        private void CashPaymBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale has been finalised.");

            cusSaleTableAdapter1.InsertCusSale(custID, int.Parse("45"), "Complete", DateTime.Now, int.Parse("200"), "Cash", decimal.Parse(TotalTxtBox.Text, System.Globalization.NumberStyles.Currency), int.Parse("5019"));
            MessageBox.Show("Sale has been finalised.");
        }

        private void invTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CardPaymBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale has been finalised.");

            cusSaleTableAdapter1.InsertCusSale(custID, int.Parse("7"), "Complete", DateTime.Now, int.Parse("200"), "Card", decimal.Parse(TotalTxtBox.Text, System.Globalization.NumberStyles.Currency), int.Parse("5019"));
            MessageBox.Show("Sale has been finalised.");
        }
    }

        /* {

        //searching for products using product name 
        //   prodTableAdapter2.FillByProdNae(groupWst8DataSet.Cus, ProdSearchTxtBox.Text);

    }*/

    }

