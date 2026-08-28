using Ejercicio_230826.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_230826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private clsProducto[] Inventario = new clsProducto[5];
        private int intContador = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool datosValidos = validarComponentes();


            if (datosValidos) 
            {
                Inventario[intContador]= new clsProducto
                    (
                    txtCodigo.Text, 
                    txtDescripcion.Text,
                    Convert.ToDouble(nudPrecio.Value),
                    Convert.ToInt32(nudExistencias.Value),
                    cmbCategoria.Text
                    );
                modificarBotonProducto();
                limpiarFormulario();
                intContador++;
                txtCodigo.Select();
            }

        }

        private void limpiarFormulario()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            nudPrecio.Value = 0;
            nudExistencias.Value = 0;
            cmbCategoria.SelectedItem = null;
        }

        //Cambiar el nombre del boton Producto al nombre del producto ingresado
        private void modificarBotonProducto()
        {
            switch (intContador)
            {
                case 0:
                    btnProducto1.Text = Inventario[intContador].Descripcion;
                    break;
                case 1:
                    btnProducto2.Text = Inventario[intContador].Descripcion;
                    break;
                case 2:
                    btnProducto3.Text = Inventario[intContador].Descripcion;
                    break;
                case 3:
                    btnProducto4.Text = Inventario[intContador].Descripcion;
                    break;
                case 4:
                    btnProducto5.Text = Inventario[intContador].Descripcion;
                    break;
            }
        }

        //validar que todos los campos contengan valores validos
        private bool validarComponentes()
        {
            if (txtCodigo.Text.Equals("") || txtDescripcion.Text.Equals("") || nudPrecio.Value==0 || cmbCategoria.SelectedItem == null )
            {
                MessageBox.Show("Asegurese de llenar todos los campos", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }


        //Llenar combo box de  categorias
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] categorias = { "Comestibles", "Bebidas", "Electronicos", "Limpieza", "Herramientas" };

            foreach (string categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria);
            }
        }

        #region RECUPERAR INFORMACION
        //Recuperar informacion del inventario
        private void recuperarInformacion(int pIndice)
        {
            clsProducto productoRecuperado = Inventario[pIndice-1];
            txtCodigo.Text = productoRecuperado.Codigo;
            txtDescripcion.Text = productoRecuperado.Descripcion;
            nudPrecio.Value = Convert.ToDecimal(productoRecuperado.Precio);
            nudExistencias.Value = Convert.ToInt32(productoRecuperado.Existencias);
            cmbCategoria.Text = productoRecuperado.Categoria;
        }

        //Recuperar informacion segun boton presionado
        private void btnProducto1_Click(object sender, EventArgs e)
        {
            recuperarInformacion(1);
        }

        private void btnProducto2_Click(object sender, EventArgs e)
        {
            recuperarInformacion(2);
        }

        private void btnProducto3_Click(object sender, EventArgs e)
        {
            recuperarInformacion(3);
        }

        private void btnProducto4_Click(object sender, EventArgs e)
        {
            recuperarInformacion(4);
        }

        private void btnProducto5_Click(object sender, EventArgs e)
        {
            recuperarInformacion(5);
        }
        #endregion

        private void nudPrecio_Enter(object sender, EventArgs e)
        {
            nudPrecio.Select(0, nudPrecio.Value.ToString().Length+3);
        }

        private void nudExistencias_Enter(object sender, EventArgs e)
        {
            nudExistencias.Select(0, nudExistencias.Value.ToString().Length);
        }
    }
}
