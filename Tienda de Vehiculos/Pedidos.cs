using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pedidos
{
    public class Pedidos
    {
        public int NumeroPedido { get; set; }
        public string  Date   {  get; set; }
        Cliente usuario { get; set; }
        Vehiculo transporte { get; set; }
         
        public List<Producto> Productos { get; set; }=new List<Producto>();
      

      
        public void NuevoPedido(List<Cliente> clientes, List<Producto> producto, List<Vehiculo> vehiculos)
        {
            Console.Write("Ingrese el numero de pedido: ");
            int numeroPedido = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la fecha: ");
            string fecha= Console.ReadLine();
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine().ToUpper();
           
            ValidezPedido(clientes,producto,vehiculos, nombre, fecha, numeroPedido);

        }

        public void ValidezPedido(List<Cliente> clientes, List<Producto> producto, List<Vehiculo> vehiculos, string nombre, string fecha, int numeroPedido)
        {
            bool existe = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.BuscarCliente(nombre) == true)
                {
                    usuario = cliente;
                    NumeroPedido=numeroPedido;
                    Date = fecha;
                    AgrgarProducto(producto);
                    AgregarVehiculoPedido(vehiculos);
                    existe = true;
                    break;
                    
                   

                }
                
                
                
            }
            if (existe==false) {
                Console.WriteLine("No existe el clinte");
            }
            
        }

        public void AgrgarProducto(List<Producto> productos)
        {
            Console.WriteLine("Productos Disponibles");
            int id = 0;
             foreach (Producto producto in productos)
            {
                id++;
                Console.WriteLine($" Id: {id} Producto: {producto.Name}");

            }
            bool continuar = true, existe=true;
            do
            {

                Console.WriteLine("Ingrese el nombre del producto ");
                string nombre = Console.ReadLine().ToLower();
                foreach (Producto producto in productos)
                {
                   if(producto.BuscarProducto(nombre) == true)
                    {
                        Agregar(producto);
                        break;
                    }
                    

                }
                Console.WriteLine("Desea Agregar otro producto [si] [no]");
                 string respuesta=Console.ReadLine().ToLower();
                if (respuesta == "no")
                {
                    continuar= false;
                }

            } while (continuar==true);
         
             

        }
        public double SubTotal()
        {
            double subTotal = 0;
             foreach(Producto producto in Productos)
            {
                subTotal +=producto.Precio;
            }
             return subTotal;
        }

        public double Total()
        {
            double descuento = 0;
            descuento = SubTotal() * usuario.descuento();
            double total = SubTotal()-descuento;
           
            return total;
        }






        public void Agregar(Producto producto)
        {
            Productos.Add(producto);
        }


        public void AgregarVehiculoPedido(List<Vehiculo> vehiculos)
        {
            Console.WriteLine("Ingrese La matricula del vehiculo ");
            string matricula = Console.ReadLine();
            bool existe = false;

            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.BuscarMatricula(matricula))
                {
                    if (vehiculo.Disponible)
                    {
                        transporte = vehiculo;
                        vehiculo.Disponible = false;
                        existe = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El vehículo no está disponible.");
                        existe = true;
                        break;
                    }
                }
            }

            if (existe==false)
            {
                Console.WriteLine("No existe el vehículo con la matrícula ingresada.");
            }
        }

        public void MostrarPedido()
        {
            Console.WriteLine($"Tipo de Cliente: {usuario.Tipo} Vehiculo/s Asignado/s  {transporte.Modelo} { transporte.Matricula} " );

           Console.WriteLine($" Cliente: {usuario.Nombre} Numero de Pedido: {NumeroPedido} subTotal: [ {SubTotal()} ]  Total: [ {Total()} ]  Productos: ");
            Console.WriteLine();
            
                foreach (Producto producto in Productos)
                {
                    producto.MostrarProducto();
                }
            
        }


    }
}
