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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            int n = 5;
            Random r = new Random();
            Punct[] puncts = new Punct[n];
            Punct x = new Punct(), y = new Punct(), z = new Punct();
            for (int i = 0; i < n; i++)
            {
                puncts[i] = new Punct(r.Next(50, panel1.Width - 50), r.Next(50, panel1.Height - 50));
                g.DrawEllipse(p, puncts[i].X, puncts[i].Y, 1, 1);
                //aria triunghi determinant
            }
            float aria = 10000, ariaaux;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    for (int k = j + 1; k < n; k++)
                    {
                        //  x1 y2 1 + x2 y3 1 + y1 1 x3 - x3 y2 1 - x1 y3 1 - x2 y1 1
                        ariaaux = Math.Abs( (puncts[i].X * puncts[j].Y * 1) + (puncts[j].X * puncts[k].Y * 1) + (puncts[i].Y * puncts[k].X * 1) -
                            (puncts[k].X * puncts[j].Y * 1) - (puncts[i].X * puncts[k].Y * 1) - (puncts[j].X * puncts[i].Y * 1));
                        if (ariaaux == 0)
                            break;
                        else
                        if (ariaaux < aria)
                        {
                            x.X = puncts[i].X;
                            x.Y = puncts[i].Y;
                            y.X = puncts[j].X;
                            y.Y = puncts[j].Y;
                            z.X = puncts[k].X;
                            z.Y = puncts[k].Y;
                            aria = ariaaux;
                        }
                    }
            p.Color = Color.Red;
            g.DrawLine(p, x.X, x.Y, y.X, y.Y);
            g.DrawLine(p, y.X, y.Y, z.X, z.Y);
            g.DrawLine(p, z.X, z.Y, x.X, x.Y);
        }

        class Punct
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Punct(int x, int y)
            {
                X = x;
                Y = y;
            }
            public Punct() : this(0, 0)
            {
            }
        }
    }
}
