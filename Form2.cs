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
            Coach teamcoach = new Coach();
            teamcoach.naam = "Wesley";

            Speler Roel = new Speler();
            Roel.naam = "RoXXel";

            Speler Stefan = new Speler();
            Stefan.naam = "Stefan Ricardo";
            Stefan.Kledinggewassen = 5;

            Team vvRhoon = new Team();
            vvRhoon.name = "Voetbal "+number;    
            vvRhoon.coachje = teamcoach;  
            vvRhoon.teamleden.Add(Stefan);
            vvRhoon.teamleden.Add(Roel);

            teamList.Add(vvRhoon);
            countries.Add(new Country("Australia "+ number));

            if (number==1) MessageBox.Show("Laatst toegevoegd \nNummer " +number);
            //comboBox1.ValueMember = "Naam";
            number++;


            //comboBox1.Refresh();//Kan ook, deze opdracht tekent de Combo opnieuw op het scherm zodat je de laatste wijziging ziet
            // Dit moet je zelf doen indien je niet binding doet


        }
    }
}
