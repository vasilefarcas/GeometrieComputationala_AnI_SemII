using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teme
{
    public partial class DesenarePuncte : Form
    {
        public DesenarePuncte()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        Graphics g;
        public int i = -1;
        public int j = 0;
        public int n, m;
        Point[] pct;


        private void button1_Click_1(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            m = n - 1;
            i = -1;
            j = 0;
            pct = new Point[n];

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            this.Hide();
            this.Show();
        }

        private void DesenarePuncte_MouseClick(object sender, MouseEventArgs e)
        {
            i++;
            j++;
            Pen pen = new Pen(Color.Red, 4);
            g.DrawEllipse(pen, e.X, e.Y, 2, 2);
            Point pt = new Point(e.X, e.Y);
            pct[i] = pt;
            if (i > 0)
            {
                g.DrawLine(pen, pct[i - 1].X, pct[i - 1].Y, pct[i].X, pct[i].Y);
            }

            textBox2.Text = m.ToString();
            n--;
            m--;
            if (n == 0)
            {
                g.DrawLine(pen, pct[0].X, pct[0].Y, pct[j - 1].X, pct[j - 1].Y);
            }
        }
    }
}
