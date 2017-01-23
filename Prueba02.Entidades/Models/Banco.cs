using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba02.Entidades.Models
{
    public class Banco : IEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(150)]
        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}