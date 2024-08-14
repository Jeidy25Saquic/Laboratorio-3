using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class Pedidos
    {
        public int NumeroPedido { get; set; }
        public string  Date   {  get; set; }
        Cliente cliente { get; set; }
        
        public List<Producto> Productos { get; set; }=new List<Producto>();


           


        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

    }
}
