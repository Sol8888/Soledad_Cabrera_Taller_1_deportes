using Microsoft.AspNetCore.Mvc.Rendering;

namespace Soledad_Cabrera_Taller_1_deportes.Models
{
    public class JugadorEquipo
    {
        public SelectList Equipos { get; set; }  
        public IEnumerable<Jugador> Jugadores { get; set; }  
        public string SearchString { get; set; }  
        public string JugadoEquipo { get; set; } 
    }
}
