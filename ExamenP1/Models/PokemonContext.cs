using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenP1.Models
{
    public class PokemonContext
    {
        public DbSet<Pokemon> Pokemones { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
    }
}