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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // ir a form ingresar cliente y mascota
            this.Hide();
            IngresarClienteMascota objform = new IngresarClienteMascota();
            objform.ShowDialog();


        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // ir a form: control y servicio
            this.Hide();
            IngresarControlServicio objform2 = new IngresarControlServicio();
            objform2.ShowDialog();
        }
    }
}
