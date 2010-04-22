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
        public SnapForm()
        {
            InitializeComponent();
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            this.CaptureScreen();
        }

        private void CaptureScreen()
        {
            string DesktopDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            
            
            bitmap.Save(Path.Combine(DesktopDir, "test.png"), ImageFormat.Png);
        }
    }
}