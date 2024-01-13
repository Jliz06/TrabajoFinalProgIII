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
    public partial class StatusVehiculo : Form
    {
        public StatusVehiculo()
        {
            InitializeComponent();
        }

        private void btncerrarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNVERSTATUS_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new MenuPrincipal();
            form.Show();
        }
    }
}
