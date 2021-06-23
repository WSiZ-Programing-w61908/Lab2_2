using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_zad2
{
    public partial class Form1 : Form
    {
        float size;
        System.Drawing.FontStyle style = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            size = textBox1.Font.Size;
            if (radioButton1.Checked == true)
            {
                size = 10;
            }
            else if (radioButton2.Checked == true)
            {
                size = 20;
            }
            else if (radioButton3.Checked == true)
            {
                size = 30;
            }
            
            if(radioButton4.Checked == true)
            {
                textBox1.ForeColor = Color.Red;
            }
            else if (radioButton5.Checked == true)
            {
                textBox1.ForeColor = Color.Blue;
            }
            else if (radioButton6.Checked == true)
            {
                textBox1.ForeColor = Color.Orange;
            }

            if (checkBox1.Checked == true)
            {
                style |= FontStyle.Bold;
            }
            if (checkBox2.Checked == true)
            {
                style |= FontStyle.Italic;
            }
            if (checkBox3.Checked == true)
            {
                style |= FontStyle.Underline;
            }


            textBox1.Font = new Font(textBox1.Font.FontFamily, size, style);
        }

    }
}
