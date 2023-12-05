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
    
    public partial class registeredForm : Form
    {
        // Static lists to store values
        public static List<string> FirstNameList { get; private set; } = new List<string>();
        public static List<string> LastNameList { get; private set; } = new List<string>();
        public registeredForm()
        {
            InitializeComponent();
            //adding the values to the listboxes in this form
            lbx_regFirstName.Items.AddRange(FirstNameList.ToArray());
            lbx_regLastName.Items.AddRange(LastNameList.ToArray());

        }
        // This method adds new first names and last names to the shared lists in registeredForm.
        public static void AddValues(List<string> firstNames, List<string> lastNames)
        {
            // Clear existing values before adding new ones
            FirstNameList.Clear();
            LastNameList.Clear();

            // Add new values
            FirstNameList.AddRange(firstNames);
            LastNameList.AddRange(lastNames);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Registered_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbx_regLastName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbx_regFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //this button will remove any selected items in the list
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in either lbx_regFirstName or lbx_regLastName
            if (lbx_regFirstName.SelectedItem != null || lbx_regLastName.SelectedItem != null)
            {
                // Get the selected index from either lbx_regFirstName or lbx_regLastName
                int selectedIndex = (lbx_regFirstName.SelectedItem != null)
                    ? lbx_regFirstName.SelectedIndex
                    : lbx_regLastName.SelectedIndex;

                // Remove the items at the selected index from both lbx_regFirstName and lbx_regLastName
                lbx_regFirstName.Items.RemoveAt(selectedIndex);
                lbx_regLastName.Items.RemoveAt(selectedIndex);
            }

        }
    }
}
