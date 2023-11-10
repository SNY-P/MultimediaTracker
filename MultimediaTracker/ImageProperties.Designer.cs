namespace MultimediaTracker
{
    partial class ImageProperties
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
            label1 = new Label();
            label2 = new Label();
            sizeLabel = new Label();
            dimensionLabel = new Label();
            closeButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Image Size   |";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Image Dimension   |";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(117, 9);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(34, 20);
            sizeLabel.TabIndex = 2;
            sizeLabel.Text = "size";
            // 
            // dimensionLabel
            // 
            dimensionLabel.AutoSize = true;
            dimensionLabel.Location = new Point(157, 38);
            dimensionLabel.Name = "dimensionLabel";
            dimensionLabel.Size = new Size(78, 20);
            dimensionLabel.TabIndex = 3;
            dimensionLabel.Text = "dimension";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(11, 63);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(dimensionLabel);
            panel1.Controls.Add(sizeLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 105);
            panel1.TabIndex = 5;
            // 
            // ImageProperties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 133);
            Controls.Add(panel1);
            Name = "ImageProperties";
            Text = "ImageProperties";
            Load += ImageProperties_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label sizeLabel;
        private Label dimensionLabel;
        private Button closeButton;
        private Panel panel1;
    }
}