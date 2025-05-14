namespace GUI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnSalir = new Button();
            btnPaises = new Button();
            btnEtiquetas = new Button();
            btnTipoContacto = new Button();
            btnContactos = new Button();
            panelContenido = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.AppWorkspace;
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnPaises);
            panelMenu.Controls.Add(btnEtiquetas);
            panelMenu.Controls.Add(btnTipoContacto);
            panelMenu.Controls.Add(btnContactos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(278, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(73, 292);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir\n\n";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnPaises
            // 
            btnPaises.Location = new Point(73, 237);
            btnPaises.Name = "btnPaises";
            btnPaises.Size = new Size(94, 29);
            btnPaises.TabIndex = 3;
            btnPaises.Text = "Paises";
            btnPaises.UseVisualStyleBackColor = true;
            btnPaises.Click += btnPaises_Click;
            // 
            // btnEtiquetas
            // 
            btnEtiquetas.Location = new Point(73, 184);
            btnEtiquetas.Name = "btnEtiquetas";
            btnEtiquetas.Size = new Size(94, 29);
            btnEtiquetas.TabIndex = 2;
            btnEtiquetas.Text = "Etiquetas";
            btnEtiquetas.UseVisualStyleBackColor = true;
            btnEtiquetas.Click += btnEtiquetas_Click;
            // 
            // btnTipoContacto
            // 
            btnTipoContacto.Location = new Point(73, 131);
            btnTipoContacto.Name = "btnTipoContacto";
            btnTipoContacto.Size = new Size(142, 29);
            btnTipoContacto.TabIndex = 1;
            btnTipoContacto.Text = "Tipo de Contacto\n";
            btnTipoContacto.UseVisualStyleBackColor = true;
            btnTipoContacto.Click += btnTipoContacto_Click;
            // 
            // btnContactos
            // 
            btnContactos.Location = new Point(73, 78);
            btnContactos.Name = "btnContactos";
            btnContactos.Size = new Size(94, 29);
            btnContactos.TabIndex = 0;
            btnContactos.Text = "Contactos";
            btnContactos.UseVisualStyleBackColor = true;
            btnContactos.Click += btnContactos_Click;
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(278, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(522, 450);
            panelContenido.TabIndex = 1;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de Contactos";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);


        }

        #endregion

        private Panel panelMenu;
        private Button btnSalir;
        private Button btnPaises;
        private Button btnEtiquetas;
        private Button btnTipoContacto;
        private Button btnContactos;
        private Panel panelContenido;
    }
}