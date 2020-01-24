using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AutoReserva
{
    public partial class Clientes : Form
    {
        String Nombre = "";
        String Apellido = "";
        String Edad = "";
        String Direccion = "";
        String Nombref = "";
        String Apellidof = "";
        String Edadf = "";
        String Direccionf = "";
        int TelefonoCf = 0;
        String estadof = "";

        int Telefono = 0;
        int TelefonoC = 0;
        int indexx = 0;
        int nindexxx = 0;
        String estado = "";
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta");
        }

        private void btnResgitroF_Click(object sender, EventArgs e)
        {

            StreamWriter clientez = new StreamWriter("../../Archivos/Clientesss.txt", true);
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Direccion = txtDireccion.Text;
            Telefono = int.Parse(txtTelefono.Text);
            TelefonoC = int.Parse(txtTelefonoc.Text);
            Edad = cboxedad.Items[indexx].ToString();
            estado = cboxEstado.Items[nindexxx].ToString();
            Nombref = txtNombre.Text;
            Apellidof = txtApellido.Text;
            Direccionf = txtDireccion.Text;
            TelefonoCf = int.Parse(txtTelefonoc.Text);
            Edadf = cboxedad.Items[indexx].ToString();
            estadof = cboxEstado.Items[nindexxx].ToString();
            clientez.Write("Nombre:     ");
            clientez.WriteLine(Nombre);
            clientez.Write("Apellido:       ");
            clientez.WriteLine(Apellido);
            clientez.Write("Estado:     ");
            clientez.WriteLine(estado);
            clientez.Write("Direccion:      ");
            clientez.WriteLine(Direccion);
            clientez.Write("Edad:       ");
            clientez.WriteLine(Edad);
            clientez.Write("Telefono:       ");
            clientez.WriteLine(Telefono);
            clientez.Write("Celular:        ");
            clientez.WriteLine(TelefonoC);
            clientez.Close();

            txtNombre.Text = " ";
            txtApellido.Text = " ";
            txtDireccion.Text = " ";
            txtTelefono.Text = " ";
            txtTelefonoc.Text = " ";
            cboxedad.SelectedItem = 0;
            cboxedad.SelectedItem = 0;

            Fechas fechas = new Fechas();
            fechas.Show();
            this.Hide();

            //onsole.ReadKey();

            // System.IO.File.WriteAllText(clientez,String.Empty());tratandod e borrar datos del archivo 
        }


        private void cboxedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexx = cboxedad.SelectedIndex;
            //MessageBox.Show(indexx.ToString());
        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            nindexxx = cboxEstado.SelectedIndex;
            // MessageBox.Show(nindexxx.ToString());
        }

        private void Clientess_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AutosClientes autosC = new AutosClientes();
            autosC.Show();
            this.Hide();
        }
        private void txtTelefonoc_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == ""
                || txtDireccion.Text == "" || txtTelefono.Text == "" || txtTelefonoc.Text == "")
            {
                btnResgitroF.Enabled = false;
            }
            else
            {
                btnResgitroF.Enabled = true;
            }
        }
    }
}





