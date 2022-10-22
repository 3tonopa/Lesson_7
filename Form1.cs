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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "+1";
            button2.Text = "x2";
            reset.Text = "Сброс";
            label1.Text = "1";
            label2.Text = "0";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            this.Text = "Удвоитель";
        }
        public static int count;
        public static int l1 = 1;
        public static int l3;
        public static int l4;
        public static string l5 = String.Empty;
        public static int undo;
        public static int digit;
        public static int trycount = 0;
        public static bool game = false;
        public static void Reset()
        {
            l1 = 1;
            count = 0;
            l5 = String.Empty;
            trycount = 0;
            undo = 1;
            game = false;
        }
        public static void Play()
        {
            game = true;
            Random rnd = new Random();
            digit = rnd.Next(20, 101);
            trycount = rnd.Next(5, 10);
            l3 = digit;
            l4 = trycount;
            WinCheck();
        }
        public static void WinCheck()
        {
            if (trycount >= count && digit == l1)
            {
                l5 = "WIN!!!";
            }
            if (trycount < count)
            {
                l5 = "FAIL!!!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            undo = l1;
            l1 +=1;
            label1.Text = l1.ToString();
            count++;
            label2.Text = count.ToString();
            if (game == true)
            {
                WinCheck();
            }
            label5.Text = l5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            undo = l1; ;
            l1 *= 2;
            label1.Text = l1.ToString();
            count++;
            label2.Text = count.ToString();
            if (game == true)
            {
                WinCheck();
            }
            label5.Text = l5;
        }
        private void reset_Click_1(object sender, EventArgs e)
        {
            label1.Text = "1";
            label2.Text = "0";
            label3.Text = " ";
            label4.Text = " ";
            label5.Text = " ";
            label6.Text = " ";
            Reset();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            l1 = undo;
            label1.Text = l1.ToString();
            //count--;
            //label2.Text = count.ToString();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            label6.Text = "ИГРА";
            label1.Text = "1";
            Play();
            label3.Text = digit.ToString();
            label4.Text = trycount.ToString();
            label5.Text = l5;
        }
        public void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
