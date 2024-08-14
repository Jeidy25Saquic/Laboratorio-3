using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ClienteVIP: Cliente
    {
        
        public  override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($" Tipo de Cliente: VIP");
            Tipo = "VIP";
        }

        public override void SolicitarDatos()
        {
            base.SolicitarDatos();
            Descuento = 0.10;
        }


    }
}
