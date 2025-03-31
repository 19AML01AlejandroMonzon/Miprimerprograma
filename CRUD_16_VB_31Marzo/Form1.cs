using System.Linq.Expressions;

namespace CRUD_16_VB_31Marzo
{
    public partial class Form1 : Form
    {
        int codigo = 1;
        static int seleccionFila;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mensaje;
            mensaje = MessageBox.Show("¿Desea salir :,V?", "Colegio Don Bosco",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (mensaje == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        void Limpiar()
        {
            txtNombr.Text = "";
            txtNumcita.Text = "";
            txtTel.Text = "";
            txtNombr.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            object[] agregarDato =
            {
                codigo.ToString(),
                txtNombr.Text,
                txtNumcita.Text,
                txtTel.Text,
                txtCod.Text
            };
            dgvDatos.Rows.Add(agregarDato);
            MessageBox.Show("Cita registrada", "Colegio Don Bosco", MessageBoxButtons.OK, MessageBoxIcon.Information);
            codigo++;
            txtCod.Text = codigo.ToString();
            Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCod.Text = codigo.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount != 0)
                {
                    int indice = dgvDatos.CurrentRow.Index;
                    dgvDatos.Rows[indice].Cells[0].Value = txtCod.Text;
                    dgvDatos.Rows[indice].Cells[1].Value = txtNombr.Text;
                    dgvDatos.Rows[indice].Cells[2].Value = txtNumcita.Text;
                    dgvDatos.Rows[indice].Cells[3].Value = txtTel.Text;
                    MessageBox.Show("Cita Modificada", "Colegio Don Bosco", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No hay cita seleccionada", "Colegio Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionFila > 0)
                    dgvDatos.Rows.RemoveAt(seleccionFila);
                else
                    MessageBox.Show("No hay citas", "Colegio Don Bosco", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas seleccionadas", "Colegio Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
