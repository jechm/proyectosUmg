namespace Ejercicio060926_Progra2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbInformacionLibro = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblExistencias = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.btnCargarExistencias = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gbInformacionLibro.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacionLibro
            // 
            this.gbInformacionLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbInformacionLibro.Controls.Add(this.cmbGenero);
            this.gbInformacionLibro.Controls.Add(this.txtExistencias);
            this.gbInformacionLibro.Controls.Add(this.txtAutor);
            this.gbInformacionLibro.Controls.Add(this.txtTitulo);
            this.gbInformacionLibro.Controls.Add(this.txtCodigo);
            this.gbInformacionLibro.Controls.Add(this.lblExistencias);
            this.gbInformacionLibro.Controls.Add(this.lblGenero);
            this.gbInformacionLibro.Controls.Add(this.lblAutor);
            this.gbInformacionLibro.Controls.Add(this.lblTitulo);
            this.gbInformacionLibro.Controls.Add(this.lblCodigo);
            this.gbInformacionLibro.Controls.Add(this.gbEstado);
            this.gbInformacionLibro.Location = new System.Drawing.Point(9, 13);
            this.gbInformacionLibro.Name = "gbInformacionLibro";
            this.gbInformacionLibro.Size = new System.Drawing.Size(336, 251);
            this.gbInformacionLibro.TabIndex = 0;
            this.gbInformacionLibro.TabStop = false;
            this.gbInformacionLibro.Text = "Información Libro";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(77, 97);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(149, 21);
            this.cmbGenero.TabIndex = 3;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(77, 130);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(149, 20);
            this.txtExistencias.TabIndex = 2;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(77, 70);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(242, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(77, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(242, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(170, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblExistencias
            // 
            this.lblExistencias.AutoSize = true;
            this.lblExistencias.Location = new System.Drawing.Point(13, 133);
            this.lblExistencias.Name = "lblExistencias";
            this.lblExistencias.Size = new System.Drawing.Size(63, 13);
            this.lblExistencias.TabIndex = 1;
            this.lblExistencias.Text = "Existencias:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(13, 106);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Género:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(13, 77);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // gbEstado
            // 
            this.gbEstado.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Location = new System.Drawing.Point(15, 162);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(211, 65);
            this.gbEstado.TabIndex = 0;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(108, 28);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbInactivo.TabIndex = 0;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 28);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(55, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbMantenimiento.Controls.Add(this.btnCargarExistencias);
            this.gbMantenimiento.Controls.Add(this.btnRefrescar);
            this.gbMantenimiento.Controls.Add(this.btnEliminar);
            this.gbMantenimiento.Controls.Add(this.btnActualizar);
            this.gbMantenimiento.Controls.Add(this.btnAgregar);
            this.gbMantenimiento.Location = new System.Drawing.Point(351, 13);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(157, 251);
            this.gbMantenimiento.TabIndex = 0;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimiento";
            // 
            // btnCargarExistencias
            // 
            this.btnCargarExistencias.Location = new System.Drawing.Point(20, 198);
            this.btnCargarExistencias.Name = "btnCargarExistencias";
            this.btnCargarExistencias.Size = new System.Drawing.Size(118, 23);
            this.btnCargarExistencias.TabIndex = 0;
            this.btnCargarExistencias.Text = "Cargar Existencias";
            this.btnCargarExistencias.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(20, 157);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(118, 23);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 114);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(20, 75);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(118, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbBusqueda.Controls.Add(this.btnBuscarGenero);
            this.gbBusqueda.Controls.Add(this.btnBuscarCodigo);
            this.gbBusqueda.Controls.Add(this.btnBuscarAutor);
            this.gbBusqueda.Controls.Add(this.btnBuscarTitulo);
            this.gbBusqueda.Location = new System.Drawing.Point(514, 13);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(145, 251);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.Location = new System.Drawing.Point(39, 187);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGenero.TabIndex = 0;
            this.btnBuscarGenero.Text = "Género";
            this.btnBuscarGenero.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(39, 42);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCodigo.TabIndex = 0;
            this.btnBuscarCodigo.Text = "Código";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Location = new System.Drawing.Point(39, 140);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAutor.TabIndex = 0;
            this.btnBuscarAutor.Text = "Autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(39, 93);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTitulo.TabIndex = 0;
            this.btnBuscarTitulo.Text = "Título";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(9, 271);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(650, 242);
            this.dgvDatos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 525);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbInformacionLibro);
            this.Name = "Form1";
            this.Text = " ";
            this.gbInformacionLibro.ResumeLayout(false);
            this.gbInformacionLibro.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.gbMantenimiento.ResumeLayout(false);
            this.gbBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacionLibro;
        private System.Windows.Forms.Label lblExistencias;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Button btnCargarExistencias;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarGenero;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}

