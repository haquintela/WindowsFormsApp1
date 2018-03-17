using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aluno
    {
        private int NumeroAluno;
        private string NomeAluno;
        private Professor Tutor;

        //Construtor
        public Aluno(string NomeAluno, int NumeroAluno, Professor Tutor)
        {
            this.NumeroAluno= NumeroAluno;
            this.NomeAluno = NomeAluno;
            this.Tutor = Tutor;
        }

        public int Numero
        {
            get { return NumeroAluno; }
            set { NumeroAluno = value; }
        }

        public string Nome
        {
            get { return NomeAluno; }
            set { NomeAluno = value; }
        }

        public Professor Professor
        {
            get { return Tutor; }
            set { Tutor = value; }
        }

    }
}