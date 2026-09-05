namespace ejercicio300826_progra2
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
            this.pbDado1 = new System.Windows.Forms.PictureBox();
            this.pbDado2 = new System.Windows.Forms.PictureBox();
            this.pbDado3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDado1
            // 
            this.pbDado1.Image = global::ejercicio300826_progra2.Properties.Resources.dadoL1;
            this.pbDado1.Location = new System.Drawing.Point(11, 11);
            this.pbDado1.Margin = new System.Windows.Forms.Padding(2);
            this.pbDado1.Name = "pbDado1";
            this.pbDado1.Size = new System.Drawing.Size(139, 133);
            this.pbDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado1.TabIndex = 0;
            this.pbDado1.TabStop = false;
            // 
            // pbDado2
            // 
            this.pbDado2.Image = global::ejercicio300826_progra2.Properties.Resources.dadoL2;
            this.pbDado2.Location = new System.Drawing.Point(176, 11);
            this.pbDado2.Margin = new System.Windows.Forms.Padding(2);
            this.pbDado2.Name = "pbDado2";
            this.pbDado2.Size = new System.Drawing.Size(139, 133);
            this.pbDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado2.TabIndex = 1;
            this.pbDado2.TabStop = false;
            // 
            // pbDado3
            // 
            this.pbDado3.Image = global::ejercicio300826_progra2.Properties.Resources.dadoL3;
            this.pbDado3.Location = new System.Drawing.Point(341, 11);
            this.pbDado3.Margin = new System.Windows.Forms.Padding(2);
            this.pbDado3.Name = "pbDado3";
            this.pbDado3.Size = new System.Drawing.Size(139, 133);
            this.pbDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado3.TabIndex = 2;
            this.pbDado3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(11, 193);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(469, 40);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 259);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDado3);
            this.Controls.Add(this.pbDado2);
            this.Controls.Add(this.pbDado1);
            this.Location = new System.Drawing.Point(1200, 300);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDado1;
        private System.Windows.Forms.PictureBox pbDado2;
        private System.Windows.Forms.PictureBox pbDado3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJugar;
    }
}

