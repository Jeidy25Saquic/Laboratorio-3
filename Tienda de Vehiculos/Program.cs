using Pedidos;
using System;

class Program
{
    public static void Main(string[] args)
    {
        Administrador administrador = new Administrador();
        bool continuar = true;
        int opcion = 0;

        do
        {
            try
            {
               
                Console.WriteLine();
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Agregar Vehiculos ");
                Console.WriteLine("3. Mostrar Clientes");
                Console.WriteLine("4. Mostrar Vehiculos ");
                Console.WriteLine("5. Registrar Producto");
                Console.WriteLine("7. Mostrar Productos");

                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 6) 
                {
                    Console.WriteLine("Valor no esta en el rango...");
                    Console.WriteLine("Ingrese un valor: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        administrador.RegistrarCliente();
                        break;

                    case 2:
                        Console.Clear();
                        administrador.RegistrarVehiculo();
                        break;
                    case 3:
                        Console.Clear();
                        administrador.MostrarClientes();
                        break;
                    case 4:
                        Console.Clear();
                        administrador.MostrarVehiculos();
                        break;
                    case 5:
                        Console.Clear();
                        administrador.RegistrarProducto();
                        break;
                    case 6:
                        Console.Clear();
                        administrador.MostrarProductos();
                        break;
                    case 10:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("no agregado");
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