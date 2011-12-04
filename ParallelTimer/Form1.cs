using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ParallelTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Beginning";
            Stopwatch sw = Stopwatch.StartNew();

            int x = 1;

            for (int i = 0; i < 1000000000; i++)
            {
                x *= i;
            }

            sw.Stop();
            textBox1.Text = "Total Time: " + sw.ElapsedMilliseconds;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label2.Text = "Beginning";
            Stopwatch sw = Stopwatch.StartNew();

            int x = 1;
            System.Threading.Tasks.Parallel.For(0, 1000000000, i =>
            {
                x *= i;
            });

            sw.Stop();
            textBox2.Text = "Total Time: " + sw.ElapsedMilliseconds;
        }
    }
}
