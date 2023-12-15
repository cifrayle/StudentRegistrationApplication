namespace StudentRegistrationApplication
{
    partial class adminlog
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_exitBack = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_admEXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.circularPicBox2 = new StudentRegistrationApplication.Forms.CircularPicBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(453, 257);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(275, 1);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(484, 236);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(244, 15);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(484, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(244, 15);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.flowLayoutPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(453, 317);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(275, 1);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(453, 342);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(275, 34);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_exitBack
            // 
            this.btn_exitBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.btn_exitBack.FlatAppearance.BorderSize = 0;
            this.btn_exitBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitBack.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.btn_exitBack.Location = new System.Drawing.Point(453, 382);
            this.btn_exitBack.Name = "btn_exitBack";
            this.btn_exitBack.Size = new System.Drawing.Size(275, 34);
            this.btn_exitBack.TabIndex = 9;
            this.btn_exitBack.Text = "Register as Student";
            this.btn_exitBack.UseVisualStyleBackColor = false;
            this.btn_exitBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(243)))));
            this.pnl_top.Controls.Add(this.btn_admEXIT);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(770, 24);
            this.pnl_top.TabIndex = 10;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            // 
            // btn_admEXIT
            // 
            this.btn_admEXIT.BackgroundImage = global::StudentRegistrationApplication.Properties.Resources.icons8_close_24;
            this.btn_admEXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_admEXIT.FlatAppearance.BorderSize = 0;
            this.btn_admEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admEXIT.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admEXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admEXIT.Location = new System.Drawing.Point(735, 0);
            this.btn_admEXIT.Name = "btn_admEXIT";
            this.btn_admEXIT.Size = new System.Drawing.Size(35, 24);
            this.btn_admEXIT.TabIndex = 30;
            this.btn_admEXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admEXIT.UseVisualStyleBackColor = true;
            this.btn_admEXIT.Click += new System.EventHandler(this.btn_admEXIT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::StudentRegistrationApplication.Properties.Resources.bg_wave1_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 446);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StudentRegistrationApplication.Properties.Resources.padlock;
            this.pictureBox3.Location = new System.Drawing.Point(453, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentRegistrationApplication.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(453, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // circularPicBox2
            // 
            this.circularPicBox2.BackgroundImage = global::StudentRegistrationApplication.Properties.Resources.profile;
            this.circularPicBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circularPicBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPicBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPicBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPicBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPicBox2.BorderSize = 0;
            this.circularPicBox2.GradientAngle = 50F;
            this.circularPicBox2.Location = new System.Drawing.Point(520, 43);
            this.circularPicBox2.Name = "circularPicBox2";
            this.circularPicBox2.Size = new System.Drawing.Size(156, 156);
            this.circularPicBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularPicBox2.TabIndex = 14;
            this.circularPicBox2.TabStop = false;
            // 
            // adminlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(770, 469);
            this.Controls.Add(this.circularPicBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_exitBack);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adminlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.adminlog_Load);
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_exitBack;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel panel1;
        private Forms.CircularPicBox circularPicBox1;
        private System.Windows.Forms.Button btn_admEXIT;
        private Forms.CircularPicBox circularPicBox2;
    }
}