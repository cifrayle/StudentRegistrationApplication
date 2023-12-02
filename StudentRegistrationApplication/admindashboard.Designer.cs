namespace StudentRegistrationApplication
{
    partial class adminDashboard
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_homePage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Registered = new System.Windows.Forms.Button();
            this.btn_Enrolled = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.sidePanel.Controls.Add(this.btn_Logout);
            this.sidePanel.Controls.Add(this.btn_homePage);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.btn_Registered);
            this.sidePanel.Controls.Add(this.btn_Enrolled);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 30);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 524);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.topPanel.Controls.Add(this.btn_Exit);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(973, 30);
            this.topPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(723, 524);
            this.mainPanel.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_close_24;
            this.btn_Exit.Location = new System.Drawing.Point(939, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(34, 30);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_log_out_32;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(1, 348);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(246, 39);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = " Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_homePage
            // 
            this.btn_homePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_homePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_homePage.FlatAppearance.BorderSize = 0;
            this.btn_homePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_homePage.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homePage.ForeColor = System.Drawing.Color.White;
            this.btn_homePage.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_home_32;
            this.btn_homePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_homePage.Location = new System.Drawing.Point(1, 201);
            this.btn_homePage.Name = "btn_homePage";
            this.btn_homePage.Size = new System.Drawing.Size(246, 39);
            this.btn_homePage.TabIndex = 9;
            this.btn_homePage.Text = "Home";
            this.btn_homePage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentRegistrationApplication.Properties.Resources.profile1;
            this.pictureBox1.Location = new System.Drawing.Point(61, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Registered
            // 
            this.btn_Registered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Registered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Registered.FlatAppearance.BorderSize = 0;
            this.btn_Registered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registered.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registered.ForeColor = System.Drawing.Color.White;
            this.btn_Registered.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_student_32;
            this.btn_Registered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registered.Location = new System.Drawing.Point(1, 250);
            this.btn_Registered.Name = "btn_Registered";
            this.btn_Registered.Size = new System.Drawing.Size(246, 39);
            this.btn_Registered.TabIndex = 10;
            this.btn_Registered.Text = "  Registered";
            this.btn_Registered.UseVisualStyleBackColor = false;
            // 
            // btn_Enrolled
            // 
            this.btn_Enrolled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.btn_Enrolled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Enrolled.FlatAppearance.BorderSize = 0;
            this.btn_Enrolled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enrolled.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enrolled.ForeColor = System.Drawing.Color.White;
            this.btn_Enrolled.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_contract_32;
            this.btn_Enrolled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Enrolled.Location = new System.Drawing.Point(1, 299);
            this.btn_Enrolled.Name = "btn_Enrolled";
            this.btn_Enrolled.Size = new System.Drawing.Size(246, 39);
            this.btn_Enrolled.TabIndex = 11;
            this.btn_Enrolled.Text = " Enrolled";
            this.btn_Enrolled.UseVisualStyleBackColor = false;
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(973, 554);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminDashboard";
            this.Text = "admindashboard";
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_homePage;
        private System.Windows.Forms.Button btn_Enrolled;
        private System.Windows.Forms.Button btn_Registered;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Exit;
    }
}