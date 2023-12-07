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
        // Create a single instance of registeredForm
        private registeredForm regForm = new registeredForm();

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
            // Get entered personal information from textboxes
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string programApplied = textBoxProgram.Text;
            string middleName = textBoxMiddleName.Text;

            // Pass the entered information to the shared instance of registeredForm
            regForm.AddPersonalInformation(lastName, firstName, programApplied, middleName);
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlog adminlog = new adminlog(regForm); // Pass the instance of registeredForm
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
            adminlog adminlog = new adminlog(regForm);
            adminlog.Show();
        }
    }
}
