namespace WhisperNotes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputDeviceSelector1 = new InputDeviceSelector();
            this.SuspendLayout();
            // 
            // inputDeviceSelector1
            // 
            this.inputDeviceSelector1.Location = new Point(36, 39);
            this.inputDeviceSelector1.Margin = new Padding(6, 5, 6, 5);
            this.inputDeviceSelector1.Name = "inputDeviceSelector1";
            this.inputDeviceSelector1.Size = new Size(250, 38);
            this.inputDeviceSelector1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1143, 750);
            this.Controls.Add(this.inputDeviceSelector1);
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private InputDeviceSelector inputDeviceSelector1;
    }
}
