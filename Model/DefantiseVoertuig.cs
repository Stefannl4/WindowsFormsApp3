using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    public class Defensievoertuig : Voertuig
    {

        //public string kenteken { get; }
        //public string kleur { get; }
        //public string omschrijving;
        //public string bijzonderheden { get; set; }
        //public string aanmelding { get; }

        public Defensievoertuig(string aanm)
        {
            this.aanmelding = aanm;
        }

        public string getOmschrijving() { return omschrijving; }
        public void setOmschrijving(string oms)
        {
            omschrijving = omschrijving + oms;
        }

        public void setKleur(string eenKleur)
        {
            this.kleur = "groen";
        }

        public void setKenteken(string kent)
        {
            if (kent.StartsWith("K") | kent.StartsWith("L"))
            {

            }
            else
            {
                // Fout
                throw new Exception("Kenteken fout");
            }
        }
    }
}
