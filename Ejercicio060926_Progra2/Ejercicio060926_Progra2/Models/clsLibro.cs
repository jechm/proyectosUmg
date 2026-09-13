using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio060926_Progra2.Models
{
    internal class clsLibro
    {

        //Atributos
        private string strCodigo;
        private string strTitulo;
        private string strAutor;
        private string strGenero;
        private int intExistencia;
        private int intEstado; // tambien puede ser un booleano 
        //en este caso se usa con valores enteros para permitir mas opciones

        //propiedades
        public string Codigo
        {
            get { return strCodigo; }
        }
        public string Titulo
        {
            get { return strTitulo; }
        }
        public string Autor
        {
            get { return strAutor; }
        }
        public string Genero
        {
            get { return strGenero; }
        }
        public int Existencias
        {
            get { return intExistencia; }
        }
        public int Estado
        {
            get { return intExistencia; }
        }

        //constructor
        public clsLibro(string pStrCodigo, string pStrTitulo, string pStrAutor, string pStrGenero)
        {
            this.strCodigo = pStrCodigo;
            this.strTitulo = pStrTitulo;
            this.strAutor = pStrAutor;
            this.strGenero = pStrGenero;
            this.intExistencia = 0;
            this.intEstado = 1;
        }

        public clsLibro(string pStrCodigo, string pStrTitulo, string pStrAutor, string pStrGenero, int pIntExistencias)
        {
            this.strCodigo = pStrCodigo;
            this.strTitulo = pStrTitulo;
            this.strAutor = pStrAutor;
            this.strGenero = pStrGenero;
            this.intExistencia = pIntExistencias;
            this.intEstado = 1;
        }

        public void Actualizar(string pCodigo,string pStrTitulo, string pStrAutor, string pStrGenero, int pIntExistencias, int pIntEstado)
        {
            this.strCodigo = pCodigo;
            this.strTitulo = pStrTitulo;
            this.strAutor = pStrAutor;
            this.strGenero = pStrGenero;
            this.intExistencia = pIntExistencias;
            this.intEstado = pIntEstado;
        }

    }
}
