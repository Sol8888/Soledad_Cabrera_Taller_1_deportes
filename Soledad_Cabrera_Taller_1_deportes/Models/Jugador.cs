namespace Soledad_Cabrera_Taller_1_deportes.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posición { get; set; }
        public int Edad {  get; set; }

        public Equipo Equipo {  get; set; }
        public int IdEquipo { get; set; }
        

    }
}
