﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorytm_EDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dodaj_zadanie_Click(object sender, EventArgs e)
        {
            Zadanie a = new Zadanie(4, 19);
            MessageBox.Show(a.ToString());
        }

        private void generuj_zadanie_Click(object sender, EventArgs e)
        {

        }
    }
}
