using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalProgIII
{
    public partial class Panel123 : Form
    {
        public Panel123()
        {
            InitializeComponent();
        }

        private void btnReportesMenu_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btncerrarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReportesMenu_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnEmpleadoMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form Form2 = new RegistroCli();
            Form2.TopLevel = true;
            Form2.Show();

            this.Hide();

        }

        private void btEntrarMenu_Click(object sender, EventArgs e)
        {
            Form Form1 = new LoginUsuario();
           
            Form1.TopLevel = true;
            Form1.Show();

            this.Hide();

        }

        private void btnRegistroMenu_Click(object sender, EventArgs e)
        {
            Form NuevoUsuario = new NuevoUsuario();
            NuevoUsuario.TopLevel = true;
            NuevoUsuario.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Loginusuario = new LoginUsuario();
            Loginusuario.TopLevel = true;
            Loginusuario.Show();

            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form form = new StatusVehiculo();
            form.TopLevel = true;
            form.Show();

            this.Hide();
        }
     

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Form form = new RegistroCli();
            form.TopLevel = true;
            form.Show();

            this.Hide();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            Form form = new Reportes();
            form.TopLevel = true;
            form.Show();

            this.Hide();
        }

        private void btnregistrarnu_Click(object sender, EventArgs e)
        {
            Form form = new NuevoUsuario();
            form.TopLevel = true;
            form.Show();

            this.Hide();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {

        }

        private void btnregistroveh_Click(object sender, EventArgs e)
        {
            Form form = new Reportes();
            form.TopLevel = true;
            form.Show();

            this.Hide();
        }
    }
}
