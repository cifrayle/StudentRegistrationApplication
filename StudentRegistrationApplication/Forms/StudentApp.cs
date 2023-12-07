using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication.Forms
{
    public partial class StudentApp : Form
    {
        public static string firstName = "";
        public static string lastName = "";
        public static string programApplied = "";
        public StudentApp()
        {
            InitializeComponent();
        }
        // For hovering around the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void StudentApp_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            // also for hovering around the form making it interactive
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            firstName = textBoxFirstName.Text;
            lastName = textBoxLastName.Text;
            programApplied = textBoxProgram.Text;
            registeredForm regForm = new registeredForm();
            regForm.Focus();
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlog adminlog = new adminlog();
            adminlog.Show();
        }

        private void lbx_LastName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbx_FirstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_adminLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlog adminlog = new adminlog();
            adminlog.Show();
        }
    }
}
