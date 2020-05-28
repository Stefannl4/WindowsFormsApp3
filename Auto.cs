using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Auto
    {
        public string kenteken { get; set; }
        public string kleur { get; set; }
        public string omschrijving;
        public string bijzonderheden { get; set; }
        public string aanmelding { get; }

        public Auto(string aanm)
        {
            this.aanmelding = aanm;
        }

        public string getOmschrijving() { return omschrijving; }
        public void setOmschrijvig(string oms)
        {
            omschrijving = omschrijving + oms;
        }


    }

}
