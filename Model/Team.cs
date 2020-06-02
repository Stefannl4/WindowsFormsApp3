using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    public class Team
    {
        public string soortSport { get; set; }
        public Coach Coach { get; set; }
        public List<Speler> Teamleden = new List<Speler>();

        public Speler getTeamLid(int nummer)
        {
            if (Teamleden.Count >= nummer + 1)
                return Teamleden[nummer];
            else
                return new Speler();
        }
        public Team()
        {
            Coach = new Coach();
        }
    }
}
