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
            string middleName = textBoxMiddleName.Text;
            string programApplied = comboBoxProgram.Text;


            // Check if any of the textboxes is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(programApplied) || string.IsNullOrEmpty(middleName))
            {
                // Display a message or handle the empty data situation as needed
                MessageBox.Show("Please enter all required information.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            } else if (dtp_DateOfBirth.Value == DateTimePicker.MinimumDateTime || !rbtn_Male.Checked && !rbtn_Female.Checked) 
            {
                MessageBox.Show("Please enter all required information.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
            }
            else
            {
                // Pass the entered information to the shared instance of registeredForm
                regForm.AddPersonalInformation(lastName, firstName, programApplied, middleName);
                MessageBox.Show("Registration success!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

                // Clear the text in the textboxes
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                comboBoxProgram.Text = "";
                textBoxMiddleName.Text = "";

            }
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
            DialogResult result = MessageBox.Show("Do you want to log in as admin? ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                this.Hide();
                adminlog adminlog = new adminlog(regForm);
                adminlog.Show();
            }
        }
        // image upload
        private void btn_ImageUp_Click(object sender, EventArgs e)
        {
            String imageLoc = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = dialog.FileName;

                    circularPicBox1.ImageLocation = imageLoc;
                } 
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured. Please try again.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log in as admin? ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                adminlog adminlog = new adminlog(regForm);
                adminlog.Show();
            }
        }
    }
}
