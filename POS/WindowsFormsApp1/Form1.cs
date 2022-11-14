using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "1";
            else textBox2.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "2";
            else textBox2.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "3";
            else textBox2.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "4";
            else textBox2.Text += "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "5";
            else textBox2.Text += "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "6";
            else textBox2.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "7";
            else textBox2.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "8";
            else textBox2.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "9";
            else textBox2.Text += "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) == 0) textBox2.Text = "0";
            else textBox2.Text += "0";
        }

        private void ACbutton_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) != 0) textBox2.Text = "0";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0") return;
            listBox1.Items.Add("임시계산\t\t\t" + textBox2.Text);
            textBox2.Text = "0";
        }
    }
}
