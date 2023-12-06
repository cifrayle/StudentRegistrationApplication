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
    public partial class mainForm : Form
    {
        public mainForm()
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

        private void lName_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mName_TextChanged(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void program_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void registerBut_Click(object sender, EventArgs e)
        {
            String name = "Student Name: ";
            String gen = "Gender: ";
            String dob = "Date of Birth: ";
            String prog = "Program: ";

            if (string.IsNullOrWhiteSpace(fName.Text) || string.IsNullOrWhiteSpace(lName.Text) || string.IsNullOrWhiteSpace(mName.Text))
            {
                MessageBox.Show("Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Please select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Please select a valid date of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(program.Text))
            {
                MessageBox.Show("Please select a program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                string fullName = $"{lName.Text} {fName.Text} {mName.Text}";
                string gender = male.Checked ? "Male" : "Female";
                string dateOfBirth = date.Value.ToShortDateString();
                string selectedProgram = program.Text;

                
                string resultMessage = $"{name}{fullName}\n{gen}{gender}\n{dob}{dateOfBirth}\n{prog}{selectedProgram}";
                MessageBox.Show(resultMessage, "Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }

        

        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}

/*ito yung mga name ng variable at mga objects:
 Variables:

imageLocation              (String): Stores the file location selected through the OpenFileDialog for an image.
name (String):                Represents the constant string "Student Name: ".
gen (String):                 Represents the constant string "Gender: ".
dob (String):                   Represents the constant string "Date of Birth: ".
prog (String):                       Represents the constant string "Program: ".
fullName (String):                   Concatenated full name of the student.
gender (String):                        Represents the gender of the student.
dateOfBirth (String):       Represents the date of birth of the student.
selectedProgram (String):            Represents the selected program for the student.
resultMessage (String):                         Concatenated message to be displayed in the MessageBox.

Objects:            

dialog (OpenFileDialog):        OpenFileDialog used to select an image file.
roundedPictureBox1 (PictureBox):         PictureBox control used to display the selected image.
fName (TextBox):                                 TextBox control for the first name.
lName (TextBox):                TextBox control for the last name.
mName (TextBox):                            TextBox control for the middle name.
male (RadioButton):                                 RadioButton for the male gender.
female (RadioButton):           RadioButton for the female gender.
date (DateTimePicker):                       DateTimePicker control for selecting the date of birth.
program (ComboBox):                                     ComboBox control for selecting the program.*/