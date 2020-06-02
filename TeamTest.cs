using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3
{
    public class TeamTest
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
