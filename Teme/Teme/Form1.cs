namespace Teme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tema1 tema1 = new Tema1();
            tema1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tema2 tema2 = new Tema2();
            tema2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tema3 tema3 = new Tema3();
            tema3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tema4 tema4 = new Tema4();
            tema4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InvelitaoreConvexa f = new InvelitaoreConvexa();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Triangulare f=new Triangulare();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DesenarePuncte f=new DesenarePuncte();
            f.Show();
        }
    }
}