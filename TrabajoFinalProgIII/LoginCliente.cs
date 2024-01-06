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
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }

        private void btncerrarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnregistrarnu_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}
