using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
    public partial class Form2 : Form
    {
        public int digit;
        public int count = 0;
        public int prop = 0;
        public string text;
        static int rnd(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public Form2()
        {
            InitializeComponent();
            label1.Text = " O ";
            textBox1.Text = " ";
            textBox1.TextChanged += textBox1_TextChanged;
        }
        public void label1_Click(object sender, EventArgs e) //указатель больше.меньше
        {
        }
        public void label2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e) //играть
        {
            Play();
        }

        public void textBox1_TextChanged(object sender, EventArgs e) //ввод числа
        {
          // DoCompare();
        }
        private void Play()
        {
            digit = rnd(1, 100);
            label2.Text = digit.ToString();
            label1.Text = "-";
            textBox1.Text = "--";
            
        }
        public void DoCompare()
        {
            count++;          
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            // int prop;
            if (!int.TryParse(textBox1.Text, out prop))
            {
                
                return;
            }

            if (prop == digit)
            {
                label1.Text = "EQUAL";
                label2.Text = $@"YOU WIN! 
in {count} turn(s)  ";
            }
            else if (prop > digit)
            {
                label1.Text = "LESS";
            }

            else
            {
                label1.Text = "MORE";
            }
            textBox1.Text = "--";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoCompare();
        }
    }


}

