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
        public Form1()
        {
            InitializeComponent();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customdatepicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click_1(object sender, EventArgs e)
        {

        }
        private void roundedPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
                imageLocation = dialog.FileName;

                roundedPictureBox1.ImageLocation = imageLocation;
            }
            catch(Exception ex)
            {
                MessageBox.Show("please enter *jpg or *png files only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
