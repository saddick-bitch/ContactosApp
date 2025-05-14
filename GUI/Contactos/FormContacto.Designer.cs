namespace GUI.Contactos
{
    partial class FormContacto
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvContactos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            label5 = new Label();
            cmbTipoContacto = new ComboBox();
            label6 = new Label();
            cmbPais = new ComboBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            clbEtiquetas = new CheckedListBox();
            dgvContactos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(134, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(235, 27);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 214);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(134, 237);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(235, 27);
            txtTelefono.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 299);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(134, 322);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(235, 27);
            txtCorreo.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 130);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 55);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 9;
            label5.Text = "Tipo Contacto";
            // 
            // cmbTipoContacto
            // 
            cmbTipoContacto.FormattingEnabled = true;
            cmbTipoContacto.Location = new Point(416, 88);
            cmbTipoContacto.Name = "cmbTipoContacto";
            cmbTipoContacto.Size = new Size(267, 28);
            cmbTipoContacto.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 130);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 11;
            label6.Text = "País";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(416, 153);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(267, 28);
            cmbPais.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(416, 203);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 13;
            label7.Text = "Etiquetas";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(195, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(360, 420);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(518, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // clbEtiquetas
            // 
            clbEtiquetas.FormattingEnabled = true;
            clbEtiquetas.Location = new Point(416, 237);
            clbEtiquetas.Name = "clbEtiquetas";
            clbEtiquetas.Size = new Size(294, 114);
            clbEtiquetas.TabIndex = 18;
            // 
            // dgvContactos
            // 
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Location = new Point(50, 480);
            dgvContactos.Name = "dgvContactos";
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.Size = new Size(700, 200);
            dgvContactos.TabIndex = 19;
            // 
            // FormContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 720);
            Controls.Add(dgvContactos);
            Controls.Add(clbEtiquetas);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(cmbPais);
            Controls.Add(label6);
            Controls.Add(cmbTipoContacto);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormContacto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Contactos";
            Load += FormContacto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCorreo;
        private Label label2;
        private Label label5;
        private ComboBox cmbTipoContacto;
        private Label label6;
        private ComboBox cmbPais;
        private Label label7;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private CheckedListBox clbEtiquetas;
    }
}
