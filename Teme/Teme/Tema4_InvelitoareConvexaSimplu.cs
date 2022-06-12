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
    public partial class Tema4_InvelitoareConvexaSimplu : Form
    {
        public Tema4_InvelitoareConvexaSimplu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p1 = new Pen(Color.Black, 1);

            Random rnd = new Random();
            int n = rnd.Next(5, 65);
            int raza = 2;
            // creez un punct random:
            float x1 = rnd.Next(50, panel1.Width - 100);
            float y1 = rnd.Next(50, panel1.Height - 100);
            g.DrawEllipse(p1, x1 - raza, y1 - raza, 2 * raza, 2 * raza);
            //distanta pina la cel mai apropiat punct 
            double dist = panel1.Width;


            for (int i = 0; i < n; i++)
            {
                double distAux = 0;
                float x = rnd.Next(20, panel1.Width - 100);
                float y = rnd.Next(20, panel1.Height - 100);

                g.DrawEllipse(p1, x - raza, y - raza, 2 * raza, 2 * raza);
                if (x <= x1 && y < y1)
                {
                    distAux = Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y));
                }
                else if (x > x1 && y <= y1)
                {
                    distAux = Math.Sqrt((x - x1) * (x - x1) + (y1 - y) * (y1 - y));
                }
                else if (x < x1 && y >= y1)
                {
                    distAux = Math.Sqrt((x1 - x) * (x1 - x) + (y - y1) * (y - y1));
                }
                else if (x >= x1 && y > y1)
                {
                    distAux = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1));
                }
                //
                if (distAux < dist)
                {
                    dist = distAux;
                }
            }



            p1.Color = Color.Red;
            g.DrawEllipse(p1, (float)(x1 - dist), (float)(y1 - dist), (float)(2 * dist), (float)(2 * dist));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }
    }
}
