using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MockUp_AutoCareRJ.Ventanas;

namespace MockUp_AutoCareRJ
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Clear();
                txtUsuario.ForeColor = Color.Black;
            }
        }



        private void iniciarContrasenia()
        {
            if (txtContrasenia.Text == "Contraseña")
            {
                txtContrasenia.Clear();
                txtContrasenia.ForeColor = Color.Black;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            iniciarContrasenia();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtContrasenia.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
