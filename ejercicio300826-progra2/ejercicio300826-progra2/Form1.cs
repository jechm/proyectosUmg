using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ejercicio300826_progra2.Models;


namespace ejercicio300826_progra2
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void btnJugar_Click(object sender, EventArgs e)
        {
            int valor1=0, valor2 = 0, valor3 = 0;
            
            //pbDado1.f
            clsJuego juego = new clsJuego();
            if (btnJugar.Text.Equals("JUGAR"))
            {

                iniciarAnimacion();
                juego.Lanzar(ref valor1, ref valor2, ref valor3);
                btnJugar.Text = "DETENER";
            }
            else
            {
                asignarResultados(valor1, valor2, valor3);
                MessageBox.Show($@"Los valores son:
dado 1 = {valor1}
dado 2 = {valor2}
dado 3 = {valor3}");
                btnJugar.Text = "JUGAR";
            }


        }

        private void asignarResultados(int valor1, int valor2, int valor3)
        {
          //  Thread.Sleep(15000);
            Image[] n = { 
                Properties.Resources.dadoL1, 
                Properties.Resources.dadoL2, 
                Properties.Resources.dadoL3, 
                Properties.Resources.dadoL4, 
                Properties.Resources.dadoL5, 
                Properties.Resources.dadoL6 };


            pbDado1.Image = n[valor1];
            pbDado2.Image = n[valor2];
            pbDado3.Image = n[valor3];
        }

        private void iniciarAnimacion()
        {
            pbDado1.Image = Properties.Resources.animacionDado;
            pbDado2.Image = Properties.Resources.animacionDado;
            pbDado3.Image = Properties.Resources.animacionDado;
        }
    }
}
