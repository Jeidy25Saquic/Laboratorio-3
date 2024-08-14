using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ClienteCorporativo: Cliente 
    {
        public ClienteCorporativo(string id, string nombre, string direccion, string correo) : base(id, nombre, direccion, correo)
        {
        }

        public ClienteCorporativo()
        {
        }

        List<Vehiculo> vehiculos {  get; set; }= new List<Vehiculo>();

        public override void MostrarCliente()
        {
            base.MostrarCliente();
            Console.WriteLine($" Tipo de Cliente: Corporativo");
        }
        public override void SolicitarDatos()
        {
            base.SolicitarDatos();
            Descuento = 0.20;
        }




    }
}
