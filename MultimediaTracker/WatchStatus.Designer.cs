namespace MultimediaTracker
{
    partial class WatchStatus
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
            watchingButton = new Button();
            completedButton = new Button();
            holdButton = new Button();
            droppedButton = new Button();
            planningButton = new Button();
            SuspendLayout();
            // 
            // watchingButton
            // 
            watchingButton.Location = new Point(14, 15);
            watchingButton.Name = "watchingButton";
            watchingButton.Size = new Size(167, 72);
            watchingButton.TabIndex = 0;
            watchingButton.Text = "Watching";
            watchingButton.UseVisualStyleBackColor = true;
            watchingButton.Click += watchingButton_Click;
            // 
            // completedButton
            // 
            completedButton.Location = new Point(14, 93);
            completedButton.Name = "completedButton";
            completedButton.Size = new Size(167, 72);
            completedButton.TabIndex = 1;
            completedButton.Text = "Completed";
            completedButton.UseVisualStyleBackColor = true;
            completedButton.Click += completedButton_Click;
            // 
            // holdButton
            // 
            holdButton.Location = new Point(14, 171);
            holdButton.Name = "holdButton";
            holdButton.Size = new Size(167, 72);
            holdButton.TabIndex = 2;
            holdButton.Text = "On Hold";
            holdButton.UseVisualStyleBackColor = true;
            holdButton.Click += holdButton_Click;
            // 
            // droppedButton
            // 
            droppedButton.Location = new Point(14, 249);
            droppedButton.Name = "droppedButton";
            droppedButton.Size = new Size(167, 72);
            droppedButton.TabIndex = 3;
            droppedButton.Text = "Dropped";
            droppedButton.UseVisualStyleBackColor = true;
            droppedButton.Click += droppedButton_Click;
            // 
            // planningButton
            // 
            planningButton.Location = new Point(14, 327);
            planningButton.Name = "planningButton";
            planningButton.Size = new Size(167, 72);
            planningButton.TabIndex = 4;
            planningButton.Text = "Plan To Watch";
            planningButton.UseVisualStyleBackColor = true;
            planningButton.Click += planningButton_Click;
            // 
            // WatchStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 410);
            Controls.Add(planningButton);
            Controls.Add(droppedButton);
            Controls.Add(holdButton);
            Controls.Add(completedButton);
            Controls.Add(watchingButton);
            Name = "WatchStatus";
            Text = "Watch Status";
            ResumeLayout(false);
        }

        #endregion

        private Button watchingButton;
        private Button completedButton;
        private Button holdButton;
        private Button droppedButton;
        private Button planningButton;
    }
}