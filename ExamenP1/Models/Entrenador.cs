using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ExamenP1.Models
{
    public class Entrenador
    {

        public int Id { get; set; }

        public string NombreEntrenador { get; set; }

        public string Region { get; set; }

 
        public int Edad { get; set; }

        // Relación con Pokémon
    
        public int PokemonId { get; set; }

        // Navegación para poder acceder a Pokemon desde la vista/controlador
        public virtual Pokemon Pokemon { get; set; }
    }
}
