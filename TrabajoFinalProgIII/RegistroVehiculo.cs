﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TrabajoFinalProgIII
{
    public partial class RegistroVehiculo : Form
    {
        private SqlConnection conexion;

        public RegistroVehiculo()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new MenuPrincipal();
            form.ShowDialog();
        }

        private void BTNAGREGARCLI_Click(object sender, EventArgs e)
        {
            var ID = txtidcliveh.Text;
            var Observaciones = txtObservacionesveh.Text;

            using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
            {
                conexion.Open();

            }
            var query = $"INSERT INTO [dbo].[REPORTAR] (IDCLIENTE,Observaciones) " + $"VALUES ('{ID}','{Observaciones}')";
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                int guardado = comando.ExecuteNonQuery();

                if (guardado > 0)
                {
                    MessageBox.Show("Datos guardado");
                }
                else
                {
                    MessageBox.Show("Datos no guardado");
                }

                txtidcliveh.Text = string.Empty;
                txtObservacionesveh.Text = string.Empty;

                CargarDatos();
            }
        }

        private void CargarDatos()
        {
           
        }
    }
}
    
