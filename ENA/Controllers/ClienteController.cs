using ENA.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Controllers
{
    class ClienteController 
    {

        public void InsertaCliente(string nombreCliente, string rut, string direccion, string email, int fono)
        {
            if (!string.IsNullOrEmpty(nombreCliente) && !string.IsNullOrEmpty(rut) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(email) && fono != 0)
            {

                Cliente objCliente = new Cliente(nombreCliente, rut, direccion, email, fono);

                //agregar a la lista de clientes para la clase sesion

            }


        }

        public void EliminarCliente(string nombreCliente)
        {
            if (!string.IsNullOrEmpty(nombreCliente))
            {



            }
        }


        
    }
}
