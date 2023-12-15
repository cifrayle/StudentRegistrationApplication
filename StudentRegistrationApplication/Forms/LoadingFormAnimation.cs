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
    public partial class LoadingFormAnimation : Form
    {
        private registeredForm regForm;
        public LoadingFormAnimation(registeredForm regForm)
        {
            InitializeComponent();
            this.regForm = regForm;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 656) 
            { 
                timer1.Stop();
                adminDashboard admindash = new adminDashboard(regForm);
                admindash.Show();
                this.Hide();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadingFormAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
