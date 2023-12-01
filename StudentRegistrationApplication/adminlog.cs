using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class adminlog : Form
    {
        public adminlog()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin") 
            { 
                this.Hide();
                MessageBox.Show("You have successfully logged in.");
           
            }
            else 
            {
                MessageBox.Show("Account invalid. Please try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
