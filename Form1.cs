using Microsoft.VisualBasic;

namespace Programa1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[,] matriz1;
        private int[,] matriz2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matriz1 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz1[f, c] = Convert.ToInt32(Interaction.InputBox("Ingrese un numero: "));
                    listBox1.Items.Add(matriz1[f, c]);
                }
            }
        }
        private int[,] suma;
        private void button3_Click(object sender, EventArgs e)
        {
            suma = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    suma[f, c] = matriz1[f, c] + matriz2[f, c];
                    listBox2.Items.Add(suma[f, c]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matriz2 = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matriz2[f, c] = Convert.ToInt32(Interaction.InputBox("Ingrese un numero: "));
                    listBox3.Items.Add(matriz2[f, c]);
                }
            }
        }
    }
}
