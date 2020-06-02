using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    public abstract class Voertuig
    {
        public string kenteken { get; set; }
        public string kleur { get; set; }
        public string omschrijving { get; set; }
        public string bijzonderheden { get; set; }
        public string aanmelding { get; set; }
    }
}
