namespace MultimediaTracker
{
    partial class Edit_Info
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
            editTextBox = new TextBox();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // editTextBox
            // 
            editTextBox.Location = new Point(11, 13);
            editTextBox.Multiline = true;
            editTextBox.Name = "editTextBox";
            editTextBox.Size = new Size(777, 364);
            editTextBox.TabIndex = 0;
            editTextBox.Text = "Change Information Here";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(9, 392);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(778, 45);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm Button";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // Edit_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmButton);
            Controls.Add(editTextBox);
            Name = "Edit_Info";
            Text = "Edit Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox editTextBox;
        private Button confirmButton;
    }
}