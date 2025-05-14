using System;
using System.Windows.Forms;
// 👇 Agrega estos usings para que encuentre los formularios
using GUI.Contactos;
using GUI.TipoContacto;
using GUI.Etiquetas;
using GUI.Paises;

namespace GUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // 🎯 MÉTODO CLAVE: abrir formularios dentro de panelContenido
        private void AbrirFormulario(Form formulario)
        {
            if (panelContenido.Controls.Count > 0)
                panelContenido.Controls.RemoveAt(0);

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(formulario);
            panelContenido.Tag = formulario;
            formulario.Show();
        }

        // 🎯 EVENTOS DE LOS BOTONES
        private void btnContactos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormContacto());
        }

        private void btnTipoContacto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormTipoContacto());
        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormEtiqueta());
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPais());   
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
