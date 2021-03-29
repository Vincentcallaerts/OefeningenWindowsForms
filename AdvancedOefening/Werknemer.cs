using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOefening
{
    class Werknemer
    {

        public Salaris Salaris { get; set; }
        public string Naam { get; set; }
        public string LandVanHerkomst { get; set; }

        public Werknemer(Salaris salaris, string naam, string landVanHerkomst)
        {
            Salaris = salaris;
            Naam = naam;
            LandVanHerkomst = landVanHerkomst;
        }
        public override string ToString()
        {
            return Salaris.ToString() + " " + LandVanHerkomst;
        }
    }
}
