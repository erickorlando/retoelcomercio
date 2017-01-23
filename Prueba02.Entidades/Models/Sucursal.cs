using System;
using System.Collections.Generic;

namespace Prueba02.Entidades.Models
{
    public class Sucursal : IEntity
    {
        public int Id { get; set; }
        public int IdBanco { get; set; }
        public List<Banco> BancosList { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}