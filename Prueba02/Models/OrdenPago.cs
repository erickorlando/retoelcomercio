using System;

namespace Prueba02.Models
{
    public class OrdenPago
    {
        public int IdOrdenPago { get; set; }
        public int IdSucursal { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
    }
}