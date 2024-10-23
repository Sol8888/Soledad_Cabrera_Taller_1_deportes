using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soledad_Cabrera_Taller_1_deportes.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public int Edad {  get; set; }

        public Equipo? Equipo {  get; set; }

        [ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        

    }
}
