namespace GUI.TipoContacto
{
    partial class FormTipoContacto
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
            label1 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvTipoContacto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTipoContacto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 44);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de Contacto\n";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(325, 27);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Aquí escribirás el nombre del tipo de contacto\n";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(113, 137);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar\n";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(302, 137);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar\n";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(494, 137);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar\n";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvTipoContacto
            // 
            dgvTipoContacto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoContacto.Location = new Point(113, 195);
            dgvTipoContacto.Name = "dgvTipoContacto";
            dgvTipoContacto.RowHeadersWidth = 51;
            dgvTipoContacto.Size = new Size(476, 188);
            dgvTipoContacto.TabIndex = 5;
            // 
            // FormTipoContacto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTipoContacto);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormTipoContacto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Tipos de Contacto";
            Load += FormTipoContacto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoContacto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvTipoContacto;
    }
}