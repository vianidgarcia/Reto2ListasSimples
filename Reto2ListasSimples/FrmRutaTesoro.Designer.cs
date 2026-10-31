namespace Reto2ListasSimples
{
    partial class FrmRutaTesoro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            grpDatos = new GroupBox();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPista = new Label();
            txtPista = new TextBox();
            lblPeligro = new Label();
            numPeligro = new NumericUpDown();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvRuta = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPista = new DataGridViewTextBoxColumn();
            colPeligro = new DataGridViewTextBoxColumn();
            lblRuta = new Label();
            lblResumen = new Label();
            DataGridViewCellStyle estiloEncabezado = new DataGridViewCellStyle();
            DataGridViewCellStyle estiloCeldas = new DataGridViewCellStyle();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(224, 0, 0);
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "La Ruta del Tesoro Perdido";
            //
            // grpDatos
            //
            grpDatos.Controls.Add(lblId);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblPista);
            grpDatos.Controls.Add(txtPista);
            grpDatos.Controls.Add(lblPeligro);
            grpDatos.Controls.Add(numPeligro);
            grpDatos.BackColor = Color.FromArgb(255, 234, 204);
            grpDatos.ForeColor = Color.FromArgb(150, 0, 0);
            grpDatos.Location = new Point(20, 60);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(640, 150);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la ubicación";
            //
            // lblId
            //
            lblId.AutoSize = true;
            lblId.ForeColor = Color.FromArgb(60, 30, 20);
            lblId.Location = new Point(15, 30);
            lblId.Name = "lblId";
            lblId.Text = "ID de ubicación:";
            //
            // txtId
            //
            txtId.Location = new Point(175, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 25);
            txtId.TabIndex = 0;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.FromArgb(60, 30, 20);
            lblNombre.Location = new Point(15, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            txtNombre.Location = new Point(175, 59);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(445, 25);
            txtNombre.TabIndex = 1;
            //
            // lblPista
            //
            lblPista.AutoSize = true;
            lblPista.ForeColor = Color.FromArgb(60, 30, 20);
            lblPista.Location = new Point(15, 94);
            lblPista.Name = "lblPista";
            lblPista.Text = "Pista:";
            //
            // txtPista
            //
            txtPista.Location = new Point(175, 91);
            txtPista.MaxLength = 100;
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(445, 25);
            txtPista.TabIndex = 2;
            //
            // lblPeligro
            //
            lblPeligro.AutoSize = true;
            lblPeligro.ForeColor = Color.FromArgb(60, 30, 20);
            lblPeligro.Location = new Point(300, 30);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Text = "Nivel de peligro (1-10):";
            //
            // numPeligro
            //
            numPeligro.Location = new Point(460, 27);
            numPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPeligro.Name = "numPeligro";
            numPeligro.Size = new Size(60, 25);
            numPeligro.TabIndex = 3;
            numPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // btnAgregar
            //
            btnAgregar.Location = new Point(20, 225);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.BackColor = Color.FromArgb(160, 236, 124);
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(224, 0, 0);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.FromArgb(60, 30, 20);
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(151, 225);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.BackColor = Color.FromArgb(252, 168, 120);
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(224, 0, 0);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(60, 30, 20);
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            //
            // btnModificar
            //
            btnModificar.Location = new Point(282, 225);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 35);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.BackColor = Color.FromArgb(252, 168, 120);
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(224, 0, 0);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(60, 30, 20);
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Location = new Point(413, 225);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(116, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.BackColor = Color.FromArgb(224, 0, 0);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(224, 0, 0);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.FromArgb(255, 255, 255);
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnLimpiar
            //
            btnLimpiar.Location = new Point(544, 225);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 35);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.BackColor = Color.FromArgb(255, 234, 204);
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(224, 0, 0);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(60, 30, 20);
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            //
            // dgvRuta
            //
            dgvRuta.AllowUserToAddRows = false;
            dgvRuta.AllowUserToDeleteRows = false;
            dgvRuta.AllowUserToResizeRows = false;
            dgvRuta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuta.BackgroundColor = Color.FromArgb(255, 234, 204);
            dgvRuta.BorderStyle = BorderStyle.None;
            estiloEncabezado.BackColor = Color.FromArgb(224, 0, 0);
            estiloEncabezado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            estiloEncabezado.ForeColor = Color.White;
            estiloEncabezado.SelectionBackColor = Color.FromArgb(224, 0, 0);
            estiloEncabezado.SelectionForeColor = Color.White;
            dgvRuta.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            estiloCeldas.BackColor = Color.White;
            estiloCeldas.ForeColor = Color.FromArgb(60, 30, 20);
            estiloCeldas.SelectionBackColor = Color.FromArgb(252, 168, 120);
            estiloCeldas.SelectionForeColor = Color.FromArgb(60, 30, 20);
            dgvRuta.DefaultCellStyle = estiloCeldas;
            dgvRuta.EnableHeadersVisualStyles = false;
            dgvRuta.GridColor = Color.FromArgb(252, 168, 120);
            dgvRuta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRuta.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPista, colPeligro });
            dgvRuta.Location = new Point(20, 275);
            dgvRuta.MultiSelect = false;
            dgvRuta.Name = "dgvRuta";
            dgvRuta.ReadOnly = true;
            dgvRuta.RowHeadersVisible = false;
            dgvRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuta.Size = new Size(640, 250);
            dgvRuta.TabIndex = 6;
            dgvRuta.CellClick += dgvRuta_CellClick;
            dgvRuta.CellFormatting += dgvRuta_CellFormatting;
            //
            // colId
            //
            colId.FillWeight = 12F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            //
            // colNombre
            //
            colNombre.FillWeight = 33F;
            colNombre.HeaderText = "Ubicación";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            //
            // colPista
            //
            colPista.FillWeight = 40F;
            colPista.HeaderText = "Pista";
            colPista.Name = "colPista";
            colPista.ReadOnly = true;
            //
            // colPeligro
            //
            colPeligro.FillWeight = 15F;
            colPeligro.HeaderText = "Peligro";
            colPeligro.Name = "colPeligro";
            colPeligro.ReadOnly = true;
            //
            // lblRuta
            //
            lblRuta.BackColor = Color.FromArgb(252, 168, 120);
            lblRuta.BorderStyle = BorderStyle.FixedSingle;
            lblRuta.ForeColor = Color.FromArgb(60, 30, 20);
            lblRuta.Location = new Point(20, 540);
            lblRuta.Name = "lblRuta";
            lblRuta.Padding = new Padding(5);
            lblRuta.Size = new Size(640, 55);
            lblRuta.Text = "Inicio → NULL";
            //
            // lblResumen
            //
            lblResumen.AutoSize = true;
            lblResumen.ForeColor = Color.FromArgb(224, 0, 0);
            lblResumen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblResumen.Location = new Point(20, 605);
            lblResumen.Name = "lblResumen";
            lblResumen.Text = "Ubicaciones: 0    Peligro total: 0";
            //
            // FrmRutaTesoro
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 230);
            ClientSize = new Size(680, 640);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatos);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvRuta);
            Controls.Add(lblRuta);
            Controls.Add(lblResumen);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRutaTesoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reto 2 - La Ruta del Tesoro Perdido";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpDatos;
        private Label lblId;
        private TextBox txtId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPista;
        private TextBox txtPista;
        private Label lblPeligro;
        private NumericUpDown numPeligro;
        private Button btnAgregar;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvRuta;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPista;
        private DataGridViewTextBoxColumn colPeligro;
        private Label lblRuta;
        private Label lblResumen;
    }
}