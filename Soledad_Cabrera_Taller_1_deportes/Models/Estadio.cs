using System.ComponentModel.DataAnnotations;

namespace Soledad_Cabrera_Taller_1_deportes.Models
{
    public class Estadio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Dieccion { get; set; }
        public string Ciudad { get; set; }
        public string Capacidad { get; set; }

    }
}
