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
    public partial class Edit_Info : Form
    {
        private Label labeltoChange;

        public Edit_Info(Label labelChange)
        {
            InitializeComponent();
            this.labeltoChange = labelChange;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string newText = editTextBox.Text;
            labeltoChange.Text = newText;
            this.Close();
        }
    }
}
