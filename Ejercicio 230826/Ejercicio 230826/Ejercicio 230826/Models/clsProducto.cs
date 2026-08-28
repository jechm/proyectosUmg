using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_230826.Models
{
    internal class clsProducto
    {

        #region ATRIBUTOS
        private string strCodigo;
        private string strDescripcion;
        private double dblPrecio;
        private int intExistencias;
        private string strCategoria;
        #endregion

        #region Propiedades
        public string Codigo
        {
            get
            {
                return strCodigo;
            }
        }

        public string Descripcion
        {
            get
            {
                return strDescripcion;
            }
        }

        public double Precio
        {
            get
            {
                return dblPrecio;
            }
        }

        public int Existencias
        {

            get
            {
                return intExistencias;
            }
        }

        public string Categoria
        {
            get
            {
                return strCategoria;
            }
        }
        #endregion

        //Constructor
        public clsProducto(
            string pCodigo, 
            string pDescripcion, 
            double pPrecio, 
            int pExistencias,
            string pCategoria
            )
        {
            this.strCodigo = pCodigo;
            this.strDescripcion = pDescripcion;
            this.dblPrecio = pPrecio;
            this.intExistencias = pExistencias;
            this.strCategoria = pCategoria;
        }

        #region METODOS

        

        #endregion

    }
}
