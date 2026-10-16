using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockUp_AutoCareRJ.Ventanas
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            foreach(Form hijo in this.MdiChildren)
            {
                if (hijo is frmClientes)
                {
                    hijo.Activate();
                    return;
                }
            }

            frmClientes ventanaClientes = new frmClientes();
            ventanaClientes.MdiParent = this;
           // ventanaClientes.WindowState = FormWindowState.Normal;
            ventanaClientes.Show();


        }
    }
}
