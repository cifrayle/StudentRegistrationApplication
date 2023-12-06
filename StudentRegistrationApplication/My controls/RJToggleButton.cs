using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace StudentRegistrationApplication.CustomControls
{
    public class RJToggleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;
        private bool isAnimating = false;
        private Timer animationTimer;
        private const int AnimationSteps = 50;
        private int currentStep = 0;
        private int togglePositionX = 2;
        private bool isOnRight = false;  // Track if the circle is on the right side

        [Category("RJ Code Advance")]
        public Color OnBackColor
        {
            get { return onBackColor; }
            set { onBackColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color OnToggleColor
        {
            get { return onToggleColor; }
            set { onToggleColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color OffBackColor
        {
            get { return offBackColor; }
            set { offBackColor = value; this.Invalidate(); }
        }

        [Category("RJ Code Advance")]
        public Color OffToggleColor
        {
            get { return offToggleColor; }
            set { offToggleColor = value; this.Invalidate(); }
        }

        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { }
        }

        [Category("RJ Code Advance")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get { return solidStyle; }
            set { solidStyle = value; this.Invalidate(); }
        }

        public RJToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
            animationTimer = new Timer();
            animationTimer.Interval = 10;
            animationTimer.Tick += AnimationTimer_Tick;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (!isAnimating)
            {
                isAnimating = true;
                currentStep = 0;
                animationTimer.Start();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            currentStep++;

            if (currentStep > AnimationSteps)
            {
                isAnimating = false;
                animationTimer.Stop();
                isOnRight = !isOnRight;  // Toggle the position when animation completes
            }

            this.Invalidate();
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        private Color InterpolateColor(Color startColor, Color endColor, double percentage)
        {
            int red = (int)(startColor.R + (endColor.R - startColor.R) * percentage);
            int green = (int)(startColor.G + (endColor.G - startColor.G) * percentage);
            int blue = (int)(startColor.B + (endColor.B - startColor.B) * percentage);

            return Color.FromArgb(red, green, blue);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (isAnimating)
            {
                double progress = (double)currentStep / AnimationSteps;

                if (this.Checked) // ON
                {
                    Color currentBackColor = InterpolateColor(offBackColor, onBackColor, progress);
                    Color currentToggleColor = InterpolateColor(offToggleColor, onToggleColor, progress);

                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(currentBackColor), GetFigurePath());
                    else pevent.Graphics.DrawPath(new Pen(currentBackColor, 2), GetFigurePath());

                    if (isOnRight)
                        togglePositionX = (int)(this.Width - this.Height + 1 - toggleSize + (2 * toggleSize * progress));
                    else
                        togglePositionX = (int)(2 + (2 * toggleSize * (1 - progress)));

                    pevent.Graphics.FillEllipse(new SolidBrush(currentToggleColor),
                        new Rectangle(togglePositionX, 2, toggleSize, toggleSize));
                }
                else // OFF
                {
                    Color currentBackColor = InterpolateColor(onBackColor, offBackColor, progress);
                    Color currentToggleColor = InterpolateColor(onToggleColor, offToggleColor, progress);

                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(currentBackColor), GetFigurePath());
                    else pevent.Graphics.DrawPath(new Pen(currentBackColor, 2), GetFigurePath());

                    if (isOnRight)
                        togglePositionX = (int)(this.Width - this.Height + 1 - toggleSize + (2 * toggleSize * progress));
                    else
                        togglePositionX = (int)(2 + (2 * toggleSize * (1 - progress)));

                    pevent.Graphics.FillEllipse(new SolidBrush(currentToggleColor),
                        new Rectangle(togglePositionX, 2, toggleSize, toggleSize));
                }
            }
            else
            {
                if (this.Checked) // ON
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                    else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());

                    pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                        new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
                }
                else // OFF
                {
                    if (solidStyle)
                        pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                    else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());

                    pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                        new Rectangle(2, 2, toggleSize, toggleSize));
                }
            }
        }
    }
}
