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

        // this is remove button
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in lbx_regProgramApplied
            if (lbx_regProgramApplied.SelectedItem != null)
            {
                // Get the selected index
                int selectedIndex = lbx_regProgramApplied.SelectedIndex;

                // Capture the information of the removed student
                string removedLastName = lastNames[selectedIndex];
                string removedFirstName = firstNames[selectedIndex];
                string removedProgramApplied = programsApplied[selectedIndex];
                string removedMiddleName = middleNames[selectedIndex];

                // Ask for confirmation
                DialogResult result = MessageBox.Show($"Are you sure you want to remove the student?\n\n" +
                                                      $"Last Name: {removedLastName}\n" +
                                                      $"First Name: {removedFirstName}\n" +
                                                      $"Middle Name: {removedMiddleName}\n" +
                                                      $"Program Applied: {removedProgramApplied}", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove the selected item from lists
                    lastNames.RemoveAt(selectedIndex);
                    firstNames.RemoveAt(selectedIndex);
                    programsApplied.RemoveAt(selectedIndex);
                    middleNames.RemoveAt(selectedIndex);

                    // Remove the corresponding items from ListBox
                    lbx_regLastName.Items.RemoveAt(selectedIndex);
                    lbx_regFirstName.Items.RemoveAt(selectedIndex);
                    lbx_regProgramApplied.Items.RemoveAt(selectedIndex);
                    lbx_regMiddleName.Items.RemoveAt(selectedIndex);

                    // Show a message box indicating the student has been removed
                    MessageBox.Show($"Student Removed:\n\n" +
                                    $"Last Name: {removedLastName}\n" +
                                    $"First Name: {removedFirstName}\n" +
                                    $"Middle Name: {removedMiddleName}\n" +
                                    $"Program Applied: {removedProgramApplied}", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // If the admin clicks 'No' in the confirmation dialog, do nothing
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void registeredForm_Load(object sender, EventArgs e)
        {

        }
    }
}
