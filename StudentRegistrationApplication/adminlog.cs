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
            adminDashboard admindash = new adminDashboard();

            if (txtUserName.Text == "admin" && txtPassword.Text == "admin") 
            { 
                this.Hide();
                MessageBox.Show("You have successfully logged in.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admindash.Show();
            }
            else 
            {
                MessageBox.Show("Account invalid. Please try again.", "System",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void adminlog_Load(object sender, EventArgs e)
        {

        }
    }
}
