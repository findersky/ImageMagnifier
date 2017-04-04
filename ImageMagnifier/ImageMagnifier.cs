using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ImageMagnifier;

namespace ImageMagnifier
{
    public partial class ImageMagnifier : Form
    {
        public ImageMagnifier()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            ofdselect.Filter = "jpg|*.jpg|bmp|*.bmp|jpeg|*.jpeg";
            ofdselect.RestoreDirectory = true;
            ofdselect.FilterIndex = 1;
            ofdselect.Title = "图像选择";
            if (DialogResult.OK == ofdselect.ShowDialog())
            {
                picone.Image = Image.FromFile(ofdselect.FileName);
            
            }
        }

        private void numericCon_ValueChanged(object sender, EventArgs e)
        {
            if (picone.Image == null)
            {
                return;
            }
            this.numericCon.Enabled = false;

            MagnifierImage img =new MagnifierImage();

            pictwo.Image=img.Magnifier((Bitmap)picone.Image, (int)this.numericCon.Value);

            this.numericCon.Enabled = true;
        }

        private void pictwo_DoubleClick(object sender, EventArgs e)
        {
            pictwo.Image.Save("test.jpg");
        }
    }
}
