namespace MultimediaTracker
{
    partial class Movies
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
            TabPage Description;
            posterImageBox = new PictureBox();
            saveButton = new Button();
            movieNameLabel = new Label();
            statusLabel = new Label();
            statusChangeLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            Review = new TabPage();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            yearLabel = new Label();
            releaseYearLabel = new Label();
            panel5 = new Panel();
            countryLabel = new Label();
            countryOriginLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Description = new TabPage();
            Description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)posterImageBox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            Review.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // Description
            // 
            Description.Controls.Add(textBox1);
            Description.Location = new Point(4, 29);
            Description.Name = "Description";
            Description.Size = new Size(1043, 269);
            Description.TabIndex = 2;
            Description.Text = "Description";
            Description.UseVisualStyleBackColor = true;
            // 
            // posterImageBox
            // 
            posterImageBox.BackColor = SystemColors.ActiveCaption;
            posterImageBox.BorderStyle = BorderStyle.FixedSingle;
            posterImageBox.Location = new Point(16, 19);
            posterImageBox.Name = "posterImageBox";
            posterImageBox.Size = new Size(481, 697);
            posterImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            posterImageBox.TabIndex = 0;
            posterImageBox.TabStop = false;
            posterImageBox.Click += pictureBox1_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(515, 661);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(172, 55);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // movieNameLabel
            // 
            movieNameLabel.AutoSize = true;
            movieNameLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            movieNameLabel.Location = new Point(11, 9);
            movieNameLabel.Name = "movieNameLabel";
            movieNameLabel.Size = new Size(206, 41);
            movieNameLabel.TabIndex = 2;
            movieNameLabel.Text = "Movie Name";
            movieNameLabel.Click += movieNameLabel_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(11, 9);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(110, 20);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Watch Status   |";
            // 
            // statusChangeLabel
            // 
            statusChangeLabel.AutoSize = true;
            statusChangeLabel.Location = new Point(127, 9);
            statusChangeLabel.Name = "statusChangeLabel";
            statusChangeLabel.Size = new Size(49, 20);
            statusChangeLabel.TabIndex = 4;
            statusChangeLabel.Text = "Status";
            statusChangeLabel.Click += statusChangeLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(movieNameLabel);
            panel1.Location = new Point(515, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 102);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(statusChangeLabel);
            panel2.Controls.Add(statusLabel);
            panel2.Location = new Point(515, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 43);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Location = new Point(515, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(1057, 361);
            panel3.TabIndex = 7;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Description);
            tabControl1.Controls.Add(Review);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1051, 302);
            tabControl1.TabIndex = 0;
            // 
            // Review
            // 
            Review.Controls.Add(textBox2);
            Review.Location = new Point(4, 29);
            Review.Name = "Review";
            Review.Padding = new Padding(3);
            Review.Size = new Size(1043, 269);
            Review.TabIndex = 0;
            Review.Text = "Review";
            Review.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1043, 269);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Other Information";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(yearLabel);
            panel4.Controls.Add(releaseYearLabel);
            panel4.Location = new Point(805, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 43);
            panel4.TabIndex = 7;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new Point(127, 9);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(37, 20);
            yearLabel.TabIndex = 4;
            yearLabel.Text = "Year";
            // 
            // releaseYearLabel
            // 
            releaseYearLabel.AutoSize = true;
            releaseYearLabel.Location = new Point(11, 9);
            releaseYearLabel.Name = "releaseYearLabel";
            releaseYearLabel.Size = new Size(108, 20);
            releaseYearLabel.TabIndex = 3;
            releaseYearLabel.Text = "Release Year   |";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(countryLabel);
            panel5.Controls.Add(countryOriginLabel);
            panel5.Location = new Point(999, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(284, 43);
            panel5.TabIndex = 7;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(100, 9);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(60, 20);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "Country";
            // 
            // countryOriginLabel
            // 
            countryOriginLabel.AutoSize = true;
            countryOriginLabel.Location = new Point(11, 9);
            countryOriginLabel.Name = "countryOriginLabel";
            countryOriginLabel.Size = new Size(76, 20);
            countryOriginLabel.TabIndex = 3;
            countryOriginLabel.Text = "Country   |";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1037, 263);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1037, 263);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 3);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1037, 263);
            textBox3.TabIndex = 1;
            // 
            // Movies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 737);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(saveButton);
            Controls.Add(posterImageBox);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Movies";
            Text = "Movies";
            Description.ResumeLayout(false);
            Description.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)posterImageBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Review.ResumeLayout(false);
            Review.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox posterImageBox;
        private Button saveButton;
        internal Label movieNameLabel;
        private Label statusLabel;
        private Label statusChangeLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage Review;
        private TabPage tabPage2;
        private TabPage Description;
        private Panel panel4;
        private Label yearLabel;
        private Label releaseYearLabel;
        private Panel panel5;
        private Label countryLabel;
        private Label countryOriginLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}