using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class VehiculoPersonal:Vehiculo
    {
        public void SolicitarDatos()
        {
            base.SolicitarDatos();
            Tipo = "personal";

        }
    }
}
