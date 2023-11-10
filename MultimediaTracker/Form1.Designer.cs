namespace MultimediaTracker
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
            movieButton = new Button();
            comicButton = new Button();
            tvButton = new Button();
            novelButton = new Button();
            SuspendLayout();
            // 
            // movieButton
            // 
            movieButton.Location = new Point(16, 18);
            movieButton.Name = "movieButton";
            movieButton.Size = new Size(216, 197);
            movieButton.TabIndex = 1;
            movieButton.Text = "Movies";
            movieButton.UseVisualStyleBackColor = true;
            movieButton.Click += movieButton_Click;
            // 
            // comicButton
            // 
            comicButton.Location = new Point(259, 243);
            comicButton.Name = "comicButton";
            comicButton.Size = new Size(216, 197);
            comicButton.TabIndex = 2;
            comicButton.Text = "Comics";
            comicButton.UseVisualStyleBackColor = true;
            comicButton.Click += comicButton_Click;
            // 
            // tvButton
            // 
            tvButton.Location = new Point(259, 18);
            tvButton.Name = "tvButton";
            tvButton.Size = new Size(216, 197);
            tvButton.TabIndex = 3;
            tvButton.Text = "TV Shows";
            tvButton.UseVisualStyleBackColor = true;
            tvButton.Click += tvButton_Click;
            // 
            // novelButton
            // 
            novelButton.Location = new Point(16, 243);
            novelButton.Name = "novelButton";
            novelButton.Size = new Size(216, 197);
            novelButton.TabIndex = 4;
            novelButton.Text = "Novels";
            novelButton.UseVisualStyleBackColor = true;
            novelButton.Click += novelButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 460);
            Controls.Add(novelButton);
            Controls.Add(tvButton);
            Controls.Add(comicButton);
            Controls.Add(movieButton);
            Name = "Form1";
            Text = "Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button movieButton;
        private Button comicButton;
        private Button tvButton;
        private Button novelButton;
    }
}