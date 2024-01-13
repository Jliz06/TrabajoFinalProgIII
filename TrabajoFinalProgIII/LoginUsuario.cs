using System;
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
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var usuario = txtBoxUsuariolg.Text;
            var pass = txtBoxContrasenalg.Text;

            try
            {
                var query = $"Select count(*) from [USUARIOS] where lower(usuario) = '{usuario.ToLower()}' and lower(pass) = '{pass.ToLower()}'";

                using (var conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
                {
                    conexion.Open();

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        int existe = (int)command.ExecuteScalar();

                        if (existe > 0)
                        {
                            var formulario = new Panel123();
                            formulario.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("clave incorrecta");
                        }
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiarlg_Click(object sender, EventArgs e)
        {
            txtBoxContrasenalg.Text = "";
            txtBoxUsuariolg.Text = "";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtBoxContrasenalg.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxContrasenalg.UseSystemPasswordChar = false;
            }
        }
    }
}
