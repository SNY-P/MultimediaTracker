using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultimediaTracker
{
    public partial class WatchStatus : Form
    {
        private Label labeltoChange;
        public WatchStatus(Label labeltoChange)
        {
            InitializeComponent();
            this.labeltoChange = labeltoChange;
        }

        private void watchingButton_Click(object sender, EventArgs e)
        {
            labeltoChange.Text = watchingButton.Text;
            this.Close();
        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            labeltoChange.Text = completedButton.Text;
            this.Close();
        }

        private void holdButton_Click(object sender, EventArgs e)
        {
            labeltoChange.Text = holdButton.Text;
            this.Close();
        }

        private void droppedButton_Click(object sender, EventArgs e)
        {
            labeltoChange.Text = droppedButton.Text;
            this.Close();
        }

        private void planningButton_Click(object sender, EventArgs e)
        {
            labeltoChange.Text = planningButton.Text;
            this.Close();
        }
    }
}
