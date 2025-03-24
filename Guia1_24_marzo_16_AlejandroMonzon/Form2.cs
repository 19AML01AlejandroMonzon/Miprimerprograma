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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int i=1;
            while (i < 11)
            {
                int Multi;
                Multi = num1 * i;

                dataGridView1.Rows.Add(num1, i, Multi);
                i++;
            }
        }
    }
}
