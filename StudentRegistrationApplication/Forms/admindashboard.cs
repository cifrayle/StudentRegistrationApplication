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
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        // functionalities of the forms
        public void loadForm(object Form) 
        {
            if (this.homePanel.Controls.Count > 0)
                this.homePanel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.homePanel.Controls.Add(form);
            this.homePanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        // For hovering the form around
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            // some conditions to the response of user
            var response = MessageBox.Show("Are you sure you want to log out? ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (response == DialogResult.Yes)
            {
                this.Hide();
                adminlog admin = new adminlog();
                admin.Show();
            }
            else if (response == DialogResult.No) 
            {   
                this.Show();
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
 
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // also for hovering around the form making it interactive
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else 
            { 
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_homePage_Click(object sender, EventArgs e)
        {
            loadForm(new homePageForm());
        }

        private void btn_Registered_Click(object sender, EventArgs e)
        {
            loadForm(new registeredForm());
        }

        private void btn_Enrolled_Click(object sender, EventArgs e)
        {
            loadForm(new enrolledForm());
        }
    }
}
