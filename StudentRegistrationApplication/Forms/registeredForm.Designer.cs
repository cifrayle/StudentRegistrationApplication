﻿namespace StudentRegistrationApplication
{
    partial class registeredForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_regProgramApplied = new System.Windows.Forms.ListBox();
            this.lbx_regLastName = new System.Windows.Forms.ListBox();
            this.lbx_regFirstName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registered students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbx_regProgramApplied
            // 
            this.lbx_regProgramApplied.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_regProgramApplied.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbx_regProgramApplied.FormattingEnabled = true;
            this.lbx_regProgramApplied.ItemHeight = 16;
            this.lbx_regProgramApplied.Location = new System.Drawing.Point(63, 156);
            this.lbx_regProgramApplied.Name = "lbx_regProgramApplied";
            this.lbx_regProgramApplied.Size = new System.Drawing.Size(198, 276);
            this.lbx_regProgramApplied.TabIndex = 1;
            this.lbx_regProgramApplied.SelectedIndexChanged += new System.EventHandler(this.lb_Registered_SelectedIndexChanged);
            // 
            // lbx_regLastName
            // 
            this.lbx_regLastName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_regLastName.FormattingEnabled = true;
            this.lbx_regLastName.ItemHeight = 16;
            this.lbx_regLastName.Location = new System.Drawing.Point(267, 156);
            this.lbx_regLastName.Name = "lbx_regLastName";
            this.lbx_regLastName.Size = new System.Drawing.Size(198, 276);
            this.lbx_regLastName.TabIndex = 2;
            this.lbx_regLastName.SelectedIndexChanged += new System.EventHandler(this.lbx_regLastName_SelectedIndexChanged);
            // 
            // lbx_regFirstName
            // 
            this.lbx_regFirstName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_regFirstName.FormattingEnabled = true;
            this.lbx_regFirstName.ItemHeight = 16;
            this.lbx_regFirstName.Location = new System.Drawing.Point(471, 156);
            this.lbx_regFirstName.Name = "lbx_regFirstName";
            this.lbx_regFirstName.Size = new System.Drawing.Size(198, 276);
            this.lbx_regFirstName.TabIndex = 3;
            this.lbx_regFirstName.SelectedIndexChanged += new System.EventHandler(this.lbx_regFirstName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Program applied";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "First name";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(198, 454);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(133, 34);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Remove";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Enroll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registeredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(724, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbx_regFirstName);
            this.Controls.Add(this.lbx_regLastName);
            this.Controls.Add(this.lbx_regProgramApplied);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registeredForm";
            this.Text = "registeredForm";
            this.Load += new System.EventHandler(this.registeredForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_regProgramApplied;
        private System.Windows.Forms.ListBox lbx_regLastName;
        private System.Windows.Forms.ListBox lbx_regFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button button1;
    }
}