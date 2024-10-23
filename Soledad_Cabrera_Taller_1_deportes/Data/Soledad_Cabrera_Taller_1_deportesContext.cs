using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soledad_Cabrera_Taller_1_deportes.Models;

namespace Soledad_Cabrera_Taller_1_deportes.Data
{
    public class Soledad_Cabrera_Taller_1_deportesContext : DbContext
    {
        public Soledad_Cabrera_Taller_1_deportesContext (DbContextOptions<Soledad_Cabrera_Taller_1_deportesContext> options)
            : base(options)
        {
        }

        public DbSet<Soledad_Cabrera_Taller_1_deportes.Models.Jugador> Jugador { get; set; } = default!;
    }
}
