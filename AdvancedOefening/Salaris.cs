using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOefening
{
    class Salaris
    {

        public bool MaandContract { get; set; }
        public double BrutoBedrag { get; set; }
        public int Btw { get; set; }

        public Salaris(bool maandContract, double brutoBedrag)
        {
            MaandContract = maandContract;
            BrutoBedrag = brutoBedrag;
            if (MaandContract)
            {
                Btw = 21;
            }
            else
            {
                Btw = 16;
            }
            
        }

        public double BerekenNetto()
        {
            double netto = (BrutoBedrag /100)*Btw;
            netto -= BrutoBedrag;
            return Math.Abs(netto);
        }
        public override string ToString()
        {
            return $"Bruto {BrutoBedrag}$ Netto {BerekenNetto()}$";
        }
    }
}
