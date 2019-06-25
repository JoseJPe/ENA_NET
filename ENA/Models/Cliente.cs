using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA.Class
{
    class Cliente
    {
        public string NombreCliente { get; set; }
        public string Rut { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Fono { get; set; }
        public List<Mascota> Mascotas { get; set; }

        // Constructor de la clase
        public Cliente(string NombreCliente, string Rut, string Direccion, string Email, int Fono)
        {
            this.NombreCliente = NombreCliente;
            this.Rut = Rut;
            this.Direccion = Direccion;
            this.Email = Email;
            this.Fono = Fono;
        }




    }
}
