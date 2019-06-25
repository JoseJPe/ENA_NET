using ENA.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA.Controllers
{
    class ClienteController 
    {

        public List<Cliente> Clientes = new List<Cliente>();


        public void InsertaCliente(string nombreCliente, string rut, string direccion, string email, int fono)
        {
            if (!string.IsNullOrEmpty(nombreCliente) && !string.IsNullOrEmpty(rut) && !string.IsNullOrEmpty(direccion) && !string.IsNullOrEmpty(email) && fono != 0)
            {




                Cliente objCliente = new Cliente(nombreCliente, rut, direccion, email, fono);



                EnlistarCliente(objCliente);

                //agregar a la lista de clientes para la clase sesion

            }
            else
            {
                MessageBox.Show("Mensaje informativo", "Mesage de error", MessageBoxButtons.OK, MessageBoxIcon.Error);




            }


        }


        public void EnlistarCliente(Cliente cliente)
        {

            //Clientes
            Cliente Juan = new Cliente("Juan", "13", "La florida", "@", 91930941);


            Clientes.Add(Juan);
            Clientes.Add(cliente);

        }


        public void EliminarCliente(Cliente cliente)
        {

            Clientes.Remove(cliente);

        }





        public void EliminarCliente(string nombreCliente)
        {
            if (!string.IsNullOrEmpty(nombreCliente))
            {



            }
        }


        
    }
}
