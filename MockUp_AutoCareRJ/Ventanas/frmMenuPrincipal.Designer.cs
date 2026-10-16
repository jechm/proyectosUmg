namespace MockUp_AutoCareRJ.Ventanas
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.tbCtrlMenu = new System.Windows.Forms.TabControl();
            this.tbPgConfiguracionYMantenimiento = new System.Windows.Forms.TabPage();
            this.tbPgTransacciones = new System.Windows.Forms.TabPage();
            this.tbPgConsultasYReportes = new System.Windows.Forms.TabPage();
            this.pnlContenedorMenu = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnRepuestos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbCtrlMenu.SuspendLayout();
            this.tbPgConfiguracionYMantenimiento.SuspendLayout();
            this.pnlContenedorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCtrlMenu
            // 
            this.tbCtrlMenu.Controls.Add(this.tbPgConfiguracionYMantenimiento);
            this.tbCtrlMenu.Controls.Add(this.tbPgTransacciones);
            this.tbCtrlMenu.Controls.Add(this.tbPgConsultasYReportes);
            resources.ApplyResources(this.tbCtrlMenu, "tbCtrlMenu");
            this.tbCtrlMenu.Multiline = true;
            this.tbCtrlMenu.Name = "tbCtrlMenu";
            this.tbCtrlMenu.SelectedIndex = 0;
            // 
            // tbPgConfiguracionYMantenimiento
            // 
            this.tbPgConfiguracionYMantenimiento.Controls.Add(this.btnEmpleados);
            this.tbPgConfiguracionYMantenimiento.Controls.Add(this.btnRepuestos);
            this.tbPgConfiguracionYMantenimiento.Controls.Add(this.btnServicios);
            this.tbPgConfiguracionYMantenimiento.Controls.Add(this.btnVehiculos);
            this.tbPgConfiguracionYMantenimiento.Controls.Add(this.btnClientes);
            resources.ApplyResources(this.tbPgConfiguracionYMantenimiento, "tbPgConfiguracionYMantenimiento");
            this.tbPgConfiguracionYMantenimiento.Name = "tbPgConfiguracionYMantenimiento";
            this.tbPgConfiguracionYMantenimiento.UseVisualStyleBackColor = true;
            // 
            // tbPgTransacciones
            // 
            resources.ApplyResources(this.tbPgTransacciones, "tbPgTransacciones");
            this.tbPgTransacciones.Name = "tbPgTransacciones";
            this.tbPgTransacciones.UseVisualStyleBackColor = true;
            // 
            // tbPgConsultasYReportes
            // 
            resources.ApplyResources(this.tbPgConsultasYReportes, "tbPgConsultasYReportes");
            this.tbPgConsultasYReportes.Name = "tbPgConsultasYReportes";
            this.tbPgConsultasYReportes.UseVisualStyleBackColor = true;
            // 
            // pnlContenedorMenu
            // 
            resources.ApplyResources(this.pnlContenedorMenu, "pnlContenedorMenu");
            this.pnlContenedorMenu.Controls.Add(this.tbCtrlMenu);
            this.pnlContenedorMenu.Name = "pnlContenedorMenu";
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::MockUp_AutoCareRJ.Properties.Resources.clientes;
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackgroundImage = global::MockUp_AutoCareRJ.Properties.Resources.vehiculos;
            resources.ApplyResources(this.btnVehiculos, "btnVehiculos");
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            this.btnServicios.BackgroundImage = global::MockUp_AutoCareRJ.Properties.Resources.servicios;
            resources.ApplyResources(this.btnServicios, "btnServicios");
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.BackgroundImage = global::MockUp_AutoCareRJ.Properties.Resources.repuestos;
            resources.ApplyResources(this.btnRepuestos, "btnRepuestos");
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = global::MockUp_AutoCareRJ.Properties.Resources.empleados;
            resources.ApplyResources(this.btnEmpleados, "btnEmpleados");
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContenedorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.tbCtrlMenu.ResumeLayout(false);
            this.tbPgConfiguracionYMantenimiento.ResumeLayout(false);
            this.pnlContenedorMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCtrlMenu;
        private System.Windows.Forms.TabPage tbPgConfiguracionYMantenimiento;
        private System.Windows.Forms.TabPage tbPgTransacciones;
        private System.Windows.Forms.TabPage tbPgConsultasYReportes;
        private System.Windows.Forms.Panel pnlContenedorMenu;
        private System.Windows.Forms.Button btnRepuestos;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.ImageList imageList1;
    }
}