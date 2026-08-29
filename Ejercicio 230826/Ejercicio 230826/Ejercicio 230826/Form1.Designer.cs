namespace Ejercicio_230826
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.nudExistencias = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbProductos = new System.Windows.Forms.GroupBox();
            this.btnProducto5 = new System.Windows.Forms.Button();
            this.btnProducto4 = new System.Windows.Forms.Button();
            this.btnProducto3 = new System.Windows.Forms.Button();
            this.btnProducto2 = new System.Windows.Forms.Button();
            this.btnProducto1 = new System.Windows.Forms.Button();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.gpbBotones.SuspendLayout();
            this.gpbProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbDatos.Controls.Add(this.cmbCategoria);
            this.gpbDatos.Controls.Add(this.nudExistencias);
            this.gpbDatos.Controls.Add(this.nudPrecio);
            this.gpbDatos.Controls.Add(this.txtDescripcion);
            this.gpbDatos.Controls.Add(this.txtCodigo);
            this.gpbDatos.Controls.Add(this.label5);
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(13, 13);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(362, 339);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "DATOS PRODUCTOS";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(177, 235);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 26);
            this.cmbCategoria.TabIndex = 5;
            // 
            // nudExistencias
            // 
            this.nudExistencias.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExistencias.Location = new System.Drawing.Point(177, 192);
            this.nudExistencias.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExistencias.Name = "nudExistencias";
            this.nudExistencias.Size = new System.Drawing.Size(121, 27);
            this.nudExistencias.TabIndex = 4;
            this.nudExistencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExistencias.Enter += new System.EventHandler(this.nudExistencias_Enter);
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecio.Location = new System.Drawing.Point(177, 151);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(121, 27);
            this.nudPrecio.TabIndex = 3;
            this.nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrecio.Enter += new System.EventHandler(this.nudPrecio_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(177, 105);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 27);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(177, 62);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 27);
            this.txtCodigo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // gpbBotones
            // 
            this.gpbBotones.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbBotones.Controls.Add(this.btnGuardar);
            this.gpbBotones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBotones.Location = new System.Drawing.Point(13, 359);
            this.gpbBotones.Name = "gpbBotones";
            this.gpbBotones.Size = new System.Drawing.Size(362, 52);
            this.gpbBotones.TabIndex = 1;
            this.gpbBotones.TabStop = false;
            this.gpbBotones.Text = "OPCIONES";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(263, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 31);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbProductos
            // 
            this.gpbProductos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gpbProductos.Controls.Add(this.btnProducto5);
            this.gpbProductos.Controls.Add(this.btnProducto4);
            this.gpbProductos.Controls.Add(this.btnProducto3);
            this.gpbProductos.Controls.Add(this.btnProducto2);
            this.gpbProductos.Controls.Add(this.btnProducto1);
            this.gpbProductos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbProductos.Location = new System.Drawing.Point(382, 13);
            this.gpbProductos.Name = "gpbProductos";
            this.gpbProductos.Size = new System.Drawing.Size(227, 398);
            this.gpbProductos.TabIndex = 2;
            this.gpbProductos.TabStop = false;
            this.gpbProductos.Text = "PRODUCTOS";
            // 
            // btnProducto5
            // 
            this.btnProducto5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto5.Location = new System.Drawing.Point(18, 330);
            this.btnProducto5.Name = "btnProducto5";
            this.btnProducto5.Size = new System.Drawing.Size(191, 32);
            this.btnProducto5.TabIndex = 4;
            this.btnProducto5.Text = "Producto 5";
            this.btnProducto5.UseVisualStyleBackColor = true;
            this.btnProducto5.Click += new System.EventHandler(this.btnProducto5_Click);
            // 
            // btnProducto4
            // 
            this.btnProducto4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto4.Location = new System.Drawing.Point(18, 258);
            this.btnProducto4.Name = "btnProducto4";
            this.btnProducto4.Size = new System.Drawing.Size(191, 32);
            this.btnProducto4.TabIndex = 3;
            this.btnProducto4.Text = "Producto 4";
            this.btnProducto4.UseVisualStyleBackColor = true;
            this.btnProducto4.Click += new System.EventHandler(this.btnProducto4_Click);
            // 
            // btnProducto3
            // 
            this.btnProducto3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto3.Location = new System.Drawing.Point(18, 178);
            this.btnProducto3.Name = "btnProducto3";
            this.btnProducto3.Size = new System.Drawing.Size(191, 32);
            this.btnProducto3.TabIndex = 2;
            this.btnProducto3.Text = "Producto 3";
            this.btnProducto3.UseVisualStyleBackColor = true;
            this.btnProducto3.Click += new System.EventHandler(this.btnProducto3_Click);
            // 
            // btnProducto2
            // 
            this.btnProducto2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto2.Location = new System.Drawing.Point(18, 103);
            this.btnProducto2.Name = "btnProducto2";
            this.btnProducto2.Size = new System.Drawing.Size(191, 32);
            this.btnProducto2.TabIndex = 1;
            this.btnProducto2.Text = "Producto 2";
            this.btnProducto2.UseVisualStyleBackColor = true;
            this.btnProducto2.Click += new System.EventHandler(this.btnProducto2_Click);
            // 
            // btnProducto1
            // 
            this.btnProducto1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto1.Location = new System.Drawing.Point(18, 35);
            this.btnProducto1.Name = "btnProducto1";
            this.btnProducto1.Size = new System.Drawing.Size(191, 32);
            this.btnProducto1.TabIndex = 0;
            this.btnProducto1.Text = "Producto 1";
            this.btnProducto1.UseVisualStyleBackColor = true;
            this.btnProducto1.Click += new System.EventHandler(this.btnProducto1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 423);
            this.Controls.Add(this.gpbProductos);
            this.Controls.Add(this.gpbBotones);
            this.Controls.Add(this.gpbDatos);
            this.Name = "Form1";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.gpbBotones.ResumeLayout(false);
            this.gpbProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.GroupBox gpbBotones;
        private System.Windows.Forms.GroupBox gpbProductos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.NumericUpDown nudExistencias;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProducto4;
        private System.Windows.Forms.Button btnProducto3;
        private System.Windows.Forms.Button btnProducto2;
        private System.Windows.Forms.Button btnProducto1;
        private System.Windows.Forms.Button btnProducto5;
    }
}

