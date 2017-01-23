using System;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Banco
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