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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbx_FirstName = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.lbx_LastName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST ONLY (DELETE THIS IF U R STARTING)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 373);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(150, 55);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbx_FirstName
            // 
            this.lbx_FirstName.FormattingEnabled = true;
            this.lbx_FirstName.Location = new System.Drawing.Point(245, 224);
            this.lbx_FirstName.Name = "lbx_FirstName";
            this.lbx_FirstName.Size = new System.Drawing.Size(106, 147);
            this.lbx_FirstName.TabIndex = 2;
            this.lbx_FirstName.SelectedIndexChanged += new System.EventHandler(this.listbx_FirstName_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(245, 198);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(106, 20);
            this.tb_FirstName.TabIndex = 4;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(242, 173);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(103, 13);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Enter your first name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last name";
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(385, 198);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(106, 20);
            this.tb_LastName.TabIndex = 7;
            // 
            // lbx_LastName
            // 
            this.lbx_LastName.FormattingEnabled = true;
            this.lbx_LastName.Location = new System.Drawing.Point(385, 224);
            this.lbx_LastName.Name = "lbx_LastName";
            this.lbx_LastName.Size = new System.Drawing.Size(106, 147);
            this.lbx_LastName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "FORM NI NICKOS (DI PA TAPOS)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.lbx_LastName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbx_FirstName);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListBox lbx_FirstName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.ListBox lbx_LastName;
        private System.Windows.Forms.Label label2;
    }
}

