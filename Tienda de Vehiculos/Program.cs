using Pedidos;
using System;
using Tienda_de_Vehiculos;
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
                Console.WriteLine("2. Agregar Producto ");
                Console.WriteLine("3. Mostrar Habitaciones ");
                Console.WriteLine("4. Asignar Habitación a Cliente ");
                Console.WriteLine("5.Liberar Habitación:");
                Console.WriteLine("6.Salir");



                opcion = Convert.ToInt32(Console.ReadLine());
                while (opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Valor no esta en el rango...")
                        ; Console.WriteLine("Ingrese un valor: ");
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

                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();

                        break;
                    case 6:

                        continuar = false;

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