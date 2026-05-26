using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas.Interfaces
{
    public interface IPagoService
    {
        bool Procesar(IPago metodoPago, decimal monto);
    }
}
