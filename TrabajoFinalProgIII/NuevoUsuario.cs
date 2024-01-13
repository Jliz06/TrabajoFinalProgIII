using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrabajoFinalProgIII
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnhomenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclosenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnguardarnu_Click(object sender, EventArgs e)
        {
            var nombre = txtnombreu.Text;
            var usuario = txtusernu.Text;
            var pass = txtcontrasenanu.Text;

            using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
            {
                conexion.Open();

                var query = $"INSERT INTO [dbo].[USUARIOS] (nombre,usuario,pass) VALUES ('{nombre}', '{usuario.ToLower()}', '{pass.ToLower()}')";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    int guardado = comando.ExecuteNonQuery();

                    if (guardado > 0)
                    {
                        MessageBox.Show("Usuario guardado");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no guardado");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Panel123();
            form.Show();

            this.Hide();
        }
    }
}
