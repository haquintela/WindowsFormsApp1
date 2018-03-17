using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Aluno aluno1, aluno2;
        private Professor prof1;

        public Form1()
        {
            InitializeComponent();
            
    }

        private void Button1_Click(object sender, EventArgs e)
        {

            Professor t1 = new Professor("Helder Q.", 12345);

            aluno1 = new Aluno("Manuel", 1234, t1);

            textBox1.Text = aluno1.Professor.Nome;

            listb.Items.Add(aluno1.Numero + " - " + aluno1.Nome);

            //Array de objetos
            Aluno[] turma = new Aluno[100];

            turma[1] = new Aluno("",0,t1);

            turma[1].Nome = "José";

            listb.Items.Add(turma[1].Professor.Nome);
            
 
            
        }
    }
}
