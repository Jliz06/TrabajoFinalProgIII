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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
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
            SubmenuReportes.Visible = true;
        }

        private void btnEmpleadoMenu_Click(object sender, EventArgs e)
        {
            SubMenuEmpleado.Visible = true;
        }

        private void btnClientesMenu_Click(object sender, EventArgs e)
        {
            SubMenuCliente.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void btEntrarMenu_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
        }

        private void btnRegistroMenu_Click(object sender, EventArgs e)
        {
            Form NuevoUsuario = new NuevoUsuario();
            NuevoUsuario.Show();
        }
    }
}
