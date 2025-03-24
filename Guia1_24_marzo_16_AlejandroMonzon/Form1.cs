namespace Guia1_24_marzo_16_AlejandroMonzon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 0; cont < 10; cont++)
            {
                int Multiplicacion;
                Multiplicacion = num1 * cont;
                dataGridView1.Rows.Add(num1, cont, Multiplicacion);

            }
            //int cont2 = 1;
            // while (cont2 < 11)
            {
                // int Multiplicacion;
                //Multiplicacion = num1 * cont2;
                //dataGridView1.Rows.Add (num1, cont2, Multiplicacion);
                // cont2++;
            }
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
