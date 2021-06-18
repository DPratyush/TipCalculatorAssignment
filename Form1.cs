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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = Convert.ToDouble(textBox1.Text);
            double tipp = Convert.ToDouble(numericUpDown1.Value);
            double nop = Convert.ToDouble(numericUpDown2.Value);
            double tip = cost * tipp / 100 / nop;
            double bill = (cost / nop) + tip;
            label8.Text = '$'+tip.ToString();
            label9.Text = '$'+bill.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            l.DrawLine(p, 230, 25, 230, 230);
            l.Dispose();
        }
    }
}
