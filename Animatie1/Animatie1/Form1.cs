using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animatie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap b;
        Graphics gb;//graphics pt. bitmap
        Graphics gpb;//graphics pt. picture box
        double u;

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gb = Graphics.FromImage(b);
            gpb = pictureBox1.CreateGraphics();
            u = 0;
            //gpb.DrawEllipse(new Pen(Color.Black),310,50,280,280);
            pictureBox1.Image = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gpb.DrawEllipse(new Pen(Color.Black), 310, 50, 280, 280);
            ///coordonatele centrului
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            double x = 450 + 140 * Math.Cos(u);
            double y = 190 - 140 * Math.Sin(u);
            gpb.DrawEllipse(new Pen(Color.Red, 2), (int)x - 5, (int)y - 5, 10, 10);
            u += 0.05;
        }
    }
}
