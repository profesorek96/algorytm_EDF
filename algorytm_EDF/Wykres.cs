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
        List<Button> zadania_tmp = new List<Button>();
        int nr_zadania = 0;
        int czas = 0;
        int ilosc_maszyn = 1;
        List<Zadanie> zadania_wykres = new List<Zadanie>();
        List<Zadanie> zadania_wykres_tmp = new List<Zadanie>();
        public Wykres(List<Zadanie> zadania_wykres,int ilosc_maszyn)
        {
            InitializeComponent();
            start_sim.Visible = true;
            stop_sim.Visible = false;
            dodaj_task.Visible = false;
            this.zadania_wykres = zadania_wykres;
            this.ilosc_maszyn = ilosc_maszyn;
            //Os_czasu(100,0,0);
            //algorytm_EDF_roz();
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = false;
            panel1.VerticalScroll.Visible = false;
            panel1.AutoScroll = true;

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
            

        }

        private void start_sim_Click(object sender, EventArgs e)
        {
            start_sim.Visible = false;
            stop_sim.Visible = true;
            dodaj_task.Visible = true;
            panel1.Controls.Clear();
            os_czasu.Clear();
            zadania_tmp.Clear();
            czas = 0;
            timer1.Start();
            panel1.AutoScroll = false;
            zadania_wykres_tmp.Clear();
            for (int i = 0; i < zadania_wykres.Count; i++)
            {
                zadania_wykres_tmp.Add(new Zadanie(zadania_wykres[i]));
            }
            
            nr_zadania = 0;
       
        }

        private void stop_sim_Click(object sender, EventArgs e)
        {
            start_sim.Visible = true;
            stop_sim.Visible = false;
            dodaj_task.Visible = false;
            timer1.Stop();
            panel1.AutoScroll = true;
        }

        private void dodaj_task_Click(object sender, EventArgs e)
        {
            using (Form_dodaj_zadanie formObject = new Form_dodaj_zadanie())
            {
                formObject.ShowDialog();
                if (formObject.deadline != -1 && formObject.deadline != -1)
                {
                    Zadanie tmp = new Zadanie(zadania_wykres_tmp.Count+1, formObject.deadline, formObject.czas);
                    zadania_wykres_tmp.Add(tmp);
                    zadania_wykres_tmp.Sort();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(zadania_wykres_tmp.Count<=0)
            {
                return;
            }
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(czas*50, 50);
            newButton.Width = 50;
            newButton.Height = 50;
            newButton.Text = Convert.ToString(czas + 1);
            newButton.Enabled = false;
            os_czasu.Add(newButton);
            panel1.Controls.Add(newButton);
            if(nr_zadania>= zadania_wykres_tmp.Count)
            {
                zadania_wykres_tmp.Clear();
                for (int i = 0; i < zadania_wykres.Count; i++)
                {
                    zadania_wykres_tmp.Add(new Zadanie(zadania_wykres[i]));
                }
                nr_zadania = 0;
            }
            Button newButton2 = new Button();
            newButton2.Location = new System.Drawing.Point(czas * 50, 100);
            newButton2.Width = 50;
            newButton2.Height = 50;
            newButton2.Text = Convert.ToString(zadania_wykres_tmp[nr_zadania].id);
            newButton2.Enabled = false;
            if (zadania_wykres_tmp[nr_zadania].kolor == 0)
            {
                newButton2.BackColor = Color.Red;
            }
            else if (zadania_wykres_tmp[nr_zadania].kolor == 1)
            {
                newButton2.BackColor = Color.Blue;
            }
            else if (zadania_wykres_tmp[nr_zadania].kolor == 2)
            {
                newButton2.BackColor = Color.Green;
            }
            else if (zadania_wykres_tmp[nr_zadania].kolor == 3)
            {
                newButton2.BackColor = Color.Gray;
            }
            else if (zadania_wykres_tmp[nr_zadania].kolor == 4)
            {
                newButton2.BackColor = Color.Olive;
            }
            else if (zadania_wykres_tmp[nr_zadania].kolor == 5)
            {
                newButton2.BackColor = Color.OrangeRed;
            }
            else 
            {
                newButton2.BackColor = Color.BlueViolet;
            }
            zadania_tmp.Add(newButton2);
            panel1.Controls.Add(newButton2);
            zadania_wykres_tmp[nr_zadania].czas_wykonania -= 1;
            if(zadania_wykres_tmp[nr_zadania].czas_wykonania<=0)
            {
                nr_zadania++;
            }

            
            czas += 1;
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            //panel1.Controls.Clear();
            ////MessageBox.Show("huj");
            //for (int i = 0; i < czas; i++)
            //{
            //    panel1.Controls.Add(os_czasu[i]);
            //}

        }

    }
}
