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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn__Login_Click(object sender, EventArgs e)
        {
            if (textBox_Usuario.Text == "Admin" && textBox_Clave.Text == "admin")
            {
                Autos autos = new Autos();
                autos.Show();
                this.Hide();
                AutoReserva inicio = new AutoReserva();
                inicio.Hide();
            }
            else
            {
                Error error = new Error();
                error.Show();
                this.Hide();
            }
        }

        private void textBox_Clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
