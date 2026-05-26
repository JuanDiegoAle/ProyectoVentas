using ProyectoVentas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentas.Services
{
    public  class PagoService:IPagoService
    {
        public bool Procesar(IPago metodoPago,decimal monto)
        {
            if (!metodoPago.PuedeProcesar(monto))
            {
                MessageBox.Show("El método de pago no permite este monto");
                return false;
            }

            metodoPago.ProcesarPago(monto);
            return true;
        }
    }
}
