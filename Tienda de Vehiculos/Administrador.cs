using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Vehiculos;

namespace Pedidos
{
    public class Administrador
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public void RegistrarCliente()
        {
            bool continuar = true;
            do
            {
                try
                {  
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
                   ;
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





    }






}
