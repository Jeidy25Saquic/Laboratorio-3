using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Pedidos;

namespace Pedidos
{
    public class Administrador
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Producto> productos = new List<Producto>();
        List<Pedidos> pedidos = new List<Pedidos>();
        public void RegistrarCliente()
        {
            bool continuar = true;
            do
            {
                try
                {
                   
                    Console.WriteLine();
                    Console.WriteLine("1. Cliente Regular");
                    Console.WriteLine("2. Cliente VIP");
                    Console.WriteLine("3. Cliente Corporativo");
                    Console.WriteLine("4. salir");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Cliente Regular: ");
                            ClienteRegular clienteRegular = new ClienteRegular();
                            clienteRegular.SolicitarDatos();
                            clientes.Add(clienteRegular);


                            break;
                        case 2:
                            Console.WriteLine("Cliente VIP: ");
                            ClienteVIP clienteVIP = new ClienteVIP();
                            clienteVIP.SolicitarDatos();
                           clientes.Add(clienteVIP);

                            break;
                        case 3:
                            Console.WriteLine("Cliente Corporativo: ");
                            ClienteCorporativo clienteCorporativo = new ClienteCorporativo();
                            clienteCorporativo.SolicitarDatos();
                            clientes.Add(clienteCorporativo);


                            break;
                            case 4:
                            Console.Clear();
                            continuar= false;
                            break;


                        default:
                            Console.WriteLine("Ingrese una opcion correcta");
                            Console.WriteLine();
                            break;
                    }
                }catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error... " + ex.Message);
                }
            } while (continuar == true);
      

        }

        public void RegistrarVehiculo()
        {
            bool continuar = true;
            do
            {
                try
                {
                  
                    Console.WriteLine("1. Vehiculo Personal");
                    Console.WriteLine("2. Vehiculo Corporativo");
                    Console.WriteLine("3. Salir");


                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Vehiculo Personal: ");
                            VehiculoPersonal vehiculoPersonal = new VehiculoPersonal();
                            vehiculoPersonal.SolicitarDatos();
                            vehiculos.Add(vehiculoPersonal);

                            break;
                        case 2:
                            Console.WriteLine("Vehiculo Corporativo: ");
                            VehiculoCorporativo vehiculoCorporativo=new VehiculoCorporativo();
                            vehiculoCorporativo.SolicitarDatos();
                            vehiculos.Add(vehiculoCorporativo);
                            break;
                       
                        case 3:
                            Console.Clear();
                            continuar = false;
                            break;


                        default:
                            Console.WriteLine("Ingrese una opcion correcta");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error... " + ex.Message);
                }
            } while (continuar == true);


        }

        public void MostrarClientes()
        {
            int contador = 0;
            Console.WriteLine();
            Console.WriteLine("-------------------Informacion sobre clientes:-----------------------");
            
            foreach (var cliente in clientes)
            {
                contador++;
                Console.WriteLine();
                Console.WriteLine($"Cliente #{contador}");
                cliente.MostrarCliente();
               
            }
        }

        public void MostrarVehiculos()
        {
            int contador = 0;
            Console.WriteLine();
            Console.WriteLine("-------------------Informacion sobre vehiculos:-----------------------");

           foreach (var vehiculo in vehiculos)
            {
                contador++;
                Console.WriteLine();
                Console.WriteLine($"Vehiculo #{contador}");
                vehiculo.MostrarVehiculo();

            }


          
        }


        public void RegistrarProducto()
        {
            
            Producto producto = new Producto();
            producto.NuevoProducto();
            productos.Add(producto);

        }

        public void MostrarProductos()
        {

            Console.WriteLine();
            Console.WriteLine("-------------Lista de productos:---------- ");


          foreach(var producto in productos)
            {
                Console.WriteLine();
                producto.MostrarProducto();
            }

        }



    }





}
