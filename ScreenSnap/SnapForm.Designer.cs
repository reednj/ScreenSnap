namespace ScreenSnap
{
    partial class SnapForm
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
            this.SuspendLayout();
            // 
            // SnapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 624);
            this.Name = "SnapForm";
            this.Opacity = 0.3;
            this.Text = "ScreenSnap";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnapForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseDown);
            this.Load += new System.EventHandler(this.SnapForm_Load);
            this.ResumeLayout(false);

        }

        #endregion


    }
}

