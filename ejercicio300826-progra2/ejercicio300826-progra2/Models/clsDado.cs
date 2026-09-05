using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio300826_progra2.Models
{
    internal class clsDado
    {
        //Atributos
        private int intValor;
        private static Random aleatorio = new Random();

        public int Generar()
        {
            
            intValor = aleatorio.Next(1, 6);
            return intValor;
        }
    }
}
