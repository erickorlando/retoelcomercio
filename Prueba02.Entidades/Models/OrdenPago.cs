using System;
using System.Collections.Generic;

namespace Prueba02.Models
{
    public class OrdenPago
    {
        public List<Sucursal> SucursalesList { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
    }
}