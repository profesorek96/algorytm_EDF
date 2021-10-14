using System;
using System.Collections.Generic;
using System.Text;

namespace algorytm_EDF
{
    class Zadanie
    {
        public int deadline;
        public int czas_wykonania;
        public Zadanie(int deadline,int czas)
        {
            this.deadline = deadline;
            this.czas_wykonania = czas;
        }

        public override string ToString()
        {
            return "Czas dedline: "+Convert.ToString(deadline)+" Czas wykonania: "+Convert.ToString(czas_wykonania);
        }

    }
}
