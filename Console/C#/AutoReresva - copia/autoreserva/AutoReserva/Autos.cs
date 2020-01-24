using System;
using System.IO;
using System.Windows.Forms;

namespace AutoReserva

{
    public partial class Autos : Form
    {
        private const string V = "{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}";
        private const string Format = V;

        public Autos()
        {
            InitializeComponent();
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

        private void btGuardadTodo_Click(object sender, EventArgs e)
        {

            /* string carpeta_Auto_servicios = Application.StartupPath + @"\Carpeta_Auto_servicios";
             string archivo_autos_menu = @"\Caracteristicas_autos.txt";

             string ubicacion_archivo_carpeta_carac_autos = carpeta_Auto_servicios + archivo_autos_menu;

             /*File.WriteAllLines(ubicacion_archivo_carpeta_carac_autos,
                                txtBox_Suburban_Carac_FAM.Text,
                                txtBox_Mazda_Carac_FAM.Text,
                                txtBox_Kia_Carac_FAM.Text,
                                txtBox_Vmw_Carac_PREM.Text,
                                txtBox_RollRoyce_Carac_PREM.Text,
                                txtBox_Bugatti_Carac_PREM.Text);
             MessageBox.Show("Texto cambiado");
             */

            using (StreamWriter writer = new StreamWriter("../../Archivos/CatalogoAutos.txt"))
            {
                writer.WriteLine(string.Format(
                    Format,
                    txtBox_Suburban_Carac_FAM.Text,
                    "\n",
                    txtBox_Mazda_Carac_FAM.Text,
                    "\n",
                    txtBox_Kia_Carac_FAM.Text,
                    "\n",
                    txtBox_Vmw_Carac_PREM.Text,
                    "\n",
                    txtBox_RollRoyce_Carac_PREM.Text,
                    "\n",
                    txtBox_Bugatti_Carac_PREM.Text,
                    "\n"));
            }

            txtBox_Suburban_Carac_FAM.Enabled = false;
            txtBox_Mazda_Carac_FAM.Enabled = false;
            txtBox_Kia_Carac_FAM.Enabled = false;
            txtBox_Vmw_Carac_PREM.Enabled = false;
            txtBox_RollRoyce_Carac_PREM.Enabled = false;
            txtBox_Bugatti_Carac_PREM.Enabled = false;


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
        }

        private void Autos_Load(object sender, EventArgs e)
        {

        }
    }
}
