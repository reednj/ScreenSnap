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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnapForm));
            this.SuspendLayout();
            // 
            // SnapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(572, 327);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnapForm";
            this.Opacity = 0.5;
            this.Text = "ScreenSnap";
            this.Load += new System.EventHandler(this.SnapForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SnapForm_MouseMove);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnapForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion



    }
}

