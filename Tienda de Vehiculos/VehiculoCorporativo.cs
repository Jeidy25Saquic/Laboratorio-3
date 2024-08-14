using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
     public class VehiculoCorporativo: Vehiculo
    {

        public override void SolicitarDatos()
        {
            base.SolicitarDatos();
            Tipo = "Corporativo";

        }

        public override void MostrarVehiculo()
        {
            base.MostrarVehiculo();
        }


    }
}
