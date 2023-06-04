using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddingForm : Form
    {

        public AddingForm()
        {

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm Main = this.Owner as MainForm;

            if (textBox1.Text != "")
            {
                if (this.radioButton1.Checked == true) Main.listBox1.Items.Add(this.textBox1.Text);
                else Main.listBox2.Items.Add(this.textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
