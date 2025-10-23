using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenP1.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int NivelPoder { get; set; }
        public string Habilidad { get; set; }
    }
}