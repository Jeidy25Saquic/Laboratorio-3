using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Vehiculo 
    {
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public string Combustible { get; set; }
        public string Tipo { get; set; }

        public Vehiculo(string modelo, string matricula, string combustible, string tipo)
        {
            Modelo = modelo;
            Matricula = matricula;
            Combustible = combustible;
            Tipo = tipo;
        }

        public Vehiculo()
        {
        }

        public void SolicitarDatos()
        {
            Console.Write("Ingrese Matricula: ");
            string matricula = Console.ReadLine();
            Console.Write("Ingrese el Modelo: ");
            string  modelo = Console.ReadLine();
            Console.Write("Ingrese el tipo de combustible: ");
            string combustible = Console.ReadLine();
            AgregarVehiculo(matricula, modelo, combustible);
        }

        public void AgregarVehiculo(string matricula, string modelo, string combustible)
        {
            Matricula=matricula;
            Modelo = modelo;
            Combustible=combustible;
        }
    }
}
