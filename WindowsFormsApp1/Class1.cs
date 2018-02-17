using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {
        private int numeroaluno;
        private string nomealuno;
        public int Numero
        {
            get { return numeroaluno; }
            set { numeroaluno = value; }
        }
        public string Nome
        {
            get { return nomealuno; }
            set { nomealuno = value; }
        }
    }
}