namespace Reto2ListasSimples
{
    public partial class FrmRutaTesoro : Form
    {
        private readonly ListaSimple ruta = new ListaSimple();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            ActualizarVista();
        }

        // Recorre la lista desde Inicio hasta NULL y vuelve a llenar el grid
        private void ActualizarVista()
        {
            dgvRuta.Rows.Clear();

            Nodo? actual = ruta.Inicio;
            while (actual != null)
            {
                dgvRuta.Rows.Add(actual.Id, actual.Nombre, actual.Pista, actual.Peligro);
                actual = actual.Siguiente;
            }

            lblRuta.Text = ruta.RutaComoTexto();
            lblResumen.Text = $"Ubicaciones: {ruta.Cantidad}    Peligro total: {ruta.PeligroTotal()}";
        }

        private bool LeerId(out int id)
        {
            if (!int.TryParse(txtId.Text.Trim(), out id) || id <= 0)
            {
                MessageBox.Show("El ID debe ser un número entero mayor que 0.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
                return false;
            }

            return true;
        }

        private bool LeerCampos(out int id, out string nombre, out string pista, out int peligro)
        {
            nombre = txtNombre.Text.Trim();
            pista = txtPista.Text.Trim();
            peligro = (int)numPeligro.Value;

            if (!LeerId(out id))
                return false;

            if (nombre == "")
            {
                MessageBox.Show("El nombre de la ubicación no puede estar vacío.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPista.Clear();
            numPeligro.Value = 1;
            dgvRuta.ClearSelection();
            txtId.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!LeerCampos(out int id, out string nombre, out string pista, out int peligro))
                return;

            if (!ruta.Insertar(id, nombre, pista, peligro))
            {
                MessageBox.Show("Ya existe una ubicación con ese ID.", "ID duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ActualizarVista();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!LeerId(out int id))
                return;

            Nodo? nodo = ruta.Buscar(id);

            if (nodo == null)
            {
                MessageBox.Show("No se encontró ninguna ubicación con ese ID.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtNombre.Text = nodo.Nombre;
            txtPista.Text = nodo.Pista;
            numPeligro.Value = nodo.Peligro;
            SeleccionarFila(id);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!LeerCampos(out int id, out string nombre, out string pista, out int peligro))
                return;

            if (!ruta.Modificar(id, nombre, pista, peligro))
            {
                MessageBox.Show("No se encontró una ubicación con ese ID.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ActualizarVista();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!LeerId(out int id))
                return;

            Nodo? nodo = ruta.Buscar(id);

            if (nodo == null)
            {
                MessageBox.Show("No se encontró una ubicación con ese ID.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult respuesta = MessageBox.Show($"¿Eliminar \"{nodo.Nombre}\" de la ruta?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            ruta.Eliminar(id);
            ActualizarVista();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Al hacer clic en una fila se cargan sus datos para editar o eliminar
        private void dgvRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgvRuta.Rows[e.RowIndex].Cells[colId.Index].Value);
            Nodo? nodo = ruta.Buscar(id);

            if (nodo == null)
                return;

            txtId.Text = nodo.Id.ToString();
            txtNombre.Text = nodo.Nombre;
            txtPista.Text = nodo.Pista;
            numPeligro.Value = nodo.Peligro;
        }

        private void SeleccionarFila(int id)
        {
            foreach (DataGridViewRow fila in dgvRuta.Rows)
            {
                if (Convert.ToInt32(fila.Cells[colId.Index].Value) == id)
                {
                    fila.Selected = true;
                    dgvRuta.FirstDisplayedScrollingRowIndex = fila.Index;
                    return;
                }
            }
        }

        // Verde: peligro bajo, amarillo: medio, rojo: alto
        private void dgvRuta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != colPeligro.Index || e.Value == null || e.CellStyle == null)
                return;

            int peligro = Convert.ToInt32(e.Value);

            if (peligro <= 3)
                e.CellStyle.BackColor = Color.FromArgb(200, 235, 200);
            else if (peligro <= 6)
                e.CellStyle.BackColor = Color.FromArgb(250, 235, 170);
            else
                e.CellStyle.BackColor = Color.FromArgb(240, 180, 170);
        }
    }
}
