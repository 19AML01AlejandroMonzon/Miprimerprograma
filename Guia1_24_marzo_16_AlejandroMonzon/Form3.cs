using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_16_AlejandroMonzon
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = 1;
            int num;
            num=Convert.ToInt32(textBox1.Text);
            do
            {
                int multi;
                multi = num * cont;
                dataGridView1.Rows.Add(num, cont, multi);
            }
            while (cont < 11);
        }
    }
}
