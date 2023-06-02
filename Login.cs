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
    public partial class Login : Form
    {
        public static int staffID;
        public static string role,fullName;
        
        
        public Login()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //checks the login details of staff members
                staffLoginTableAdapter1.CheckLogin(groupWst8DataSet1.StaffLogin, int.Parse(StaffNumberTextBox.Text), int.Parse(StaffPINTextBox.Text));

                if (groupWst8DataSet1.StaffLogin.Rows.Count > 0)

                {

                    // MessageBox.Show("You've successfully logged in.", "LOGIN SUCCESS", MessageBoxButtons.OK); 



                    PointOfSale pos = new PointOfSale();

                    staffID = (int)groupWst8DataSet1.StaffLogin.Rows[0][1];

                    stafTableAdapter1.FillBySfaffNo(groupWst8DataSet1.staf, staffID);

                    role = groupWst8DataSet1.staf.Rows[0][9].ToString();

                    fullName = groupWst8DataSet1.staf.Rows[0][1].ToString() + " " + groupWst8DataSet1.staf.Rows[0][2].ToString();



                    if (role == "Cashier")

                    {

                        pos.Show();

                        this.Hide();

                    }

                    else 
                    {

                        ExecInterface exec = new ExecInterface();

                        exec.Show();

                        this.Hide();

                    }

                    StaffNumberTextBox.Clear();
                    StaffPINTextBox.Clear();
                    this.Hide();

                }
            }

            catch

            {

                MessageBox.Show("Please type in your staff number and pin to login.", "Login Error", MessageBoxButtons.OK);
            }

           // PointOfSale m = new PointOfSale();
         //   m.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            StaffNumberTextBox.Clear();
            StaffPINTextBox.Clear();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
