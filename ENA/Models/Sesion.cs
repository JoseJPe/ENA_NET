using System;
using ENA.Models;
using System.Collections.Generic;

namespace ENA.Class
{
    class Sesion
    {

        


        static void list()
        {

            //Servicios
            Servicio corteuñas = new Servicio("se cortan sus uñas", 1000);
            Servicio cortepelo = new Servicio("se corta el pelo", 2000);

            List<Servicio> Servicios = new List<Servicio>();
            Servicios.Add(cortepelo);
            Servicios.Add(corteuñas);

            //Mascotas
            Mascota firulais = new Mascota("Firulais", "Perro", "Kiltro", true, "Negro", 10, "macho");
            Mascota Giorno = new Mascota("Giorno", "Perro", "Golden", true, "cafe claro", 12, "macho");

            List<Mascota> Mascotas = new List<Mascota>();
            Mascotas.Add(firulais);
            Mascotas.Add(Giorno);

            //Clientes
            Cliente Juan = new Cliente("Juan", "13", "La florida", "@", 91930941);

            List<Cliente> Clientes = new List<Cliente>();
            Clientes.Add(Juan);

            

            foreach (Cliente cliente in Clientes)
            {
                Console.WriteLine(string.Format("Nombre: {0} Rut: {1} Direccion: {2} Correo: {3} Fono: {4} Mascota/s: {5}  ", cliente.NombreCliente, cliente.Rut, cliente.Direccion, cliente.Email, cliente.Fono, cliente.Mascotas));
                foreach (Mascota mascota in Mascotas)
                {
                    Console.WriteLine(string.Format("Nombre: {0} Tipo: {1} Raza: {2} Vacunado: {3} Color: {4} Edad: {5} Sexo: {6} Servicios {7}", mascota.NombreMascota, mascota.TipoMascota, mascota.RazaMascota, mascota.Vacunas, mascota.Color, mascota.Edad, mascota.Sexo, mascota.Servicios));
                    foreach (Servicio servicio in Servicios)
                    {
                        Console.WriteLine(string.Format("Detalle: {0} Costo: {1}", servicio.DetalleServicio, servicio.CostoServicio));
                    }
                }
            }

        }


        // aca se almacena el listado de los clientes y las mascotas

    }
}


