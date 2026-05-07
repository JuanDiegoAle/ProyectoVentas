using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentas.Interfaces
{
    public interface IPago
    {
        string Nombre { get; }
        bool PuedeProcesar(decimal monto);
        void ProcesarPago(decimal monto);

    }
}
