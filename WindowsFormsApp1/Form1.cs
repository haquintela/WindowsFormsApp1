﻿using System;
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
        

        public Form1()
        {
            InitializeComponent();
            
    }

        private void Button1_Click(object sender, EventArgs e)
        {
            aluno1 = new Aluno();
            aluno1.Nome = "José";
            MessageBox.Show(aluno1.Nome);
                  
        }
    }
}
