using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageAnimation
{
    public partial class Form1 : Form
    {
        private Bitmap[] Frames;
        private int FrameNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            FrameTimer.Enabled = !FrameTimer.Enabled;
            if (FrameTimer.Enabled)
            {
                button_Start.Text = "Stop";
            }
            else
            {
                button_Start.Text = "Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Frames = new Bitmap[18];
            for (int i = 0; i < 18; i++)
            {
                Frames[i] = new Bitmap("E:/Programm/ImageAnimation/Frame" + i + ".png");
            }
            pictureBox.Image = Frames[FrameNum];
        }

        private void FrameTimer_Tick(object sender, EventArgs e)
        {
            FrameNum = ++FrameNum % Frames.Length;
            pictureBox.Image = Frames[FrameNum];
        }
    }
}
