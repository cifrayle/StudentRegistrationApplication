namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mName = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.program = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.roundedPictureBox1 = new StudentRegistrationApplication.CustomControls.RJCircularPictureBox();
            this.uploadIMG = new ePOSOne.btnProduct.Button_WOC();
            this.female = new StudentRegistrationApplication.CustomControls.RJRadioButton();
            this.male = new StudentRegistrationApplication.CustomControls.RJRadioButton();
            this.date = new StudentRegistrationApplication.CustomControls.Customdatepicker();
            this.registerBut = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mName);
            this.panel2.Controls.Add(this.fName);
            this.panel2.Controls.Add(this.lName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 421);
            this.panel2.TabIndex = 1;
            // 
            // mName
            // 
            this.mName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mName.Location = new System.Drawing.Point(84, 161);
            this.mName.Name = "mName";
            this.mName.Size = new System.Drawing.Size(268, 17);
            this.mName.TabIndex = 12;
            this.mName.TextChanged += new System.EventHandler(this.mName_TextChanged);
            // 
            // fName
            // 
            this.fName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(84, 96);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(268, 17);
            this.fName.TabIndex = 11;
            this.fName.TextChanged += new System.EventHandler(this.fName_TextChanged);
            // 
            // lName
            // 
            this.lName.BackColor = System.Drawing.SystemColors.Window;
            this.lName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(84, 33);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(268, 17);
            this.lName.TabIndex = 0;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Middle name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.female);
            this.panel3.Controls.Add(this.male);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 32);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.date);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 60);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date of birth:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.registerBut);
            this.panel6.Location = new System.Drawing.Point(3, 351);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 50);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.program);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(3, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 50);
            this.panel5.TabIndex = 3;
            // 
            // program
            // 
            this.program.FormattingEnabled = true;
            this.program.Items.AddRange(new object[] {
            " BIOC220 (Biochemistry for Biotechnology) ",
            "AC History(Bachelor of Arts in History)",
            "ARCH201 (Architectural Design Studio) ",
            "BIOL202 (Cell Biology) ART220 (Introduction to Art History)",
            "BSCS(Bachelor of Science in Computer Science)",
            "BUSMGT101 (Introduction to Business Management) ",
            "CHEM301 (Organic Chemistry) ",
            "CIVIL301 (Civil Engineering Materials)",
            "CS101 (Introduction to Computer Science) ",
            "CSCI401 (Advanced Data Structures and Algorithms)",
            "ECON101 (Principles of Microeconomics) ",
            "EE301 (Electrical Engineering Fundamentals) ",
            "ENG102 (English Composition II) ",
            "HIST202 (World History since 1500) ",
            "MATH201 (Calculus I) ",
            "MECH202 (Mechanical Engineering Thermodynamics) ",
            "NURSING401 (Advanced Nursing Practice)",
            "PHY202 (Physics for Engineers) ",
            "POLSCI202 (Comparative Politics) ",
            "PSYCH110 (Introduction to Psychology) ",
            "PSYCH301 (Abnormal Psychology) "});
            this.program.Location = new System.Drawing.Point(8, 21);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(299, 21);
            this.program.Sorted = true;
            this.program.TabIndex = 16;
            this.program.Tag = "";
            this.program.Text = "--------";
            this.program.SelectedIndexChanged += new System.EventHandler(this.program_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica Rounded", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Program to apply";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_WOC1);
            this.panel7.Controls.Add(this.roundedPictureBox1);
            this.panel7.Controls.Add(this.uploadIMG);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(397, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(271, 421);
            this.panel7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Form";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Location = new System.Drawing.Point(50, 351);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(160, 43);
            this.button_WOC1.TabIndex = 1;
            this.button_WOC1.Text = "Login as admin";
            this.button_WOC1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.roundedPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.roundedPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.roundedPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.roundedPictureBox1.BorderSize = 5;
            this.roundedPictureBox1.GradientAngle = 50F;
            this.roundedPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.Image")));
            this.roundedPictureBox1.InitialImage = null;
            this.roundedPictureBox1.Location = new System.Drawing.Point(13, 12);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(236, 236);
            this.roundedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundedPictureBox1.TabIndex = 2;
            this.roundedPictureBox1.TabStop = false;
            this.roundedPictureBox1.Click += new System.EventHandler(this.roundedPictureBox1_Click);
            // 
            // uploadIMG
            // 
            this.uploadIMG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.uploadIMG.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.uploadIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadIMG.Location = new System.Drawing.Point(50, 256);
            this.uploadIMG.Name = "uploadIMG";
            this.uploadIMG.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.uploadIMG.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.uploadIMG.OnHoverTextColor = System.Drawing.Color.Gray;
            this.uploadIMG.Size = new System.Drawing.Size(160, 43);
            this.uploadIMG.TabIndex = 1;
            this.uploadIMG.Text = "Upload an image";
            this.uploadIMG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.uploadIMG.UseVisualStyleBackColor = true;
            this.uploadIMG.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.CheckedColor = System.Drawing.Color.Plum;
            this.female.ForeColor = System.Drawing.Color.Black;
            this.female.Location = new System.Drawing.Point(147, 8);
            this.female.MinimumSize = new System.Drawing.Size(0, 21);
            this.female.Name = "female";
            this.female.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.female.Size = new System.Drawing.Size(69, 21);
            this.female.TabIndex = 13;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UnCheckedColor = System.Drawing.Color.Gray;
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.CheckedColor = System.Drawing.Color.CornflowerBlue;
            this.male.ForeColor = System.Drawing.Color.Black;
            this.male.Location = new System.Drawing.Point(83, 8);
            this.male.MinimumSize = new System.Drawing.Size(0, 21);
            this.male.Name = "male";
            this.male.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.male.Size = new System.Drawing.Size(58, 21);
            this.male.TabIndex = 12;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UnCheckedColor = System.Drawing.Color.Gray;
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // date
            // 
            this.date.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.date.BorderSize = 0;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.date.Location = new System.Drawing.Point(123, 11);
            this.date.MinimumSize = new System.Drawing.Size(4, 35);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(226, 35);
            this.date.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.date.TabIndex = 14;
            this.date.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // registerBut
            // 
            this.registerBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.registerBut.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.registerBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBut.Location = new System.Drawing.Point(3, 0);
            this.registerBut.Name = "registerBut";
            this.registerBut.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.registerBut.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.registerBut.OnHoverTextColor = System.Drawing.Color.Gray;
            this.registerBut.Size = new System.Drawing.Size(160, 43);
            this.registerBut.TabIndex = 0;
            this.registerBut.Text = "Register student";
            this.registerBut.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.registerBut.UseVisualStyleBackColor = true;
            this.registerBut.Click += new System.EventHandler(this.registerBut_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Location = new System.Drawing.Point(633, 0);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Red;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC2.Size = new System.Drawing.Size(35, 22);
            this.button_WOC2.TabIndex = 13;
            this.button_WOC2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(222)))), ((int)(((byte)(246)))));
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(668, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox mName;
        private System.Windows.Forms.TextBox fName;
        private CustomControls.Customdatepicker date;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJRadioButton female;
        private CustomControls.RJRadioButton male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox program;
        private ePOSOne.btnProduct.Button_WOC registerBut;
        private ePOSOne.btnProduct.Button_WOC uploadIMG;
        private CustomControls.RJCircularPictureBox roundedPictureBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}

