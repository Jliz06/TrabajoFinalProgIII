using System;
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
                txtObservacionesveh.Text =string.Empty;

                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            throw new NotImplementedException();
        }

        private void BTNBORRAveh_Click(object sender, EventArgs e)
        {
            int idABorrar;
            if (int.TryParse(txtidcliveh.Text, out idABorrar))
            {
                using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
                {
                    try
                    {
                        conexion.Open();
                        string consulta = "DELETE FROM TuTabla WHERE Id = @Id";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            comando.Parameters.AddWithValue("@Id", idABorrar);

                            int filasAfectadas = comando.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Registro borrado correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el registro con ese ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar borrar el registro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }
    }
}
    
