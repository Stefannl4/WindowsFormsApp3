using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {

        List<Team> teamList = new List<Team>();

        Team schermTeam = new Team();


        public Form2()
        {
            InitializeComponent();
            initScreen();
        }

        private void initScreen()
        {
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = teamList;

            comboBox1.DataSource = bindingSource1.DataSource;  
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

 

        private void NieuwButton_Click(object sender, EventArgs e)
        {

        }

        private void OpslaanButton_Click(object sender, EventArgs e)
        {

        }

        private void InitButton_Click(object sender, EventArgs e)
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
            vvRhoon.teamleden.Add(Stefan);
            vvRhoon.teamleden.Add(Roel);

            teamList.Add(vvRhoon);
            comboBox1.DisplayMember = "Naam";
            //comboBox1.ValueMember = "Naam";
        }
    }
}
