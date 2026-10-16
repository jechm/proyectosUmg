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
            RefrescarGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsLibro nuevoLibro = datosLibro();
                if(listadoLibros.BuscarLibroPorCodigo(nuevoLibro.Codigo) != null)
                {
                    MessageBox.Show("El libro ya existe en el listado");
                    return;
                }

                if (nuevoLibro == null) 
                {
                    MessageBox.Show("Los valores ingresados no son validos");
                    return;
                }
                listadoLibros.AgregarLibro(datosLibro());
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = listadoLibros.ObtenerLibros();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el libro: {ex.Message}");
            }
        }

        private clsLibro datosLibro()
        {
            clsLibro libro;

            
            if (!validarCampos())
            {
                int estado = 0;
                if (rbActivo.Checked)
                {
                    estado = 1;
                }
                libro= new clsLibro(txtCodigo.Text, txtTitulo.Text,txtAutor.Text,cmbGenero.Text,Convert.ToInt32(txtExistencias.Text),estado);
                return libro;

            }
            else
            {
                return null;
            }

            
        }

        private bool validarCampos()
        {
            return txtCodigo.Text.Equals("") || txtTitulo.Text.Equals("") || txtAutor.Text.Equals("") || cmbGenero.Text.Equals("");
        }

        private void limpiarControles()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            cmbGenero.SelectedItem = null;
            txtExistencias.Text = "";
            rbActivo.Checked= false;
            rbInactivo.Checked = false;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int estado = 0;

            if (rbActivo.Checked)
            {
                estado = 1;

                bool actualizado = listadoLibros.ActualizarLibro(
                    txtCodigo.Text,
                    txtTitulo.Text,
                    txtAutor.Text,
                    cmbGenero.Text,
                    Convert.ToInt32(txtExistencias.Text),
                    estado
                    );

                if (actualizado)
                {
                    RefrescarGrid();
                    MessageBox.Show("Libro actualizado correctamente");
                    limpiarControles();
                }
            }

            
        }

        private void RefrescarGrid()
        {

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listadoLibros.ObtenerLibros();

        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            clsLibro libroTemporal = listadoLibros.BuscarLibroPorCodigo(txtCodigo.Text);

            if (libroTemporal != null)
            {

                dgvDatos.DataSource = null;
                dgvDatos.DataSource = new List<clsLibro> { libroTemporal };
                AsignarValoresDeBusqueda(libroTemporal);

            }
            else
            {
                MessageBox.Show("No se encontro el codigo del libro");
                RefrescarGrid();
            }
        }
        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            clsLibro libroTemporal = listadoLibros.BuscarLibroPorNombre(txtTitulo.Text);
            if (libroTemporal != null)
            {
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = new List<clsLibro> { libroTemporal };
                AsignarValoresDeBusqueda(libroTemporal);
            }
            else
            {
                MessageBox.Show($"{txtTitulo.Text} no esta registrado en la biblioteca");
                RefrescarGrid();
            }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listadoLibros.BuscarLibroPorAutor(txtAutor.Text);
        }

        private void AsignarValoresDeBusqueda(clsLibro libroTemporal)
        {

            
            txtCodigo.Text = libroTemporal.Codigo;
            txtTitulo.Text = libroTemporal.Titulo;
            txtAutor.Text = libroTemporal.Autor;
            cmbGenero.Text = libroTemporal.Genero;
            txtExistencias.Text = libroTemporal.Existencias.ToString();
            if (libroTemporal.Estado == 1)
            {
                rbActivo.Checked = true;
            }
            else
            {
                rbInactivo.Checked = true;
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listadoLibros.EliminarLibro(txtCodigo.Text))
            {
                RefrescarGrid();
                limpiarControles();
                MessageBox.Show("Libro Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Libro no encontrado");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void btnCargarExistencias_Click(object sender, EventArgs e)
        {
            clsLibro libroTemporal = listadoLibros.BuscarLibroPorCodigo(txtCodigo.Text);
            if (libroTemporal == null)
            {
                MessageBox.Show("Libro no encontrado");
                
            }
            else
            {
                listadoLibros.CargarExistencias(txtCodigo.Text, Convert.ToInt32(txtExistencias.Text));

                MessageBox.Show("Existencias cargadas correctamente");
            }
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

        }

        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listadoLibros.BuscarLibroPorGenero(cmbGenero.Text);
        }
    }
}
