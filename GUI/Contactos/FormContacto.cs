using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI.Contactos
{
    public partial class FormContacto : Form
    {
        private ContactoBLL contactoBLL = new ContactoBLL();
        private TipoContactoBLL tipoContactoBLL = new TipoContactoBLL();
        private PaisBLL paisBLL = new PaisBLL();
        private EtiquetaBLL etiquetaBLL = new EtiquetaBLL();
        private int idSeleccionado = 0;

        public FormContacto()
        {
            InitializeComponent();
        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            CargarContactos();
            CargarTipoContactos();
            CargarPaises();
            CargarEtiquetas();
        }

        private void CargarContactos()
        {
            var contactos = contactoBLL.ObtenerTodosConRelaciones();
            dgvContactos.DataSource = contactos ?? new List<Contacto>();

            if (dgvContactos.Columns.Count > 0)
            {
                dgvContactos.Columns["Id"].Visible = false;
                dgvContactos.Columns["TipoContacto"].Visible = false;
                // dgvContactos.Columns["ContactoEtiquetas"].Visible = false;
                dgvContactos.Columns["Pais"].Visible = false;
            }
        }

        private void CargarTipoContactos()
        {
            var tipos = tipoContactoBLL.ObtenerTodos();
            cmbTipoContacto.DataSource = tipos;
            cmbTipoContacto.DisplayMember = "Nombre";
            cmbTipoContacto.ValueMember = "Id";
            cmbTipoContacto.SelectedIndex = -1;
        }


        private void CargarPaises()
        {
            var paises = paisBLL.ObtenerTodos();
            cmbPais.DataSource = paises ?? new List<Pais>();
            cmbPais.DisplayMember = "Nombre";
            cmbPais.ValueMember = "Id";
            cmbPais.SelectedIndex = -1;
        }

        private void CargarEtiquetas()
        {
            clbEtiquetas.Items.Clear();
            var etiquetas = etiquetaBLL.ObtenerTodos();
            if (etiquetas != null)
            {
                foreach (var etiqueta in etiquetas)
                    clbEtiquetas.Items.Add(etiqueta, false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var nuevo = new Contacto
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                TipoContactoId = Convert.ToInt32(cmbTipoContacto.SelectedValue),
                PaisId = Convert.ToInt32(cmbPais.SelectedValue)
            };

            List<int> etiquetas = ObtenerEtiquetasSeleccionadas();
            contactoBLL.Insertar(nuevo, etiquetas);
            CargarContactos();
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un contacto para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            var actualizado = new Contacto
            {
                Id = idSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                TipoContactoId = Convert.ToInt32(cmbTipoContacto.SelectedValue),
                PaisId = Convert.ToInt32(cmbPais.SelectedValue)
            };

            List<int> etiquetas = ObtenerEtiquetasSeleccionadas();
            contactoBLL.Actualizar(actualizado, etiquetas);
            CargarContactos();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un contacto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Deseas eliminar este contacto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                contactoBLL.Eliminar(idSeleccionado);
                CargarContactos();
                LimpiarCampos();
            }
        }

        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvContactos.Rows.Count)
            {
                var fila = dgvContactos.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString();
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString();
                cmbTipoContacto.SelectedValue = fila.Cells["TipoContactoId"].Value ?? -1;
                cmbPais.SelectedValue = fila.Cells["PaisId"].Value ?? -1;

                var etiquetas = contactoBLL.ObtenerEtiquetasPorContacto(idSeleccionado);
                MarcarEtiquetasSeleccionadas(etiquetas);
            }
        }

        private List<int> ObtenerEtiquetasSeleccionadas()
        {
            List<int> ids = new List<int>();
            foreach (var item in clbEtiquetas.CheckedItems)
            {
                if (item is Etiqueta etiqueta)
                    ids.Add(etiqueta.Id);
            }
            return ids;
        }

        private void MarcarEtiquetasSeleccionadas(List<int> idsSeleccionados)
        {
            for (int i = 0; i < clbEtiquetas.Items.Count; i++)
            {
                if (clbEtiquetas.Items[i] is Etiqueta etiqueta)
                    clbEtiquetas.SetItemChecked(i, idsSeleccionados.Contains(etiqueta.Id));
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                cmbTipoContacto.SelectedIndex == -1 ||
                cmbPais.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbTipoContacto.SelectedIndex = -1;
            cmbPais.SelectedIndex = -1;
            for (int i = 0; i < clbEtiquetas.Items.Count; i++)
                clbEtiquetas.SetItemChecked(i, false);
            idSeleccionado = 0;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
