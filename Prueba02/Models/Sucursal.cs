using System;
using System.Collections.Generic;

namespace Prueba02.Models
{
    public class Sucursal
    {
        public List<Banco> BancosList { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}