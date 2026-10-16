using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pruebasCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            //limpiarDatagridView();
            var listaX = new List<double>();
            var listaY = new List<double>();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;   // salta la fila vacía del final

                string textoX = fila.Cells[0].Value?.ToString();
                string textoY = fila.Cells[1].Value?.ToString();

                if (double.TryParse(textoX, NumberStyles.Any, CultureInfo.CurrentCulture, out double x) &&
                    double.TryParse(textoY, NumberStyles.Any, CultureInfo.CurrentCulture, out double y))
                {
                    listaX.Add(x);
                    listaY.Add(y);
                }
            }

            double[] columnaX = listaX.ToArray();
            double[] columnaY = listaY.ToArray();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Grafica Personalizada");

            Series listaPuntos = new Series("Puntos")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red
            };

            Series lp = new Series("LP")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.Blue
            };

            for (int i = 0; i < columnaX.Length; i++)
            {
                listaPuntos.Points.AddXY(columnaX[i], columnaY[i]);
                lp.Points.AddXY(columnaX[i], columnaY[i]);
            }

            chart1.Series.Add(listaPuntos);
            chart1.Series.Add(lp);

        }

        private void limpiarDatagridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Solo validar las columnas numéricas (0 y 1)
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1) return;

            // Si la celda está vacía, permitirlo (o cambia esto para exigir valor)
            string texto = e.FormattedValue?.ToString();
            if (string.IsNullOrWhiteSpace(texto))
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0; // Asignar valor predeterminado
                return;
            }
            if (!double.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, out _))
            {
                e.Cancel = true;   // impide salir de la celda
                MessageBox.Show("Ingresa un valor numérico válido.", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarDatagridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGraficarFuncion_Click(object sender, EventArgs e)
        {
            double valorA = double.Parse(txtA.Text);
            double valorB = double.Parse(txtB.Text);
            double valorC = double.Parse(txtC.Text);
            double minimo = double.Parse(txtMinimo.Text);
            double maximo = double.Parse(txtMaximo.Text);

            double cambioEnX = double.Parse(txtCambioX.Text);

            double xActual = minimo;

            List<double> listaX = new List<double>();
            List<double> listaY = new List<double>();

            while (xActual<= maximo)
            {
                double yActual = CalcularPuntoEnCurva(xActual, valorA, valorB, valorC);
                listaX.Add(xActual);
                listaY.Add(yActual);

                xActual += cambioEnX;
            }

            double[] columnaX = listaX.ToArray();
            double[] columnaY = listaY.ToArray();

            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Grafica Personalizada");

            Series listaPuntos = new Series("Puntos")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Red
            };

            Series lp = new Series("LP")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.Blue
            };

            for (int i = 0; i < columnaX.Length; i++)
            {
                listaPuntos.Points.AddXY(columnaX[i], columnaY[i]);
                lp.Points.AddXY(columnaX[i], columnaY[i]);
            }

            chart1.Series.Add(listaPuntos);
            chart1.Series.Add(lp);


        }

        //Calcular punto en la curva
        private double CalcularPuntoEnCurva(double x, double a, double b, double c)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

    }
}
