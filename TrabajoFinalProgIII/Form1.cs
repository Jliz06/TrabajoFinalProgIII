﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TrabajoFinalProgIII
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

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

                SqlConnection conn = new SqlConnection(@"Data Source = EVENSON\SQLEXPRESS; Initial Catalog = HeladeriaJJE; Integrated Security = True");
            String usuario, contraseña;

            usuario = txtBoxUsuario.Text;
            contraseña = txtBoxContraseña.Text;
            try
            {
                conn.Open();
                String query = "Select * from [Usuarios] where NombreUsuario = '" + usuario + "' and  Contraseña = '" + contraseña + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    usuario = txtBoxUsuario.Text;
                    contraseña = txtBoxContraseña.Text;

                    Sistema_de_venta inicio = new Sistema_de_venta();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña no válidos");
                    txtBoxUsuario.Clear();
                    txtBoxContraseña.Clear();

                    txtBoxUsuario.Focus();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
