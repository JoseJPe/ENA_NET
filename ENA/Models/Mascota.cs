using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Class
{
    class Mascota
    {

        public int ID { get; set; }
        public string Nombre { get; set; }


        public Mascota(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }

        public bool Guardar()
        {

            // insertar datos en DB y que retorne un true

            return true;
        }

    }
}
