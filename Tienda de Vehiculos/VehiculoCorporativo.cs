using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
     public class VehiculoCorporativo: Vehiculo
    {

        public void SolicitarDatos()
        {
            base.SolicitarDatos();
            Tipo = "corporativo";

        }


    }
}
