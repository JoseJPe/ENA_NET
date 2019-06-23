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
    }
}
