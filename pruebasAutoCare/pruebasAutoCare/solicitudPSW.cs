using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebasAutoCare
{
    public partial class solicitudPSW : Form
    {
        private string respuesta;
        //private string respuesta;
        public solicitudPSW()
        {
            
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            respuesta = textBox1.Text;
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
