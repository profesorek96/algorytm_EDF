using System;
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
        List<Zadanie> zadania = new List<Zadanie>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dodaj_zadanie_Click(object sender, EventArgs e)
        {
            using (Form_dodaj_zadanie formObject = new Form_dodaj_zadanie())
            {
                formObject.ShowDialog();
                if(formObject.deadline!=-1 &&formObject.deadline!=-1)
                {
                    zadania.Add(new Zadanie(formObject.deadline, formObject.czas));
                }
                
            }
        }

        private void generuj_zadanie_Click(object sender, EventArgs e)
        {

        }
    }
}
