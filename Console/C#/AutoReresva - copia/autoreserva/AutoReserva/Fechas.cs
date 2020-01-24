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

namespace AutoReserva
{
    public partial class Fechas : Form
    {
        private const string V = "{0}";
        private const string Format = V;
        AutosClientes ac = new AutosClientes();
        Clientes clientes = new Clientes();
        Registro reg = new Registro();
        public Fechas()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Fechas_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime inicio_f = fechaInicio.Value;
            DateTime fin_f = fechaFin.Value;
            TimeSpan dif = fin_f - inicio_f;
            int dias = dif.Days;
            int aux = 0;
            if (dias <= 0)
            {
                textBox1.Text += "Error al elegir los días\n";
                aux = 1;
            }
            else if( dias < 6)
            {
                textBox1.Text = "Días de renta: " + dif.ToString() + "\nMonto a pagar: $2500";
            }
            else
            {
                textBox1.Text = "Días de renta: " + dif.ToString() + "\nMonto a pagar: $4800";
            }
            if (aux != 1)
            {
                btnConfirmar.Enabled = true;
            }

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string auto;
            auto = ac.ObtenerCarro();
            StreamWriter fecha = new StreamWriter("../../Archivos/Clientesss.txt", true);
            fecha.WriteLine(textBox1.Text);
            fecha.Write("\n####################################\n\n");
            fecha.Close();
            reg.leerArchivo();
            reg.Show();
            this.Hide();
        }
    }
}
