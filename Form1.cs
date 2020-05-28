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
    public partial class Form1 : Form
    {

        Auto auto1 = new Auto("aanmelden?");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            auto1.bijzonderheden = "";
            auto1.setOmschrijvig("Stefan ");
            auto1.setOmschrijvig("de ");
            auto1.setOmschrijvig("Lange");
            label1.Text = auto1.getOmschrijving();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Defensievoertuig dfv = new Defensievoertuig("Aanmelden");
            dfv.setKenteken(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TeamOpenButton_Click(object sender, EventArgs e)
        {
            Form2 mijnwpf = new Form2();
            mijnwpf.Visible = true;
        }
    }
}
