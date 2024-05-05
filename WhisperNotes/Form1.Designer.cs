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
            this.button1 = new Button();
            this.recordButton = new Button();
            this.stopButton = new Button();
            this.outputTextBox = new RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new Size(275, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "www";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_Click;
            // 
            // recordButton
            // 
            this.recordButton.Location = new Point(352, 113);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new Size(75, 23);
            this.recordButton.TabIndex = 1;
            this.recordButton.Text = "button2";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += this.recordButton_Click;
            // 
            // stopButton
            // 
            this.stopButton.Location = new Point(450, 113);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "button3";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += this.stopButton_Click;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new Point(326, 228);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new Size(374, 156);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button recordButton;
        private Button stopButton;
        private RichTextBox outputTextBox;
    }
}
