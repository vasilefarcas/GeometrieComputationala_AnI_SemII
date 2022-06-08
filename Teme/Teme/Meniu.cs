namespace Teme
{
    public partial class Meniu : Form
    {
        public Meniu()
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            InvelitoareJarvis f = new InvelitoareJarvis();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TriangulareOtectomie f = new TriangulareOtectomie();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PartitionarePoligoaneMonotone f = new PartitionarePoligoaneMonotone();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TriangularePoligonMonoton f = new TriangularePoligonMonoton();
            f.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            TriangularePoligonMonoton f = new TriangularePoligonMonoton();
            f.Show();
        }
    }
}