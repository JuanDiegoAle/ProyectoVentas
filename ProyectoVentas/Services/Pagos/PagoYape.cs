using ProyectoVentas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentas.Service.Pagos
{
    public  class PagoYape:IPago
    {
        public string Nombre => "Yape";
        public bool PuedeProcesar(decimal monto)
        {
            return monto <= 500;
        }

        public void ProcesarPago(decimal monto)
        {
            MessageBox.Show("Pago realizado con Yape:" + monto);
        }
    }
}
