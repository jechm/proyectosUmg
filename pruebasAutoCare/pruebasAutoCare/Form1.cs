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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string r = "";
           // solicitudPSW v = new solicitudPSW(ref r);
            //v.Show();
            
            if (r.Equals(""))
            {
                return;
            }

            textBox1.Text = r;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private IList<string> citas=new List<string>();
        
        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            formCitaNueva vCita = new formCitaNueva(ref citas);
            vCita.Show();
        }

        private void btnVerCitas_Click(object sender, EventArgs e)
        {
            int ultimaCita = citas.Count-1;

            MessageBox.Show($"ultima cita: {citas[ultimaCita]}");
        }
    }
}
