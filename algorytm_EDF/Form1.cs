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
        int licznik = 1;
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
                    Zadanie tmp = new Zadanie(licznik,formObject.deadline, formObject.czas);
                    zadania.Add(tmp);
                    zadania_list.Items.Add(tmp.ToString());
                    licznik++;
                }
                
            }
            
        }

        private void generuj_zadanie_Click(object sender, EventArgs e)
        {
            zadania.Sort();
            zadania_list.Items.Clear();
            for(int i=0;i<zadania.Count();i++)
            {
                zadania_list.Items.Add(zadania[i]);
            }
            Wykres wykres = new Wykres();
            wykres.ShowDialog();
        }

        private void czysc_liste_Click(object sender, EventArgs e)
        {
            zadania.Clear();
            zadania_list.Items.Clear();
            licznik = 1;
        }
    }
}
