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
    public partial class Tema1_DreptunghiArieMinima : Form
    {
        public Tema1_DreptunghiArieMinima()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se da o multime de N puncte in plan, sa se scrie un program care 
        /// determina dreptunghiul de arie minima care sa contina toate punctele.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 3);
            Random random = new Random();
            int x, y, n = 10, raza = 1;
            int minx = panel1.Width, maxx = 50, miny = panel1.Height, maxy = 50;
            for (int i = 0; i < n; i++)

            {
                x = random.Next(50, panel1.Width - 100);
                y = random.Next(50, panel1.Height - 100);
                if (y < miny)
                    miny = y;
                if (y > maxy)
                    maxy = y;
                if (x < minx)
                    minx = x;
                if (x > maxx)
                    maxx = x;
                g.DrawEllipse(pen, x, y, raza, raza);
            }
            pen.Color = Color.Red;
            g.DrawRectangle(pen, minx, miny, maxx - 50, maxy - 50);

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }
    }
}
