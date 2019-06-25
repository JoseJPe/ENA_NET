using ENA.Class;
using ENA.Controllers;
using ENA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA.Views
{
    public partial class IngresarControlServicio : Form
    {
        public IngresarControlServicio()
        {
            InitializeComponent();

            ClienteController CC = new ClienteController();

            foreach (Cliente cliente in CC.Clientes)
            {

                listaClientes.Items.Add(cliente.NombreCliente);
            }

            ServicioControler SC = new ServicioControler();

            foreach (Servicio servicio in SC.Servicios)
            {

                listaClientes.Items.Add(servicio.DetalleServicio);

                TotalPago.Text = Convert.ToString(servicio.CostoServicio);
            }



            MascotaController MC = new MascotaController();

            foreach (Mascota mascota in MC.Mascotas)
            {

                listaMascotas.Items.Add(mascota.NombreMascota);

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Ingresar Datos de mascota y cliente



        }

        private void Ingresar_ControlServicio_Load(object sender, EventArgs e)
        {

        }

        private void VacunasSi_CheckedChanged(object sender, EventArgs e)
        {
            bool vacuna;

            if (VacunasSi.Checked)
            {
                VacunasNo.Checked = false;
                vacuna = VacunasSi.Checked;
            }

            if (VacunasNo.Checked)
            {
                VacunasSi.Checked = false;
                vacuna = VacunasSi.Checked;
            }


        }

        private void ConsultarControlServicio_Click(object sender, EventArgs e)
        {
            


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteController CC = new ClienteController();

            foreach (Cliente cliente in CC.Clientes)
            {

                listaClientes.Items.Add(cliente.NombreCliente);
            }

            ServicioControler SC = new ServicioControler();

            foreach (Servicio servicio in SC.Servicios)
            {

                listaClientes.Items.Add(servicio.DetalleServicio);

                TotalPago.Text = Convert.ToString(servicio.CostoServicio);
            }

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            MascotaController MC = new MascotaController();

            foreach (Mascota mascota in MC.Mascotas)
            {

                listaMascotas.Items.Add(mascota.NombreMascota);
                
            }

        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
