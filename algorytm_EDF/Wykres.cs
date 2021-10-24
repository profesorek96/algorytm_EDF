using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace algorytm_EDF
{
    public partial class Wykres : Form
    {
        List<Button> os_czasu = new List<Button>();
        int ilosc_maszyn = 1;
        List<Zadanie> zadania_wykres = new List<Zadanie>();
        public Wykres(List<Zadanie> zadania_wykres,int ilosc_maszyn)
        {
            InitializeComponent();
            start_sim.Visible = true;
            stop_sim.Visible = false;
            dodaj_task.Visible = false;
            this.zadania_wykres = zadania_wykres;
            this.ilosc_maszyn = ilosc_maszyn;
            Os_czasu(100,0,0);
            algorytm_EDF_roz();
        }
        public void Os_czasu(int n,int x,int y)
        {
            for (int i=0;i<n;i++)
            {
                Button newButton = new Button();
                newButton.Location = new System.Drawing.Point(x, y);
                newButton.Width = 50;
                newButton.Height = 50;
                newButton.Text = Convert.ToString(i + 1);
                newButton.Enabled = false;
                os_czasu.Add(newButton);
                x += 50;
                panel1.Controls.Add(newButton);
            }
        }
        public void algorytm_EDF_roz()
        {
            List<List<Zadanie>> maszyny = new List<List<Zadanie>>();
            List<int> suma_czasu = new List<int>(ilosc_maszyn);
            for(int i=0;i<ilosc_maszyn;i++)
            {
                suma_czasu.Add(0);
                maszyny.Add(new List<Zadanie>());
            }
            for(int i=0;i<zadania_wykres.Count;i++)
            {
                for (int j = 0; j < ilosc_maszyn; j++)
                {
                    if (suma_czasu[j] < zadania_wykres[i].deadline)
                    {
                        maszyny[j].Add(zadania_wykres[i]);
                        suma_czasu[j] += zadania_wykres[i].czas_wykonania;
                        break;
                    }
                }
            }

            Console.WriteLine("Huj");

        }

        private void start_sim_Click(object sender, EventArgs e)
        {
            start_sim.Visible = false;
            stop_sim.Visible = true;
            dodaj_task.Visible = true;
        }

        private void stop_sim_Click(object sender, EventArgs e)
        {
            start_sim.Visible = true;
            stop_sim.Visible = false;
            dodaj_task.Visible = false;
        }

        private void dodaj_task_Click(object sender, EventArgs e)
        {

        }
    }
}
