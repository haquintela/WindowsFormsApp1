using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Professor
    {
        private int NumeroProf;
        private string NomeProf;

        //Construtor
        public Professor(string nomeprof, int numeroprof)
        {
            this.NumeroProf = numeroprof;
            this.NomeProf = nomeprof;
        }


        //Get & Set

        public int Numero
        {
            get { return NumeroProf; }
            set { NumeroProf = value; }
        }

        public string Nome
        {
            get { return NomeProf; }
            set { NomeProf = value; }
        }
    }
}
