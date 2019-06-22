using ENA.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Controllers
{
    class MascotaController
    {


        public void InsertaMascota(string NombreMascota, string TipoMascota, string RazaMascota, bool Vacunas, string Color, int Edad, string Sexo)
        {
            if(!string.IsNullOrEmpty(NombreMascota) && !string.IsNullOrEmpty(RazaMascota) && !string.IsNullOrEmpty(Color) && !string.IsNullOrEmpty(Sexo) && Edad != 0) //ojo! usar esto para verificar datos que vengan del form!!!!!!!!!!!!!!!!)
            {

                Mascota objCliente = new Mascota(NombreMascota, TipoMascota, RazaMascota, Vacunas, Color, Edad, Sexo);// leer mas abajo

                //agregar a cliente para listar clientes y luego listar todo en sesion 

            }
        }

        public void InsertarMascota(int id, string nombre)
        {



        }


    }
}
