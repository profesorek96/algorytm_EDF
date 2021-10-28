using System;
using System.Collections.Generic;
using System.Text;

namespace algorytm_EDF
{
    public class Zadanie:IComparable
    {
        public int id;
        public int deadline;
        public int czas_wykonania;
        public int kolor;
        public Zadanie(int id,int deadline,int czas)
        {
            this.id = id;
            this.deadline = deadline;
            this.czas_wykonania = czas;
            Random losowa = new Random();
            kolor = losowa.Next(0, 7);
        }
        public Zadanie(Zadanie tmp)
        {
            this.id = tmp.id;
            this.deadline = tmp.deadline;
            this.czas_wykonania = tmp.czas_wykonania;
            this.kolor = tmp.kolor;
        }

        public int CompareTo(object obj)
        {
            Zadanie inneZadanie = obj as Zadanie;
            if(this.deadline<inneZadanie.deadline)
            {
                return -1;
            }
            else if(this.deadline==inneZadanie.deadline)
            {
                if (this.czas_wykonania < inneZadanie.czas_wykonania)
                {
                    return -1;
                }
                else if (this.czas_wykonania == inneZadanie.czas_wykonania)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }
        }
        public override string ToString()
        {
            return "ID: "+Convert.ToString(id)+" Czas dedline: "+Convert.ToString(deadline)+" Czas wykonania: "+Convert.ToString(czas_wykonania);
        }

    }
}
