using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoReserva
{
    public partial class Registro : Form
    {
        private List<string> clientes = new List<string>();
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
        public void leerArchivo()
        {
            using (StreamReader leer = new StreamReader(@"../../Archivos/Clientesss.txt"))
            {
                while (!leer.EndOfStream)
                {
                    string x = leer.ReadLine();
                    textBoxRegistro.Text += x;
                    textBoxRegistro.Text += " \n";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
