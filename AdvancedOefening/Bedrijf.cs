using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOefening
{
    class Bedrijf
    {
        public string Naam { get; set; }
        public List<Werknemer> Werknemers { get; set; }
        public Bedrijf(string naam)
        {
            Werknemers = new List<Werknemer>();
            Naam = naam;
        }

        
        public void AddWerknemer(Werknemer werknemer)
        {
            Werknemers.Add(werknemer);
        }
        public void RemoveWerknemer(int index)
        {
            Werknemers.RemoveAt(index);
        }
    }
}
