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
            Tema1_DreptunghiArieMinima tema1 = new Tema1_DreptunghiArieMinima();
            tema1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tema2_TriumghiArieMinima tema2 = new Tema2_TriumghiArieMinima();
            tema2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tema3_CercArieMinima tema3 = new Tema3_CercArieMinima();
            tema3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tema4_InvelitoareConvexaSimplu tema4 = new Tema4_InvelitoareConvexaSimplu();
            tema4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Triunghi form2 = new Triunghi();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tema5_InvelitaoreConvexa f = new Tema5_InvelitaoreConvexa();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tema7_Triangulare f=new Tema7_Triangulare();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tema6_DesenarePoligon f=new Tema6_DesenarePoligon();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tema5_InvelitoareConvexaJarvis f = new Tema5_InvelitoareConvexaJarvis();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Tema8_TriangulareOtectomie f = new Tema8_TriangulareOtectomie();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tema9_PartitionarePoligoaneMonotone f = new Tema9_PartitionarePoligoaneMonotone();
            f.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Tema10_TriangularePoligonMonoton f = new Tema10_TriangularePoligonMonoton();
            f.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Tema10_TriangularePoligonMonoton f = new Tema10_TriangularePoligonMonoton();
            f.Show();
        }
    }
}