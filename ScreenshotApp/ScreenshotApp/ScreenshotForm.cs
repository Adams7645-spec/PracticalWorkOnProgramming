using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotApp
{
    public partial class ShowScreenshotForm : Form
    {
        public ShowScreenshotForm()
        {
            InitializeComponent();

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = ScreenshotForm.BM;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                ScreenshotForm.BM.Save(SFD.FileName);
            }
        }
    }
}
