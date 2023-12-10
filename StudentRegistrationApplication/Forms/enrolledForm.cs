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
        private registeredForm registeredForm;

        private List<string> enrlastNames = new List<string>();
        private List<string> enrfirstNames = new List<string>();
        private List<string> enrprogramsApplied = new List<string>();
        private List<string> enrmiddleNames = new List<string>();

        public enrolledForm()
        {
            InitializeComponent();
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
