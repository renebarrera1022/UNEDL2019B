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
    public partial class AutosClientes : Form
    {
        private const string V = "{0}{1}{2}{3}{4}{5}";
        private const string Format = V;
        private string reg_s = "";
        public AutosClientes()
        {
            InitializeComponent();
        }

        private void AutosClientes_Load(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_Suburban_Click(object sender, EventArgs e)
        {

        }

        private void bt_editar_VMW_Click(object sender, EventArgs e)
        {

        }

        private void bt_Carpeta_Archivo_Click(object sender, EventArgs e)
        {
            /* string carpeta_Auto_servicios = Application.StartupPath + @"\Carpeta_Auto_servicios";
             string archivo_autos_menu = @"\Caracteristicas_autos.txt";
             string crear = carpeta_Auto_servicios + archivo_autos_menu;
             try
             {
                 if(Directory.Exists(crear))
                 {
                     MessageBox.Show("Carpeta Existe");
                 }
                 else
                 {
                     MessageBox.Show("Carpeta no existe. Creando...");
                     Directory.CreateDirectory(carpeta_Auto_servicios);
                     using (File.Create(crear));



                 }

             }catch(Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message);
             }
             */
        }

        private void txtBox_Suburban_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_Editar_todo_Click(object sender, EventArgs e)
        {
            txtBox_Suburban_Carac_FAM.Enabled = true;
            txtBox_Mazda_Carac_FAM.Enabled = true;
            txtBox_Kia_Carac_FAM.Enabled = true;
            txtBox_Vmw_Carac_PREM.Enabled = true;
            txtBox_RollRoyce_Carac_PREM.Enabled = true;
            txtBox_Bugatti_Carac_PREM.Enabled = true;


        }
        public String Suburban()
        {
            if (Chbx_Suburban.Checked)
            {
                reg_s = "SUBURBAN";
                return txtBox_Suburban_Carac_FAM.Text;
            }
            return "";
        }
        public String Mazda()
        {
            if (Chbx_Mazda.Checked)
            {
                reg_s = "MAZDA";
                return txtBox_Mazda_Carac_FAM.Text;
            }
            return "";
        }
        public String Kia()
        {
            if (Chbx_Kia.Checked)
            {
                reg_s = "KIA";
                return txtBox_Kia_Carac_FAM.Text;
            }
            return "";
        }
        public String BMW()
        {
            if (Chbx_BMW.Checked)
            {
                reg_s = "BMW";
                return txtBox_Vmw_Carac_PREM.Text;
            }
            return "";
        }
        public String RollRoyce()
        {
            if (Chbx_RollRoyce.Checked)
            {
                reg_s = "ROLLROYCE";
                return txtBox_RollRoyce_Carac_PREM.Text;
            }
            return "";
        }
        public String Bugatti()
        {
            if (Chbx_Bugatti.Checked)
            {
                reg_s = "BUGATTI";
                return txtBox_Bugatti_Carac_PREM.Text;
            }
            return "";
        }
        private void btGuardadTodo_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("../../Archivos/AutoCliente.txt"))
            {
                writer.WriteLine(string.Format(
                    Format,
                   Suburban(),
                   Mazda(),
                   Kia(),
                   BMW(),
                   RollRoyce(),
                   Bugatti()
                   ));
            }

            txtBox_Suburban_Carac_FAM.Enabled = false;
            txtBox_Mazda_Carac_FAM.Enabled = false;
            txtBox_Kia_Carac_FAM.Enabled = false;
            txtBox_Vmw_Carac_PREM.Enabled = false;
            txtBox_RollRoyce_Carac_PREM.Enabled = false;
            txtBox_Bugatti_Carac_PREM.Enabled = false;
            
            Clientes clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }
        public string ObtenerCarro()
        {
            return reg_s;
        }
        private void bt_Baja_Suburban_Click(object sender, EventArgs e)
        {
            txtBox_Suburban_Carac_FAM.Text = "";
        }

        private void txtBox_Mazda_Carac_FAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Kia_Carac_FAM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Vmw_Carac_PREM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_RollRoyce_Carac_PREM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Bugatti_Carac_PREM_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_baja_Mazda_Click(object sender, EventArgs e)
        {
            txtBox_Mazda_Carac_FAM.Text = "";

        }

        private void bt_baja_KIA_Click(object sender, EventArgs e)
        {
            txtBox_Kia_Carac_FAM.Text = "";
        }

        private void bt_baja_wmw_Click(object sender, EventArgs e)
        {
            txtBox_Vmw_Carac_PREM.Text = "";

        }

        private void bt_baja_Rollroyce_Click(object sender, EventArgs e)
        {
            txtBox_RollRoyce_Carac_PREM.Text = "";
        }

        private void bt_baja_Bugatti_Click(object sender, EventArgs e)
        {
            txtBox_Bugatti_Carac_PREM.Text = "";
        }

        private void labelFamiliar_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_Mazda_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutoReserva inicio = new AutoReserva();
            inicio.Show();
        }
    }
}
