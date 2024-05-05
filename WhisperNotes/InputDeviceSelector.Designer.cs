namespace WhisperNotes
{
    partial class InputDeviceSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMicrophones = new ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBoxMicrophones.FormattingEnabled = true;
            this.comboBoxMicrophones.Location = new Point(0, 0);
            this.comboBoxMicrophones.Margin = new Padding(4, 3, 4, 3);
            this.comboBoxMicrophones.Name = "comboBox1";
            this.comboBoxMicrophones.Size = new Size(174, 23);
            this.comboBoxMicrophones.TabIndex = 0;
            // 
            // InputDeviceSelector
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxMicrophones);
            this.Margin = new Padding(4, 3, 4, 3);
            this.Name = "InputDeviceSelector";
            this.Size = new Size(175, 25);
            this.Load += this.InputDeviceSelector_Load;
            this.ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMicrophones;
    }
}
