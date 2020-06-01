using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// Binding info
// https://stackoverflow.com/questions/3567897/combobox-will-not-update-its-display-list-unless-you-change-selections-first
//
//

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        int number = 1;
        public BindingList<Team> teamList = new BindingList<Team>();
        public BindingList<Country> countries = new BindingList<Country> { new Country("UK"),
                                     new Country("Australia"),
                                     new Country("France") };
        Team schermTeam = new Team();

        public Form2()
        {
            InitializeComponent();
            initScreen();
        }

        private void initScreen()
        {
            var bindingSource1 = new BindingSource();// declaratie
            bindingSource1.DataSource = teamList; // Bind de datasource aan een lijst
            comboBox1.DataSource = bindingSource1.DataSource;// Combo.datasource aan de binding.DataSource binden
            comboBox1.DisplayMember = "name";// Toon de inhoud van veld... van het element dat je toont
            //FillCombo(); // Dit is de ouderwetse manier om de ombobox zelf te vullen  
        }  

        private void NieuwButton_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            schermTeam = new Team(); 
            
            SoortSportField.Text = "";
            CoachField.Text = "";
            TeamField1.Text = "";
            TeamField2.Text = "";
            
            teamList.Add(schermTeam);
        }

        private void OpslaanButton_Click(object sender, EventArgs e)
        {
            schermTeam.soortSport = SoortSportField.Text;
            schermTeam.Coach.Naam = CoachField.Text;
            schermTeam.Teamleden[0].Naam = TeamField1.Text;
            schermTeam.Teamleden[1].Naam = TeamField2.Text;
            //teamList.Add(schermTeam);
        }

        private void FillCombo()
        {
            teamList.Clear();
            foreach(Team team in teamList)
            {
                comboBox1.Items.Add(team);
            }
        }

        private void InitButton_Click(object sender, EventArgs e)
        {
            Coach Coach = new Coach();
            Coach.Naam = "Wesley";

            Speler Speler1 = new Speler();
            Speler1.Naam = "Roel";

            Speler Speler2 = new Speler();
            Speler2.Naam = "Stefan Ricardo";
            Speler2.Kledinggewassen = 5;

            Team Team = new Team();
            Team.soortSport = "Voetbal";
            Team.Coach = Coach;
            Team.Teamleden.Add(Speler1);
            Team.Teamleden.Add(Speler2);

            teamList.Add(Team);
            countries.Add(new Country("Australia "+ number));

            if (number==1) MessageBox.Show("Laatst toegevoegd \nNummer " +number);
            //comboBox1.ValueMember = "Naam";
            number++;

            //comboBox1.Refresh();//Kan ook, deze opdracht tekent de Combo opnieuw op het scherm zodat je de laatste wijziging ziet
            // Dit moet je zelf doen indien je niet binding doet

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            Team Team = (Team)comboBox1.SelectedItem;
            SoortSportField.Text = Team.soortSport;
            CoachField.Text = Team.Coach.Naam;
            TeamField1.Text = Team.getTeamLid(0).Naam;
            TeamField2.Text = Team.getTeamLid(1).Naam;            
        }

        private void AnnulerenButton_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }
    }
}
