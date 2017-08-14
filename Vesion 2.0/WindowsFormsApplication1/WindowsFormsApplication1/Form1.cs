using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            double imc;
            peso =double.Parse( textBox1.Text);
            altura = double.Parse(textBox2.Text)/100;
            imc = peso/(altura * altura);
            textBox3.Text = ""+imc;
            if (imc > 18.5 && imc < 24.9)
            {
                textBox4.Text = "Promedio";
            }

            if (imc > 25 && imc < 29.9)
            {
                textBox4.Text = "Aumentado";
            }

            if (imc > 30 && imc < 34.9)
            {
                textBox4.Text = "Moderado";
            }

            if (imc > 35 && imc < 39.9)
            {
                textBox4.Text = "Severo";
            }
            if (imc > 40)
            {
                textBox4.Text = "Muy Severo";
            }
        }


    }
}
