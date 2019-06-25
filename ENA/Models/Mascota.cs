using ENA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Class
{
    class Mascota
    {

        public string NombreMascota { get; set; }

        public string TipoMascota { get; set; }
        public string RazaMascota { get; set; }
        public bool Vacunas { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        public List<Servicio> Servicios { get; set; }



        public Mascota(string NombreMascota, string TipoMascota, string RazaMascota, bool Vacunas, string Color, int Edad, string Sexo)
        {
            this.NombreMascota = NombreMascota;
            this.TipoMascota = TipoMascota;
            this.RazaMascota = RazaMascota;
            this.Vacunas = Vacunas;
            this.Color = Color;
            this.Edad = Edad;
            this.Sexo = Sexo;

        }

        //public bool Guardar()
        //{
        //
        //    // insertar datos en DB y que retorne un true
        //
        //    return true;
        //}

    }
}
