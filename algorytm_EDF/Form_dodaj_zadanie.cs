using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace algorytm_EDF
{
    public partial class Form_dodaj_zadanie : Form
    {
        public int deadline=-1;
        public int czas=-1;
        public Form_dodaj_zadanie()
        {
            InitializeComponent();
            
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            deadline=Convert.ToInt32(numericUpDown1.Value);
            czas = Convert.ToInt32(numericUpDown2.Value);
            if(deadline<czas)
            {
                MessageBox.Show("Czas wykonania zadania jest wiekszy niz jego deadline!!!", "Blad",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                this.Close();
            }
            
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_dodaj_zadanie_Load(object sender, EventArgs e)
        {

        }
    }
}
