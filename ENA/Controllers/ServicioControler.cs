using ENA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Controllers
{
    class ServicioControler
    {


        public void InsertarServicio(string detalleServicio, int costoServicio)
        {

            Servicio objController = new Servicio(detalleServicio, costoServicio);

            EnlistarServicios(objController);

        }

        public List<Servicio> Servicios = new List<Servicio>();




        public void EnlistarServicios(Servicio servicio)
        {

            //Servicios
            Servicio corteuñas = new Servicio("se cortan sus uñas", 1000);
            Servicio cortepelo = new Servicio("se corta el pelo", 2000);

            Servicios.Add(cortepelo);
            Servicios.Add(corteuñas);
            Servicios.Add(servicio);


        }

    }



}
