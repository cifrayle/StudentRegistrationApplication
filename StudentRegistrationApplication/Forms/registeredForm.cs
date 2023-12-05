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
        public registeredForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Registered_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Registered.Text = Form1.name;
        }
    }
}
