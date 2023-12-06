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
    public partial class enrolledForm : Form
    {
        // Static lists to store enrolled data
        public static List<string> EnrolledFirstNameList { get; private set; } = new List<string>();
        public static List<string> EnrolledLastNameList { get; private set; } = new List<string>();
        public enrolledForm()
        {
            InitializeComponent();

            // Display the enrolled data in lbx_enrollFirstName and lbx_enrollLastName
            lbx_enrollFirstName.Items.AddRange(EnrollmentData.EnrolledFirstNameList.ToArray());
            lbx_enrollLastName.Items.AddRange(EnrollmentData.EnrolledLastNameList.ToArray());
        }

        // Add enrollment data to the static lists
        public static void AddEnrollment(string firstName, string lastName)
        {
            // Add the selected first name and last name to the static lists
            EnrolledFirstNameList.Add(firstName);
            EnrolledLastNameList.Add(lastName);
        }
        private void enrolledForm_Load(object sender, EventArgs e)
        {

        }

        private void lbx_enrollProgramApplied_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbx_enrollLastName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbx_enrollFirstName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
