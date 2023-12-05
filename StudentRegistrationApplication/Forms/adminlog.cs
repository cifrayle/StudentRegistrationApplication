using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
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
        // For hovering around the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // admin's account, errors and conditions
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                //MessageBox.Show("You have successfully logged in.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminDashboard admindash = new adminDashboard();
                admindash.Show();
            }
            // this line won't display anything if the user entered an empty text.
            else if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                this.Show();
            }
            else 
            { 
                MessageBox.Show("Account invalid. Please try again.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // exit the login form. go back to student registration form
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void adminlog_Load(object sender, EventArgs e)
        {
            // accepting enter key
            this.AcceptButton = btn_Login;
        }

        private void btn_exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            // also for hovering around the form making it interactive
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
