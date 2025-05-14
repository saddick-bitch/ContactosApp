using System;
using System.Windows.Forms;
using BLL;
using EL;

namespace GUI.Etiquetas
{
    public partial class FormEtiqueta : Form
    {
        public FormEtiqueta()
        {
            InitializeComponent();
        }

        private EtiquetaBLL etiquetaBLL = new EtiquetaBLL();
        private int idSeleccionado = 0;

        // ✅ Evento Load
        private void FormEtiqueta_Load(object sender, EventArgs e)
        {
            CargarEtiquetas();
        }

        // ✅ Método para llenar la tabla
        private void CargarEtiquetas()
        {
            dgvEtiqueta.DataSource = etiquetaBLL.ObtenerTodos();
            dgvEtiqueta.Columns["Id"].Visible = false;
        }

        // ✅ Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Etiqueta nueva = new Etiqueta()
            {
                Nombre = txtNombre.Text
            };

            etiquetaBLL.Insertar(nueva);
            CargarEtiquetas();
            txtNombre.Clear();
        }

        // ✅ Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                Etiqueta actualizada = new Etiqueta()
                {
                    Id = idSeleccionado,
                    Nombre = txtNombre.Text
                };

                etiquetaBLL.Actualizar(actualizada);
                CargarEtiquetas();
                txtNombre.Clear();
                idSeleccionado = 0;
            }
        }

        // ✅ Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                etiquetaBLL.Eliminar(idSeleccionado);
                CargarEtiquetas();
                txtNombre.Clear();
                idSeleccionado = 0;
            }
        }

        // ✅ Selección de fila para edición
        private void dgvEtiqueta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvEtiqueta.Rows[e.RowIndex].Cells["Id"].Value);
                txtNombre.Text = dgvEtiqueta.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }
    }
}
