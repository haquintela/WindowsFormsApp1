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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Class1.Tutor1 = new Professor(textBox2.Text, Convert.ToInt32(textBox1.Text));

            

            Class1.VTutor[Class1.i]= new Professor(textBox2.Text, Convert.ToInt32(textBox1.Text));
            Class1.i++;

            //listBox1.Items.Add(Class1.Tutor1.Numero);

            listBox1.Items.Add(Class1.VTutor[1].Numero);

            Form3 mform3 = new Form3();

            mform3.Show();



        }
    }
}
