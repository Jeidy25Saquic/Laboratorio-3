using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ClienteRegular: Cliente
    {

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($" Tipo de Cliente: Regular");
            Tipo = "Regular";
        }


    }
}
