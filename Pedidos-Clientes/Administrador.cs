using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos_Clientes
{
    public class Administrador
    {
        public void RegistrarCliente()
        {
            bool continuar = true;
            do
            {
                Console.WriteLine("1. Cliente Regular");
                Console.WriteLine("2. Cliente VIP");
                Console.WriteLine("3. Cliente Corporativo");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cliente Regular: ");
                        ClienteRegular clienteRegular = new ClienteRegular();
                        clienteRegular.SolicitarDatos();


                        break;
                }
            } while (continuar == true);
        }
    }
}
