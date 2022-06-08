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
    public partial class Tema2_TriumghiArieMinima : Form
    {
        public Tema2_TriumghiArieMinima()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3);
            int qx, qy;
            Random random = new Random();
            qx = random.Next(50, panel1.Width - 50);
            qy = random.Next(50, panel1.Height - 50);
            g.DrawEllipse(p, qx, qy, 1, 1);
            p.Color = Color.Black;
            int n = 30;
            float dx = 0, dy = 0;
            for (int i = 0; i < n; i++)
            {
                float x = random.Next(50, panel1.Width - 50);
                float y = random.Next(50, panel1.Height - 50);
                g.DrawEllipse(p, x, y, 1, 1);
                if (qx - x < dx)
                {
                    dx = x;
                    dy = y;
                }
                if (qy - y < dy)
                {
                    dx = x;
                    dy = y;
                }
            }
            p.Color = Color.Red;
            g.DrawEllipse(p, dx, dy, qx, qy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3), p1 = new Pen(Color.Blue, 3);
            Random random = new Random();
            int n = 30;
            float d = random.Next(1, Math.Min(panel1.Width, panel1.Height) - 10);
            float raza = 1;
            float qx = random.Next(50, panel1.Width - 50);
            float qy = random.Next(50, panel1.Height - 50);
            g.DrawEllipse(pen, qx - raza, qy - raza, raza * 2, raza * 2);
            pen = new Pen(Color.Black, 3);
            for (int i = 0; i < n; i++)
            {
                float x = random.Next(10, panel1.Width);
                float y = random.Next(10, panel1.Height);
                float dist = (float)Math.Sqrt(Math.Pow(qx - x, 2) + Math.Pow(qy - y, 2));
                if (dist < d)
                    g.DrawEllipse(p1, x - raza, y - raza, raza * 2, raza * 2);
                else
                    g.DrawEllipse(pen, x - raza, y - raza, raza * 2, raza * 2);
            }

        }
    }
}
