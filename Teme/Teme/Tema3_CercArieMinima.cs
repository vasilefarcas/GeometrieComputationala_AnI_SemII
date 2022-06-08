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
    public partial class Tema3_CercArieMinima : Form
    {
        public Tema3_CercArieMinima()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            int n = 8;
            int x, y, minx = panel1.Width, miny = panel1.Height, maxx = 0, maxy = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                x = random.Next(50, panel1.Width - 50);
                y = random.Next(50, panel1.Height - 50);
                g.DrawEllipse(p, x, y, 1, 1);
                if (x < minx)
                    minx = x;
                if (x > maxx)
                    maxx = x;
                if (y < miny)
                    miny = y;
                if (y > maxy)
                    maxy = y;

            }
            p.Color = Color.Red;
            g.DrawEllipse(p, minx - 50, miny - 50, Math.Max(panel1.Width - minx, panel1.Height - miny), Math.Max(panel1.Width - minx, panel1.Height - miny));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }
    }
}
