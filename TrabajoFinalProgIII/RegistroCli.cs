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

namespace TrabajoFinalProgIII
{
    public partial class RegistroCli : Form
    {
        public RegistroCli()
        {
            InitializeComponent();

            CargarDatos();

        }

        private void button2_Click(object sender, EventArgs e)
        {

         
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegistroCli_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNAGREGARCLI_Click(object sender, EventArgs e)
        {
            var ID = txtidcl.Text;
            var Nombre = txtnomcl.Text;
            var Telefono = txttelcli.Text;
            var MarcaVehiculo = txtmarcl.Text;
            var ModeloVehiculo = txtmodcl.Text;
            var Direccion = txtdoccl.Text;
            var Documento = txtdoccl.Text;
            var AnoVehiculo = txtanocl.Text;
            var PlacaVehiculo = txtplacl.Text;

            using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
            {
                conexion.Open();

                var query = $"INSERT INTO [dbo].[CLIENTE] (Nom_cli,Tele_cli,Dire_cli,Doc_cli,Marveh,Modveh,Anoveh,Plaveh) " + $"VALUES ('{Nombre}','{Telefono}','{MarcaVehiculo}','{ModeloVehiculo}','{Direccion}','{Documento}','{AnoVehiculo}','{AnoVehiculo}')";
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
                   
                    txtidcl.Text = "";
                    txtnomcl.Text = string.Empty;
                    txttelcli.Text = string.Empty;
                    txtmodcl.Text = string.Empty;
                    txtdircl.Text = string.Empty;
                    txtdoccl.Text = string.Empty;
                    txtplacl.Text = string.Empty;
                    txtanocl.Text = string.Empty;
                    txtmarcl.Text = string.Empty;

                    CargarDatos();
                }
            }
        }

        private void CargarDatos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
                {
                    conexion.Open();

                    string consulta = "SELECT [Nom_cli],[Tele_cli],[Dire_cli],[Doc_cli],[Marveh],[Modveh],[Anoveh],[Plaveh] FROM [MECHANIC-SOFT].[dbo].[CLIENTE]";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dtgvcli.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var form = new Panel123();
            form.Show();

            this.Hide();
        
    }

        private void BTNBORRARCLI_Click(object sender, EventArgs e)
        {
            // Obtener el valor del TextBox que contiene el ID que deseas borrar
            int idABorrar;
            if (int.TryParse(txtidcl.Text, out idABorrar))
            {
                // Crear la conexión
                using (SqlConnection conexion = new SqlConnection(@"Data Source = Lenovo\SQLEXPRESS; Initial Catalog = MECHANIC-SOFT; Integrated Security = True"))
                {
                    try
                    {
                        // Abrir la conexión
                        conexion.Open();

                        // Crear el comando SQL para borrar el registro
                        string consulta = "DELETE FROM CLIENTE WHERE Id = @Id";
                        using (SqlCommand comando = new SqlCommand(consulta, conexion))
                        {
                            // Agregar el parámetro
                            comando.Parameters.AddWithValue("@Id", idABorrar);

                            // Ejecutar la consulta
                            int filasAfectadas = comando.ExecuteNonQuery();

                            // Verificar si se borró el registro
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
