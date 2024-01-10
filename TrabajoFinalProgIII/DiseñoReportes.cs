using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TrabajoFinalProgIII
{
    public partial class DiseñoReportes : Form
    {
        public DiseñoReportes()
        {
            InitializeComponent();
        }

        private void btncerrarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DiseñoReportes_Load(object sender, EventArgs e)
        {
            //Vectores con los datos
            string[] series = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            int[] puntos = {74, 66, 98, 55, 93, 99, 45, 80, 90, 85, 78, 91};

            //cambiar combinacion de colores
            chart1.Palette = ChartColorPalette.Pastel;

            chart1.Titles.Add("Reporte mensual de trabajos");

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);

                //Cantidades
                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
