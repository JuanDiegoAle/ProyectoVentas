using ProyectoVentas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentas.Service.Pagos
{
    public  class PagoTarjeta:IPago
    {
        public string Nombre => "Tarjeta";
        public bool PuedeProcesar(decimal monto)
        {
            return true;
        }

        public void ProcesarPago(decimal monto) 
        {
            MessageBox.Show("Pago realizado con Tarjeta" + monto);
        }
    }
}
