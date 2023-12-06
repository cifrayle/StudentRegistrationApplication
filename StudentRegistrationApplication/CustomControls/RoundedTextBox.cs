using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    private int cornerRadius = 10;
    private Color borderColor = SystemColors.ControlDark;
    private int borderSize = 1;
    private Color backgroundColor = SystemColors.Window;

    public RoundedTextBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        UpdateStyles();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (var path = new GraphicsPath())
        {
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillPath(new SolidBrush(backgroundColor), path);
            e.Graphics.DrawPath(new Pen(borderColor, borderSize), path);
        }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set
        {
            borderColor = value;
            Invalidate();
        }
    }

    public int BorderSize
    {
        get { return borderSize; }
        set
        {
            borderSize = value;
            Invalidate();
        }
    }

    public Color BackgroundColor
    {
        get { return backgroundColor; }
        set
        {
            backgroundColor = value;
            Invalidate();
        }
    }

    public int CornerRadius
    {
        get { return cornerRadius; }
        set
        {
            cornerRadius = value;
            Invalidate();
        }
    }
}
