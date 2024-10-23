using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soledad_Cabrera_Taller_1_deportes.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranejros { get; set; }

        public Estadio? Estadio { get; set; }

        [ForeignKey("Estadio")]
        public int IdEstadio { get; set; }
    }
}
