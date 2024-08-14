using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pedidos
{
    public  class Producto
    {
       
        public string Name { get; set; }
        public double Precio { get; set; }



        public void AgregarProducto(string name, double precio)
        {
           
            Name = name;
            Precio = precio;

        }
         
        public void NuevoProducto()
        {
            Console.Write(" Ingrese el nombre del producto: ");
            string nombre= Console.ReadLine().ToLower();
            Console.Write(" Ingrese el precio del producto: ");
            double precio= Double.Parse(Console.ReadLine());

            AgregarProducto(nombre, precio);

        }

        public bool BuscarProducto(string nombre)
        {
            bool existe = true;
            if (nombre != Name)
            {

                existe = false;
            }

            return existe;
        }
        public void MostrarProducto()
        {
            Console.WriteLine($" Producto: {Name}    Precio: {Precio}");
        }

    }
}
