using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StudentRegistrationApplication
{
    
    public partial class registeredForm : Form
    {
        // lists to store personal information
        private List<string> lastNames = new List<string>();
        private List<string> firstNames = new List<string>();
        private List<string> programsApplied = new List<string>();
        private List<string> middleNames = new List<string>();

        public registeredForm()
        {
            InitializeComponent();
        }
        // Method to add personal information to the lists and update ListBoxes
        public void AddPersonalInformation(string lastName, string firstName, string programApplied, string middleName)
        {
            // add the received personal information to the lists
            lastNames.Add(lastName);
            firstNames.Add(firstName);
            programsApplied.Add(programApplied);
            middleNames.Add(middleName);

            // update ListBoxes
            UpdateListBoxes();
        }

        // method to update ListBoxes with the current contents of the lists
        private void UpdateListBoxes()
        {
            // Clear existing items
            lbx_regLastName.Items.Clear();
            lbx_regFirstName.Items.Clear();
            lbx_regProgramApplied.Items.Clear();
            lbx_regMiddleName.Items.Clear();

            // Add the updated items to ListBoxes
            lbx_regLastName.Items.AddRange(lastNames.ToArray());
            lbx_regFirstName.Items.AddRange(firstNames.ToArray());
            lbx_regProgramApplied.Items.AddRange(programsApplied.ToArray());
            lbx_regMiddleName.Items.AddRange(middleNames.ToArray());
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


        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in lbx_ProgramApplied
            if (lbx_regProgramApplied.SelectedItem != null)
            {
                // Get the selected index
                int selectedIndex = lbx_regProgramApplied.SelectedIndex;

                // Remove the selected item from lbx_ProgramApplied
                lbx_regProgramApplied.Items.RemoveAt(selectedIndex);

                // Remove the corresponding items from lbx_regFirstName and lbx_regLastName
                lbx_regFirstName.Items.RemoveAt(selectedIndex);
                lbx_regLastName.Items.RemoveAt(selectedIndex);
                lbx_regMiddleName.Items.RemoveAt(selectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            //enroll button
        }

        private void registeredForm_Load(object sender, EventArgs e)
        {

        }
    }
}
