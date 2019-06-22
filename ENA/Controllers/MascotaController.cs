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

        public void InsertarMascota(int id, string nombre)
        {
            if(id!=0 && !string.IsNullOrEmpty(nombre))
            {

                Mascota obj = new Mascota(id, nombre);

                obj.Guardar();
            }



        }


    }
}
