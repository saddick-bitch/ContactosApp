using System;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI.Paises
{
    public partial class FormPais : Form
    {
        private PaisBLL paisBLL = new PaisBLL();
        private int idSeleccionado = 0;

        public FormPais()
        {
            InitializeComponent();
        }

        private void FormPais_Load(object sender, EventArgs e)
        {
            CargarPaises();
        }

        private void CargarPaises()
        {
            dgvPais.DataSource = paisBLL.ObtenerTodos();
            dgvPais.Columns["Id"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe llenar ambos campos: Nombre y Código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pais nuevo = new Pais
            {
                Nombre = txtNombre.Text.Trim(),
                Codigo = txtCodigo.Text.Trim()
            };

            paisBLL.Insertar(nuevo);
            CargarPaises();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pais actualizado = new Pais
            {
                Id = idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Codigo = txtCodigo.Text.Trim()
            };

            paisBLL.Actualizar(actualizado);
            CargarPaises();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                paisBLL.Eliminar(idSeleccionado);
                CargarPaises();
                LimpiarCampos();
            }
        }

        private void dgvPais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvPais.Rows[e.RowIndex].Cells["Id"].Value);
                txtNombre.Text = dgvPais.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtCodigo.Text = dgvPais.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCodigo.Clear();
            idSeleccionado = 0;
        }
    }
}

