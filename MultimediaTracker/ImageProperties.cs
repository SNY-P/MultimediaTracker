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
    public partial class ImageProperties : Form
    {
        int height, width;
        long byteSize;
        public ImageProperties(long byteSize, int height, int width)
        {
            InitializeComponent();
            this.byteSize = byteSize;
            this.height = height;
            this.width = width;
        }

        private void ImageProperties_Load(object sender, EventArgs e)
        {
            string size = ((double)byteSize / 1048576).ToString("0.00") + "mb";
            string dimension = height.ToString() + "x" + width.ToString();

            sizeLabel.Text = size;
            dimensionLabel.Text = dimension;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
