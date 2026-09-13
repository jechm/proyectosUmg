using Ejercicio060926_Progra2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio060926_Progra2.Services
{
    internal class clsManejadorLibros
    {

        private List<clsLibro> libros;
        public List<string> categorias;

        public clsManejadorLibros() 
        {
            libros = new List<clsLibro>();
            categorias = new List<string> { "Ficción", "Ciencia", "Historia", "Aventura", "Terror", "Comedia" };
        }

        //Almacenar Libros
        public void AgregarLibro (clsLibro pLibro)
        {
            libros.Add(pLibro);
        }

        //Recuperar los libros almacenado
        public List<clsLibro> ObtenerLibros()
        {
            return libros;
        }

        //REcuperar un libro por codigo
        public clsLibro BuscarLibro(string pCodigo)
        {
            return libros.FirstOrDefault(l => l.Codigo.Equals(pCodigo, StringComparison.OrdinalIgnoreCase));
            //StringComparison.OrdinalIgnoreCase -> es para que sea Case Insensitive

        }

        public bool ActualizarLibro(string pCodigo, string pTitulo, string pAutor, string pGenero, int pExistencias, int pEstado)
        {
            clsLibro libroTemp = BuscarLibro(pCodigo);

            if (libroTemp == null)
            {
                return false;
            }

            libroTemp.Actualizar(pCodigo, pTitulo, pAutor,pGenero,pExistencias, pEstado);

            return true;

        }

        //Delete - Eliminar
        public bool EliminarLibro(string pCodigo)
        {
            clsLibro libroTemp = BuscarLibro(pCodigo);
            if(libroTemp == null)
            {
                return false;
            }

            libros.Remove(libroTemp);
            return true;
        }
    }
}
