﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

    

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
 

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

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new MyContext())
            {
                var std = new Coach()
                {
                    Naam = "Steef"
                };
                context.Coach.Add(std);

                context.SaveChanges();
            }
        }
    }
}
