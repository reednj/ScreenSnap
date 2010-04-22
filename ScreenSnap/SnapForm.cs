using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using System.Drawing.Imaging;
using System.IO;

namespace ScreenSnap
{
    public partial class SnapForm : Form
    {

        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        Point mousePoint = Point.Empty;
        Rectangle prevRect = new Rectangle();

        public SnapForm()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;
            
            this.Cursor = Cursors.Cross;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
        }

        private void CaptureScreen(Rectangle r)
        {
            string DesktopDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            Bitmap bitmap = new Bitmap(Math.Abs(r.Width), Math.Abs(r.Height)); 
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(r.Left, r.Top, 0, 0, bitmap.Size);
            
            TimeSpan FileNumber = (DateTime.Now - DateTime.Today);
            bitmap.Save(Path.Combine(DesktopDir, String.Format("snap-{0}.png", Math.Round(FileNumber.TotalSeconds))), ImageFormat.Png);
        }

        private void SnapForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == false) {
                return;
            }

            mousePoint = e.Location;
            
            Point startPoint = this.PointToScreen(mouseDownPoint);
            Point endPoint = this.PointToScreen(mousePoint);

            int Top = Math.Min(startPoint.Y, endPoint.Y);
            int Left = Math.Min(startPoint.X, endPoint.X);
            int Bottom = Math.Max(startPoint.Y, endPoint.Y);
            int Right = Math.Max(startPoint.X, endPoint.X);

            Rectangle rect = new Rectangle(Left, Top, Right - Left, Bottom - Top);

            ControlPaint.DrawReversibleFrame(prevRect, Color.Black, FrameStyle.Dashed);
            ControlPaint.DrawReversibleFrame(rect, Color.Black, FrameStyle.Dashed);

            prevRect = rect;
        }

        private void SnapForm_MouseUp(object sender, MouseEventArgs e)
        {
            if(mouseDown == true) {
                mouseDown = false;
                this.CaptureScreen(prevRect);
                
                ControlPaint.DrawReversibleFrame(prevRect, Color.Black, FrameStyle.Dashed);
            }

            this.Close();
        }

        private void SnapForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(mouseDown == false) {
                prevRect = new Rectangle();

                mouseDown = true;
                mousePoint = mouseDownPoint = e.Location;
            }
        }

        private void SnapForm_Load(object sender, EventArgs e)
        {
            

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SnapForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }



    }
}