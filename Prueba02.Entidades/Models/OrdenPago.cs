using System;
using System.Collections.Generic;

namespace Prueba02.Entidades.Models
{
    public class OrdenPago : IEntity
    {
        public int Id { get; set; }
        public int IdSucursal { get; set; }
        public List<Sucursal> SucursalesList { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public string Estado { get; set; }
        public DateTime FechaPago { get; set; }
    }
}