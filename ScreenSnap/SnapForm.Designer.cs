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
            this.CaptureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaptureButton
            // 
            this.CaptureButton.Location = new System.Drawing.Point(12, 12);
            this.CaptureButton.Name = "CaptureButton";
            this.CaptureButton.Size = new System.Drawing.Size(207, 41);
            this.CaptureButton.TabIndex = 0;
            this.CaptureButton.Text = "Capture Screen";
            this.CaptureButton.UseVisualStyleBackColor = true;
            this.CaptureButton.Click += new System.EventHandler(this.CaptureButton_Click);
            // 
            // SnapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 66);
            this.Controls.Add(this.CaptureButton);
            this.Name = "SnapForm";
            this.Text = "ScreenSnap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CaptureButton;
    }
}

