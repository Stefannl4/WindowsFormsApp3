using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
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
        public Team() { 
            Coach = new Coach();
        }
    }
    public abstract class Sporter
    {
        public string Naam { get; set; }
    }
    public class Coach : Sporter
    {
        public Boolean Ehbo { get; set; }
    }

    public class Speler : Sporter
    {
        public int Kledinggewassen { get; set; }
    }
    public class run
    {
        public void test1()
        {
            Coach coach = new Coach();
            coach.Naam = "Wesley";

            Speler Roel = new Speler();
            Roel.Naam = "Roel";

            Speler Stefan = new Speler();
            Stefan.Naam = "Stefan Ricardo";
            Stefan.Kledinggewassen = 5;

            Team vvRhoon = new Team();
            vvRhoon.soortSport = "Voetbal";
            vvRhoon.Coach = coach;
            vvRhoon.Teamleden.Add(Stefan);
            vvRhoon.Teamleden.Add(Roel);

        }
    }
}
