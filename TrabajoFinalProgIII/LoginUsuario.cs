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

                SqlConnection conn = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True");
            String usuario, pass;

            usuario = txtBoxUsuariolg.Text;
            pass = txtBoxContrasenalg.Text;
            try
            {
                conn.Open();
                String query = "Select * from [Usuarios] where NombreUsuario = '" + usuario + "' and  Contraseña = '" + pass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    usuario = txtBoxUsuariolg.Text;
                    pass = txtBoxContrasenalg.Text;

                    
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña no válidos");
                    txtBoxUsuariolg.Clear();
                    txtBoxContrasenalg.Clear();

                    txtBoxUsuariolg.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnregistrarnu_Click(object sender, EventArgs e)
        {
            Form form = new NuevoUsuario();
            form.Show();
        }

        private void btnLimpiarlg_Click(object sender, EventArgs e)
        {
            txtBoxContrasenalg.Text = "";
            txtBoxUsuariolg.Text = "";
            
        }
    }
}
