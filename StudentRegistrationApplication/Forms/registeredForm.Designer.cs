namespace StudentRegistrationApplication
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
            this.lb_Registered = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTERED PAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_Registered
            // 
            this.lb_Registered.FormattingEnabled = true;
            this.lb_Registered.Location = new System.Drawing.Point(95, 249);
            this.lb_Registered.Name = "lb_Registered";
            this.lb_Registered.Size = new System.Drawing.Size(366, 173);
            this.lb_Registered.TabIndex = 1;
            this.lb_Registered.SelectedIndexChanged += new System.EventHandler(this.lb_Registered_SelectedIndexChanged);
            // 
            // registeredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(230)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(724, 512);
            this.Controls.Add(this.lb_Registered);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registeredForm";
            this.Text = "registeredForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_Registered;
    }
}