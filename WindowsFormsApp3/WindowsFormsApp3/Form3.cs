﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fournisseur fournisseurForm = new Fournisseur();
            fournisseurForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           PiecesDetacheesForm piecesDetachees = new PiecesDetacheesForm();
           piecesDetachees.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LigneReparationForm LigneReparationForm = new LigneReparationForm();
            LigneReparationForm.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FichePanneFormcs fichePanneFormcs = new FichePanneFormcs();
            fichePanneFormcs.Show();
        }
    }
}