using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Team
    {
        public string OmschrijvingTeam { get; set; }
        public Coach coachje { get; set; }
        public List<Speler> teamleden = new List<Speler>();
    }


    public abstract class Sporter
    {
        public string naam { get; set; }
    }
    public class Coach : Sporter
    {
    }

    public class Speler : Sporter
    {
        public int Kledinggewassen { get; set; }
    }

    public class run
    {
        public void test1()
        {
            Coach teamcoach = new Coach();
            teamcoach.naam = "Wesley";

            Speler Roel = new Speler();
            Roel.naam = "RoXXel";

            Speler Stefan = new Speler();
            Stefan.naam = "Stefan Ricardo";
            Stefan.Kledinggewassen = 5;

            Team vvRhoon = new Team();
            vvRhoon.coachje = teamcoach;
            vvRhoon.teamleden[0] = Stefan;
            vvRhoon.teamleden[1] = Roel;

        }
    }
}
