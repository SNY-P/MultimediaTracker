using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;

namespace MultimediaTracker
{
    public partial class Movies : Form
    {
        int height, width;
        long byteSize;
        public Movies()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs mou = (MouseEventArgs)e;

            if (mou.Button == MouseButtons.Left)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files: (*.jpg, *.jpeg, *.png, *.webp;)|*.jpg; *.jpeg; *.png; *.webp;";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    posterImageBox.Image = new Bitmap(path);

                    width = posterImageBox.Width;
                    height = posterImageBox.Height;

                    FileInfo fileInfo = new FileInfo(path);
                    byteSize = fileInfo.Length;
                }
            }
            else if (mou.Button == MouseButtons.Right)
            {
                ImageProperties newForm = new ImageProperties(byteSize, height, width);
                newForm.Show();
            }
        }

        private void movieNameLabel_Click(object sender, EventArgs e)
        {
            Edit_Info ei = new Edit_Info(movieNameLabel);
            ei.ShowDialog();
        }

        private void statusChangeLabel_Click(object sender, EventArgs e)
        {
            WatchStatus ws = new WatchStatus(statusChangeLabel);
            ws.ShowDialog();
        }
    }
}
