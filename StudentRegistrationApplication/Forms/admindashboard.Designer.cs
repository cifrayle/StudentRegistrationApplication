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
            this.panel_Side = new System.Windows.Forms.Panel();
            this.admin = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_homePage = new System.Windows.Forms.Button();
            this.btn_Enrolled = new System.Windows.Forms.Button();
            this.btn_Registered = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(105)))), ((int)(((byte)(209)))));
            this.sidePanel.Controls.Add(this.panel_Side);
            this.sidePanel.Controls.Add(this.admin);
            this.sidePanel.Controls.Add(this.btn_Logout);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.btn_homePage);
            this.sidePanel.Controls.Add(this.btn_Enrolled);
            this.sidePanel.Controls.Add(this.btn_Registered);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 30);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(244, 562);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_Side
            // 
            this.panel_Side.BackColor = System.Drawing.Color.White;
            this.panel_Side.ForeColor = System.Drawing.Color.FloralWhite;
            this.panel_Side.Location = new System.Drawing.Point(3, 225);
            this.panel_Side.Name = "panel_Side";
            this.panel_Side.Size = new System.Drawing.Size(10, 38);
            this.panel_Side.TabIndex = 8;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Bauhaus 93", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(62, 138);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(123, 38);
            this.admin.TabIndex = 3;
            this.admin.Text = "ADMIN";
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
            this.btn_Logout.Location = new System.Drawing.Point(15, 371);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(210, 39);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.Text = "   Log out";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.button3_Click);
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
            this.btn_homePage.Location = new System.Drawing.Point(15, 224);
            this.btn_homePage.Name = "btn_homePage";
            this.btn_homePage.Size = new System.Drawing.Size(210, 39);
            this.btn_homePage.TabIndex = 9;
            this.btn_homePage.Text = "  Home";
            this.btn_homePage.UseVisualStyleBackColor = false;
            this.btn_homePage.Click += new System.EventHandler(this.btn_homePage_Click);
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
            this.btn_Enrolled.Location = new System.Drawing.Point(15, 322);
            this.btn_Enrolled.Name = "btn_Enrolled";
            this.btn_Enrolled.Size = new System.Drawing.Size(210, 39);
            this.btn_Enrolled.TabIndex = 11;
            this.btn_Enrolled.Text = "   Enrolled";
            this.btn_Enrolled.UseVisualStyleBackColor = false;
            this.btn_Enrolled.Click += new System.EventHandler(this.btn_Enrolled_Click);
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
            this.btn_Registered.Location = new System.Drawing.Point(15, 273);
            this.btn_Registered.Name = "btn_Registered";
            this.btn_Registered.Size = new System.Drawing.Size(210, 39);
            this.btn_Registered.TabIndex = 10;
            this.btn_Registered.Text = "   Registered";
            this.btn_Registered.UseVisualStyleBackColor = false;
            this.btn_Registered.Click += new System.EventHandler(this.btn_Registered_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.topPanel.Controls.Add(this.button2);
            this.topPanel.Controls.Add(this.btn_Exit);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1162, 30);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_maximize_28;
            this.button2.Location = new System.Drawing.Point(1076, -3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 33);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_close_24;
            this.btn_Exit.Location = new System.Drawing.Point(1122, -3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(40, 33);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StudentRegistrationApplication.Properties.Resources.icons8_minimize_24;
            this.button1.Location = new System.Drawing.Point(1030, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 33);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(244, 30);
            this.mainPanel.MinimumSize = new System.Drawing.Size(524, 318);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(918, 562);
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "By: Cian and Nickos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentRegistrationApplication.Properties.Resources.sti_logo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(237, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(431, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Student Registration Application";
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1162, 592);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "adminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admindashboard";
            this.Load += new System.EventHandler(this.admindashboard_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Side;
    }
}