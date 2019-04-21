using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsLab3
{
    public partial class Form1 : Form
    {
        Vector A = new Vector(0, 0, 0);
        Vector B = new Vector(0, 0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Vector A:\r\n";
            A.printVectorInfo(textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Vector B:\r\n";
            B.printVectorInfo(textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Vector C:\r\n";
            Vector C = (A + B) * B;
            C.printVectorInfo(textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "F equals: ";
            Vector C = (A + B) * B;
            double F = A % C;
            textBox1.Text += F;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            A.x = (float)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            A.y = (float)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            A.z = (float)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            B.x = (float)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            B.y = (float)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            B.z = (float)numericUpDown6.Value;
        }
    }
}
