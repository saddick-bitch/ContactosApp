using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using EL;
using TipoContactoEntity = EL.TipoContacto;  // Alias correcto

namespace GUI.TipoContacto
{
    public partial class FormTipoContacto : Form
    {
        public FormTipoContacto()
        {
            InitializeComponent();
        }

        private TipoContactoBLL tipoContactoBLL = new TipoContactoBLL();
        private int idSeleccionado = 0;

        private void FormTipoContacto_Load(object sender, EventArgs e)
        {
            CargarTipoContactos();
        }

        private void CargarTipoContactos()
        {
            dgvTipoContacto.DataSource = tipoContactoBLL.ObtenerTodos();
            dgvTipoContacto.Columns["Id"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 🔥 Usamos el alias TipoContactoEntity
            TipoContactoEntity nuevo = new TipoContactoEntity()
            {
                Nombre = txtNombre.Text
            };

            tipoContactoBLL.Insertar(nuevo);
            CargarTipoContactos();
            txtNombre.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                TipoContactoEntity actualizado = new TipoContactoEntity()
                {
                    Id = idSeleccionado,
                    Nombre = txtNombre.Text
                };

                tipoContactoBLL.Actualizar(actualizado);
                CargarTipoContactos();
                txtNombre.Clear();
                idSeleccionado = 0;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado != 0)
            {
                tipoContactoBLL.Eliminar(idSeleccionado);
                CargarTipoContactos();
                txtNombre.Clear();
                idSeleccionado = 0;
            }
        }

        private void dgvTipoContacto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(dgvTipoContacto.Rows[e.RowIndex].Cells["Id"].Value);
                txtNombre.Text = dgvTipoContacto.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }
    }
}
