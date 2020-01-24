using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoReserva
{
    public partial class AutoReserva : Form
    {
        public AutoReserva()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AutosClientes autos_clientes = new AutosClientes();
            this.Hide();
            autos_clientes.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login sesion = new Login();
            sesion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Integrantes integrantes = new Integrantes();
            integrantes.Show();
        }
    }
}
