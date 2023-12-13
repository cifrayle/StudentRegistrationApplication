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
    // adminDashboard class represents the main form of the application for administrators
    public partial class adminDashboard : Form
    {
        // Instance of registeredForm to manage registered student information
        private registeredForm regForm;

        // Constructor for adminDashboard, receives an instance of registeredForm
        public adminDashboard(registeredForm regForm)
        {
            InitializeComponent();
            // Set the received instance of registeredForm
            this.regForm = regForm;

            // Initialize UI elements, such as side panel and window properties
            panel_Side.Height = btn_homePage.Height;
            panel_Side.Top = btn_homePage.Top;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        // Method that manages dynamic loading of forms into the homePanel
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        // Import user32 DLL functions for dragging the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void admindashboard_Load(object sender, EventArgs e)
        {
            // Additional initialization code can be added here if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Additional paint-related code can be added here if needed
        }

        // Event handler for the button3 (Logout) click event
        private void button3_Click(object sender, EventArgs e)
        {
            // Change side panel appearance
            panel_Side.Height = btn_Logout.Height;
            panel_Side.Top = btn_Logout.Top;

            // Prompt user with a confirmation dialog
            DialogResult response = MessageBox.Show("Are you sure you want to log out? ", "System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            // Handle user response
            if (response == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();
                // Create a new adminlog form with the provided instance of registeredForm
                adminlog admin = new adminlog(regForm);
                admin.Show();
            }
            else if (response == DialogResult.No)
            {
                // Show the current form
                this.Show();
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
        }

        // Event handler for the topPanel mouse down event
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging the form by capturing mouse movements
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // maximize
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

        // exit
        private void button4_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        // mininmize
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
        }

        // home page form 
        private void btn_homePage_Click(object sender, EventArgs e)
        {
            // Change side panel appearance
            panel_Side.Height = btn_homePage.Height;
            panel_Side.Top = btn_homePage.Top;

            // Load the homePageForm into the homePanel
            loadForm(new homePageForm());
        }

        // registered students dashboard
        private void btn_Registered_Click(object sender, EventArgs e)
        {
            // Change side panel appearance
            panel_Side.Height = btn_Registered.Height;
            panel_Side.Top = btn_Registered.Top;

            // Manually set up registeredForm for display in the homePanel
            regForm.TopLevel = false;
            regForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(regForm);
            this.mainPanel.Tag = regForm;
            regForm.BringToFront();
            regForm.Show();
        }
 
        private void homePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            // Additional paint-related code can be added here if needed
        }
    }
}
