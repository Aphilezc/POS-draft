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
    public partial class ExecInterface : Form
    {
        public static int SupOrderID;
        public ExecInterface()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExecInterface_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst8DataSet.Inv' table. You can move, or remove it, as needed.
            this.invTableAdapter.FillByProdName(this.groupWst8DataSet.Inv);
            // TODO: This line of code loads data into the 'groupWst8DataSet.Inv' table. You can move, or remove it, as needed.
            this.invTableAdapter.FillByProdName(this.groupWst8DataSet.Inv);
            // TODO: This line of code loads data into the 'groupWst8DataSet.Prod' table. You can move, or remove it, as needed.
            this.prodTableAdapter.Fill(this.groupWst8DataSet.Prod);
            // TODO: This line of code loads data into the 'groupWst8DataSet1.SupOrder' table. You can move, or remove it, as needed.
            this.supOrderTableAdapter.Fill(this.groupWst8DataSet1.SupOrder);
            // TODO: This line of code loads data into the 'groupWst8DataSet1.Sup' table. You can move, or remove it, as needed.
            this.supTableAdapter.Fill(this.groupWst8DataSet1.Sup);
            //the
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            supTableAdapter.FillBySupplierName(groupWst8DataSet1.Sup, textBox1.Text);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        groupBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

        //        int supOrderID = 0;
        //        if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[1].Value != null)
        //        {
        //            supOrderID = (int)dataGridView1.CurrentRow.Cells[1].Value;
        //        }

        //        supOrderTableAdapter.FillBySupOrderID(groupWst8DataSet1.SupOrder, supOrderID);
        //        SupOrderID = supOrderID;
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        // Handle the null instance exception here
        //        // You can display an error message or perform any necessary actions
        //        MessageBox.Show("Null instance error: " + ex.Message);
        //    }
        //}


        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
          supOrderTableAdapter.FillBySupOrderID(groupWst8DataSet1.SupOrder, (int)dataGridView2.CurrentRow.Cells[0].Value);

           SupOrderID = (int)dataGridView1.CurrentRow.Cells[1].Value;
           groupBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();


        }
    }
}
