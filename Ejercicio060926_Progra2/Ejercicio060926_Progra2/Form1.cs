using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ejercicio060926_Progra2.Models;
using Ejercicio060926_Progra2.Services;

namespace Ejercicio060926_Progra2
{
    public partial class Form1 : Form
    {
        private clsManejadorLibros listadoLibros;
        
        public Form1()
        {
            InitializeComponent();
            listadoLibros = new clsManejadorLibros();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = listadoLibros.categorias;
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listadoLibros.ObtenerLibros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el libro: {ex.Message}");
            }
        }
    }
}
