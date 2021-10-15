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
            this.zadania_wykres = zadania_wykres;
            this.ilosc_maszyn = ilosc_maszyn;
            Os_czasu(zadania_wykres.Count,0,0);
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
    }
}
