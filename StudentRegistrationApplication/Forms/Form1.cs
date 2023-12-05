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
    public partial class Form1 : Form
    {
        // some variables used in register student button.
        public static string firstName = "";
        public static string lastName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminlog adminlog = new adminlog();
            adminlog.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // button - register student
        private void button2_Click(object sender, EventArgs e)
        {
            // Get the first name entered by the user from the text box.
            firstName = tb_FirstName.Text;

            // Add the first name to the list box for display.
            lbx_FirstName.Items.Add(firstName);

            // Get the last name entered by the user from the text box.
            lastName = tb_LastName.Text;

            // Add the last name to the list box for display.
            lbx_LastName.Items.Add(lastName);

            // Update the shared lists in registeredForm with the values from the list boxes.
            // Convert the items in lbx_FirstName and lbx_LastName to lists and pass them to AddValues method.
            registeredForm.AddValues(lbx_FirstName.Items.Cast<string>().ToList(), lbx_LastName.Items.Cast<string>().ToList());

        }

        private void listbx_FirstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
