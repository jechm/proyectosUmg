using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio300826_progra2.Models
{
    internal class clsJuego
    {
        //Atributos
        public clsDado dado1, dado2, dado3;

        //Constructor
        public clsJuego()
        {

            dado1 = new clsDado();
            dado2 = new clsDado();
            dado3 = new clsDado();

        }

        public void Lanzar(ref int pValor1, ref int pValor2, ref int pValor3)
        {
            pValor1 = dado1.Generar();
            pValor2 = dado2.Generar();
            pValor3 = dado3.Generar();
            MessageBox.Show($@"Los valores son:
dado 1 = {pValor1}
dado 2 = {pValor2}
dado 3 = {pValor3}");
        }

    }
}
