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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
        }
    }
}
