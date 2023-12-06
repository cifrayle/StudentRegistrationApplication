using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StudentRegistrationApplication.CustomControls
{
    public class RoundedPictureBox : PictureBox
    {
        public RoundedPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (GraphicsPath path = CreateRoundedRectPath(ClientRectangle, 10))
            {
                this.Region = new Region(path);

                using (Pen pen = new Pen(Color.Black, 1.0f))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    pe.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath CreateRoundedRectPath(Rectangle rectangle, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddArc(rectangle.Right - cornerRadius * 2, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddArc(rectangle.X, rectangle.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.CloseFigure();
            return roundedRect;
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            // Create a rounded picture box
            RoundedPictureBox roundedPictureBox = new RoundedPictureBox();
            roundedPictureBox.Image = Image.FromFile("path_to_your_image.jpg");
            roundedPictureBox.Size = new Size(200, 200);
            roundedPictureBox.Location = new Point(50, 50);

            // Add the picture box to the form
            this.Controls.Add(roundedPictureBox);
        }
    }

    public class Program
    {
       
    }
}
