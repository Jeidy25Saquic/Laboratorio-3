using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pedidos
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set;}

        public string Correo { get; set; }

        public string Tipo { get; set; }
        public double Descuento { get; set; }
        Vehiculo Vehiculo { get; set; }

        public Cliente(string id, string nombre, string direccion, string correo)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Correo = correo;
        }



         public virtual  void SolicitarDatos()
        {
               Console.Write("Ingrese Identificacion: ");
               string id= Console.ReadLine();
               Console.Write("Ingrese el nombre del cliente: ");
                string nombre = Console.ReadLine().ToUpper();
                Console.Write("Ingrese  Direccion: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese  Correo Electronico: ");
                string correo = Console.ReadLine();
                
               AgregarDatos(id, nombre, direccion,correo);
        }

        public void AgregarDatos( string id, string nombre, string direccion, string correo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Correo = correo;
            Id = id;
        }

        public virtual void MostrarCliente()
        {
            Console.WriteLine($" Id: {Id} Nombre:  {Nombre}  Direccion: {Direccion} Correo: {Correo}");
        }

        public bool BuscarCliente(string nombre)
        {
            bool existe = true;
            if (nombre != Nombre)
            {

                existe = false;
            }
            
            return existe;
        }

        public double descuento()
        {
            return Descuento;

        }

    }
}
