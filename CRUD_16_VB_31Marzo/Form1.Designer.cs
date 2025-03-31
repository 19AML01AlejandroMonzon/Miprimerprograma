namespace CRUD_16_VB_31Marzo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnRegistrar = new Button();
            txtTel = new TextBox();
            txtNumcita = new TextBox();
            txtNombr = new TextBox();
            txtCod = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDatos = new DataGridView();
            cod = new DataGridViewTextBoxColumn();
            nombreyapellido = new DataGridViewTextBoxColumn();
            CitaNum = new DataGridViewTextBoxColumn();
            tel = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(txtTel);
            groupBox1.Controls.Add(txtNumcita);
            groupBox1.Controls.Add(txtNombr);
            groupBox1.Controls.Add(txtCod);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(554, 97);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 28);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(554, 60);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 28);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(554, 22);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(103, 28);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(89, 89);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(435, 23);
            txtTel.TabIndex = 1;
            // 
            // txtNumcita
            // 
            txtNumcita.Location = new Point(127, 59);
            txtNumcita.Name = "txtNumcita";
            txtNumcita.Size = new Size(397, 23);
            txtNumcita.TabIndex = 1;
            // 
            // txtNombr
            // 
            txtNombr.Location = new Point(143, 27);
            txtNombr.Name = "txtNombr";
            txtNombr.Size = new Size(381, 23);
            txtNombr.TabIndex = 1;
            // 
            // txtCod
            // 
            txtCod.AutoSize = true;
            txtCod.Location = new Point(27, 126);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(49, 15);
            txtCod.TabIndex = 0;
            txtCod.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 97);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Número de Cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            label1.Click += label1_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { cod, nombreyapellido, CitaNum, tel });
            dgvDatos.Location = new Point(21, 185);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(737, 219);
            dgvDatos.TabIndex = 1;
            // 
            // cod
            // 
            cod.HeaderText = "Codigo";
            cod.Name = "cod";
            // 
            // nombreyapellido
            // 
            nombreyapellido.HeaderText = "Nombre y Apellido";
            nombreyapellido.Name = "nombreyapellido";
            // 
            // CitaNum
            // 
            CitaNum.HeaderText = "Numero de Cita";
            CitaNum.Name = "CitaNum";
            // 
            // tel
            // 
            tel.HeaderText = "Telefono";
            tel.Name = "tel";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(103, 28);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(148, 410);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 28);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(dgvDatos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnModificar;
        private Button btnNuevo;
        private Button btnRegistrar;
        private TextBox txtTel;
        private TextBox txtNumcita;
        private TextBox txtNombr;
        private Label txtCod;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatos;
        private Button btnEliminar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn cod;
        private DataGridViewTextBoxColumn nombreyapellido;
        private DataGridViewTextBoxColumn CitaNum;
        private DataGridViewTextBoxColumn tel;
    }
}
