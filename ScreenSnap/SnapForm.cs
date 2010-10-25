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
        //Point pl = new Point();

        public SnapForm()
        {
            InitializeComponent();
            
            this.Cursor = Cursors.Cross;

            this.WindowState = FormWindowState.Maximized;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.ShowInTaskbar = false;
        }

        private void CaptureScreen(Rectangle r)
        {
            if(r.Width == 0 || r.Height == 0) {
                return;
            }

            string DesktopDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Bitmap bitmap = new Bitmap(Math.Abs(r.Width-2), Math.Abs(r.Height-2)); 
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(r.Left + 1, r.Top + 1, 0, 0, bitmap.Size);
            string filePath = Path.Combine(DesktopDir, String.Format("Screenshot {0}.png", DateTime.Now.ToString("yyyy-mm-dd hhmmss")));
            bitmap.Save(filePath, ImageFormat.Png);
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
                if(prevRect.Height != 0 && prevRect.Width != 0) {
                    ControlPaint.DrawReversibleFrame(prevRect, Color.Black, FrameStyle.Dashed);
                }

                this.Close();
            }
        }



    }
}