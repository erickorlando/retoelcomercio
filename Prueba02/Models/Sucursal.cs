using System;

namespace Prueba02.Models
{
    public class Sucursal
    {
        public int IdSucursal { get; set; }
        public int IdBanco { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}