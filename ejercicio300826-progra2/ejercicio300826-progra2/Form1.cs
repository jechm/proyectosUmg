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
using ejercicio300826_progra2.Properties;


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

        private int valor1 = 0, valor2 = 0, valor3 = 0;
        private Image[] n = {
                Resources.dadoL1,
                Resources.dadoL2,
                Resources.dadoL3,
                Resources.dadoL4,
                Resources.dadoL5,
                Resources.dadoL6 };

        private async void btnJugar_Click(object sender, EventArgs e)
        {
            
            
            //pbDado1.f
            clsJuego juego = new clsJuego();
            iniciarAnimacion();
            juego.Lanzar(ref valor1, ref valor2, ref valor3);
            Random a = new Random();
            await Task.Delay(a.Next(100,2000));
            pbDado1.Image = n[valor1-1];
            await Task.Delay(a.Next(100, 2000));
            pbDado2.Image = n[valor2 - 1];
            await Task.Delay(a.Next(100, 2000));
            pbDado3.Image = n[valor3 - 1];

           // await Task.Delay(1000);
            if (valor1== valor2 && valor2 == valor3)
            {
                lblResultado.Text = "JUEGO GANADO";
                lblResultado.ForeColor = Color.Green;
            }
            else
            {
                lblResultado.Text = "JUEGO PERDIDO";
                lblResultado.ForeColor= Color.Red;
            }

        }



        //iniciar animación
        private void iniciarAnimacion()
        {
            pbDado1.Image = Resources.animacionDado;
            pbDado2.Image = Resources.animacionDado;
            pbDado3.Image = Resources.animacionDado;
        }
    }
}
