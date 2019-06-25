using ENA.Class;
using ENA.Controllers;
using ENA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA
{
    public partial class IngresarClienteMascota : Form
    {
        

        public string Sexo { get; private set; }

        public IngresarClienteMascota()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void Label3_Click(object sender, EventArgs e)
        {
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void IngresarClienteMascota_Load(object sender, EventArgs e)
        {
        }
        private void Label8_Click(object sender, EventArgs e)
        {
        }




        private void GuardarDatos_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textNameCliente.Text) && !string.IsNullOrEmpty(textRutCliente.Text) && !string.IsNullOrEmpty(textDireccionCliente.Text) && !string.IsNullOrEmpty(textEmailCliente.Text) && !string.IsNullOrEmpty(textFonoCliente.Text) && Convert.ToInt32(textFonoCliente.Text) != 0)
            {



                ClienteController objControllerCliente = new ClienteController();

                objControllerCliente.InsertaCliente(textNameCliente.Text, textRutCliente.Text, textDireccionCliente.Text, textEmailCliente.Text, Convert.ToInt32(textFonoCliente.Text));


                if (!string.IsNullOrEmpty(textNombreMascota.Text) && !string.IsNullOrEmpty(tipoMascota.Text) && !string.IsNullOrEmpty(textColorMascota.Text) && !string.IsNullOrEmpty(Sexo) && Convert.ToInt32(textEdadMascota.Text) != 0 && !string.IsNullOrEmpty(textEdadMascota.Text)) 
                {


                    MascotaController objControllerMascota = new MascotaController();

                    objControllerMascota.InsertaMascota(textNombreMascota.Text, tipoMascota.Text, tipoRaza.Text, VacunasSi.Checked, textColorMascota.Text, Convert.ToInt32(textEdadMascota.Text), Sexo);
                }
                else
                {
                    MessageBox.Show("Datos de mascota incorrectos o vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Datos de cliente incorrectos o vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }


            //Limpiar campos

            textNameCliente.Text = "";
            textRutCliente.Text = "";
            textDireccionCliente.Text = "";
            textEmailCliente.Text = "";



            textNombreMascota.Text = "";
            tipoMascota.Text = "";
            tipoRaza.Text = "";
            textColorMascota.Text = "";

        }





        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VacunasSi_CheckedChanged(object sender, EventArgs e)
        {

            if (VacunasSi.Checked)
            {
                VacunasNo.Checked = false;
            }

            if (VacunasNo.Checked)
            {
                VacunasSi.Checked = false;
            }
        }

        private void TipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoRaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void RadioButtonMacho_CheckedChanged(object sender, EventArgs e)
        {


            if (radioButtonMacho.Checked)
            {
                radioButtonHembra.Checked = false;

                Sexo = "Macho";

            }

            if (radioButtonHembra.Checked)
            {
                radioButtonMacho.Checked = false;

                Sexo = "Hembra";

            }
        }

        private void IngresarDatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngresarControlServicio objform2 = new IngresarControlServicio();
            objform2.ShowDialog();
        }
    }
}
