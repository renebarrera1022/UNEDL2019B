using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen3ParcialTaller
{
    public partial class Form1 : Form
    {
        private const string V = "{0}{1}{2}{3}{4}{5}{6}{7}{8}";
        private const string Format = V;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdicion_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCantidad.Enabled = true;
            txtSaldo.Enabled = true;
            txtDireccion.Enabled = true;
            dtNacimiento.Enabled = true;
            dtEjecucion.Enabled = true;
            rbtnConsulta.Enabled = true;
            rbtnDeposito.Enabled = true;
            rbtnFemenino.Enabled = true;
            rbtnMasculino.Enabled = true;
            rbtnOtro.Enabled = true;
            rbtnRetiro.Enabled = true;
            btnCancelar.Enabled = true;
            btnEjecutar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCantidad.Text = "";
            txtSaldo.Text = "";
            txtDireccion.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnOtro.Checked = false;
            rbtnDeposito.Checked = false;
            rbtnRetiro.Checked = false;
            rbtnConsulta.Checked = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCantidad.Enabled = false;
            txtSaldo.Enabled = false;
            txtDireccion.Enabled = false;
            dtNacimiento.Enabled = false;
            dtEjecucion.Enabled = false;
            rbtnConsulta.Enabled = false;
            rbtnDeposito.Enabled = false;
            rbtnFemenino.Enabled = false;
            rbtnMasculino.Enabled = false;
            rbtnOtro.Enabled = false;
            rbtnRetiro.Enabled = false;
            btnCancelar.Enabled = false;
            btnEjecutar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCantidad.Text = "";
            txtSaldo.Text = "";
            txtDireccion.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnOtro.Checked = false;
            rbtnDeposito.Checked = false;
            rbtnRetiro.Checked = false;
            rbtnConsulta.Checked = false;
        }
        public string radioNacimiento()
        {
            if (rbtnFemenino.Checked)
            {
                return "Fermenino";
            }else if (rbtnMasculino.Checked)
            {
                return "Masculino";
            }
            else
            {
                return "Otro";
            }
            
        }
        public string radioEjecutar()
        {
            if (rbtnDeposito.Checked)
            {
                return "Deposito";
            }else if (rbtnRetiro.Checked)
            {
                return "Retiro";
            }
            else
            {
                return "Consulta";
            }
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("../../ExamenFinal.txt"))
            {
                writer.WriteLine(string.Format(
                    Format,
                   txtNombre.Text + ", ",
                   txtApellido.Text + ", ",
                   dtNacimiento.Value + ", ",
                   txtDireccion.Text + ", ",
                   radioNacimiento() + ", ",
                   txtCantidad.Text + ", ",
                   txtSaldo.Text + ", ",
                   dtEjecucion.Value + ", ",
                   radioEjecutar()
                   ));
            }
        }
    }
}
