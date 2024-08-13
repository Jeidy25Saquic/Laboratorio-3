using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Vehiculos
{
    public class ClienteCorporativo: Cliente 
    {

        List<Vehiculo> vehiculos {  get; set; }= new List<Vehiculo>();


    }
}
