using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Models
{
    class Servicio
    {
        public string DetalleServicio { get; set; }
        public int CostoServicio { get; set; }

        public Servicio(string DetalleServicio, int CostoServicio)
        {
            this.DetalleServicio = DetalleServicio;
            this.CostoServicio = CostoServicio;
        }

        


    }
}
