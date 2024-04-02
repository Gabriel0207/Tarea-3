using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendiendo__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            intronombre.Clear();
            horaxprecio.Clear();
            trabajadas.Clear(); 
            horaex.Clear();
            precioxhoraex.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //salida
            horatrabajo.Text= "";
            horasextra.Text = "";
            precioxhora.Text = "";
            preciohoraex.Text = "";
            sueldobrutotex.Text = "";
            cobros.Text = "";
            sueldofinal.Text = "";
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //variables
            double HT, HX, PH, PHX, sueldobruto, sueldoneto, descuento;
            //Entrada de datos
            HT = Convert.ToDouble(trabajadas.Text);
            HX =  Convert.ToDouble(horaex.Text);
            PH = Convert.ToDouble(precioxhoraex.Text);
            PHX = Convert.ToDouble(horaxprecio.Text);
            //procesos
            sueldobruto = ((HT * PH) + (HX * PHX));
            descuento = 0.18;
            sueldoneto = sueldobruto * descuento;
            horatrabajo.Text = HT.ToString();
            horasextra.Text = HX.ToString();
            preciohoraex.Text = PH.ToString();
            precioxhora.Text = PHX.ToString();
            sueldobrutotex.Text = sueldobruto.ToString();
            sueldofinal.Text = sueldoneto.ToString();
        }

        private void sueldofinal_Click(object sender, EventArgs e)
        {

        }
    }
}
