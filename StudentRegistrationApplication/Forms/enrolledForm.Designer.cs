namespace StudentRegistrationApplication
{
    partial class enrolledForm
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbx_enrollFirstName = new System.Windows.Forms.ListBox();
            this.lbx_enrollLastName = new System.Windows.Forms.ListBox();
            this.lbx_enrollProgramApplied = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbx_enrollMiddleName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enrolled students";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(256, 483);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(402, 34);
            this.btn_Login.TabIndex = 17;
            this.btn_Login.Text = "Remove student";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(461, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Program applied";
            // 
            // lbx_enrollFirstName
            // 
            this.lbx_enrollFirstName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_enrollFirstName.FormattingEnabled = true;
            this.lbx_enrollFirstName.ItemHeight = 16;
            this.lbx_enrollFirstName.Location = new System.Drawing.Point(460, 186);
            this.lbx_enrollFirstName.Name = "lbx_enrollFirstName";
            this.lbx_enrollFirstName.Size = new System.Drawing.Size(198, 276);
            this.lbx_enrollFirstName.TabIndex = 13;
            this.lbx_enrollFirstName.SelectedIndexChanged += new System.EventHandler(this.lbx_enrollFirstName_SelectedIndexChanged);
            // 
            // lbx_enrollLastName
            // 
            this.lbx_enrollLastName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_enrollLastName.FormattingEnabled = true;
            this.lbx_enrollLastName.ItemHeight = 16;
            this.lbx_enrollLastName.Location = new System.Drawing.Point(256, 186);
            this.lbx_enrollLastName.Name = "lbx_enrollLastName";
            this.lbx_enrollLastName.Size = new System.Drawing.Size(198, 276);
            this.lbx_enrollLastName.TabIndex = 12;
            this.lbx_enrollLastName.SelectedIndexChanged += new System.EventHandler(this.lbx_enrollLastName_SelectedIndexChanged);
            // 
            // lbx_enrollProgramApplied
            // 
            this.lbx_enrollProgramApplied.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_enrollProgramApplied.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbx_enrollProgramApplied.FormattingEnabled = true;
            this.lbx_enrollProgramApplied.ItemHeight = 16;
            this.lbx_enrollProgramApplied.Location = new System.Drawing.Point(52, 186);
            this.lbx_enrollProgramApplied.Name = "lbx_enrollProgramApplied";
            this.lbx_enrollProgramApplied.Size = new System.Drawing.Size(198, 276);
            this.lbx_enrollProgramApplied.TabIndex = 11;
            this.lbx_enrollProgramApplied.SelectedIndexChanged += new System.EventHandler(this.lbx_enrollProgramApplied_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(665, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Middle name";
            // 
            // lbx_enrollMiddleName
            // 
            this.lbx_enrollMiddleName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_enrollMiddleName.FormattingEnabled = true;
            this.lbx_enrollMiddleName.ItemHeight = 16;
            this.lbx_enrollMiddleName.Location = new System.Drawing.Point(664, 186);
            this.lbx_enrollMiddleName.Name = "lbx_enrollMiddleName";
            this.lbx_enrollMiddleName.Size = new System.Drawing.Size(198, 276);
            this.lbx_enrollMiddleName.TabIndex = 18;
            // 
            // enrolledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(918, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbx_enrollMiddleName);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbx_enrollFirstName);
            this.Controls.Add(this.lbx_enrollLastName);
            this.Controls.Add(this.lbx_enrollProgramApplied);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "enrolledForm";
            this.Text = "enrolledForm";
            this.Load += new System.EventHandler(this.enrolledForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbx_enrollFirstName;
        private System.Windows.Forms.ListBox lbx_enrollLastName;
        private System.Windows.Forms.ListBox lbx_enrollProgramApplied;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbx_enrollMiddleName;
    }
}