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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32[] values;
            values = new Int32[4];
            string x = textBox1.Text;
            string y = textBox2.Text;
            string z = textBox3.Text;
            string d = textBox5.Text;
            int a_one = Convert.ToInt32(x);
            int a_two = Convert.ToInt32(y);
            int a_three = Convert.ToInt32(z);
            int a_four = Convert.ToInt32(d);
            values[0] = a_one;
            values[1] = a_two;
            values[2] = a_three;
            values[3] = a_four;
            
            for (int i = 0; i < values.Length; i++)
                if (values[i] != a_one)// есть идея с конкретным вводом числа в условия иф
                    textBox4.Text = values[i].ToString();
        }
    }
}
