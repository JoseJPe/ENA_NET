using ENA.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA.Controllers
{
    class MascotaController
    {

        public List<Mascota> Mascotas = new List<Mascota>();

        public void InsertaMascota(string NombreMascota, string TipoMascota, string RazaMascota, bool Vacunas, string Color, int Edad, string Sexo)
        {
            if(!string.IsNullOrEmpty(NombreMascota) && !string.IsNullOrEmpty(RazaMascota) && !string.IsNullOrEmpty(Color) && !string.IsNullOrEmpty(Sexo) && Edad != 0) //ojo! usar esto para verificar datos que vengan del form!!!!!!!!!!!!!!!!)
            {

                Mascota objMascota = new Mascota(NombreMascota, TipoMascota, RazaMascota, Vacunas, Color, Edad, Sexo);// leer mas abajo

                Sesion objSesion = new Sesion();

                EnlistarMascota(objMascota);


            }
            else
            {
                MessageBox.Show("Mensaje informativo", "Mesage de error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }
        }
        
        public void EnlistarMascota(Mascota mascota)
        {
            //Mascotas
            Mascota Giorno = new Mascota("Giorno", "Perro", "Golden", true, "cafe claro", 12, "macho");
            Mascota firulais = new Mascota("Firulais", "Perro", "Kiltro", true, "Negro", 10, "macho");

            Mascotas.Add(firulais);
            Mascotas.Add(Giorno);
            Mascotas.Add(mascota);


        }




    }
}
