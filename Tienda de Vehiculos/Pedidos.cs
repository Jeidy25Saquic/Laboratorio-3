using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Vehiculos
{
    internal class Pedidos
    {
        public int NumeroPedido { get; set; }
        public string  Date   {  get; set; }
        public List<Producto> Productos { get; set; }=new List<Producto>();
    }
}
