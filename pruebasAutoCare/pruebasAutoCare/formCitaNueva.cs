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
    public partial class formCitaNueva : Form
    {
        private IList<string> datos;
        public formCitaNueva(ref IList<string> datos)
        {
            InitializeComponent();
            this.datos = datos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            datos.Add(txtinfo.Text);
            this.Dispose();
        }

        private void formCitaNueva_Load(object sender, EventArgs e)
        {

        }
    }
}
