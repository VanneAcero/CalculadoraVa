
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVa
{
    public partial class Form1 : Form
    {
        string signo;
        double operacion = 0;
        double operacion1 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        operacionS sumando = new operacionS();
        operacionR rest = new operacionR();
        operacionM multip = new operacionM();
        operacionD divid = new operacionD();
        operacionP porce = new operacionP();

        private void Form1_Load(object sender, EventArgs e)
        {
            ldtIngreso.Text  = "";
            ldtRespuesta .Text = "";
        }
        private void btnigual_Click(object sender, EventArgs e)
        {

            operacion1 = double.Parse(ldtIngreso.Text);
           
            double sum;            
            double res;
            double mul;
            double div;
            double por;
            switch (signo)
            {
                case "+" :
                    sum = (double)sumando.Sumar((operacion), (operacion1));
                    ldtRespuesta.Text = sum.ToString();
                break;
                case "-":
                    res = (double)rest.Resta((operacion), (operacion1));
                    ldtRespuesta.Text = res.ToString();
                    break;
                case "*":
                    mul = (double)multip.Multiplica((operacion), (operacion1));
                    ldtRespuesta.Text = mul.ToString();
                    break;
                case "/":
                    div = (double)divid.Divide((operacion), (operacion1));
                    ldtRespuesta.Text = div.ToString();
                    break;
                case "%":
                    por = (double)porce.porcentaje((operacion), (operacion1));
                    ldtRespuesta.Text = por.ToString();
                    break;

            }
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            
            signo =  "+";
            if (!string.IsNullOrEmpty(ldtIngreso.Text))
            
            operacion = double.Parse(ldtIngreso.Text);            
            ldtIngreso.Text = "";


        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            signo = "-";
            if (!string.IsNullOrEmpty(ldtIngreso.Text))
                operacion = double.Parse(ldtIngreso.Text);
            ldtIngreso.Text = "";


        }

        private void btnmultipli_Click(object sender, EventArgs e)
        {
            signo = " * ";
            if (!string.IsNullOrEmpty(ldtIngreso.Text))
                operacion = double.Parse(ldtIngreso.Text);
            ldtIngreso.Text = "";

        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            signo = "/ ";
            if (!string.IsNullOrEmpty(ldtIngreso.Text))
                operacion = double.Parse(ldtIngreso.Text);
            ldtIngreso.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ldtIngreso.Text))
            {
                double num = double.Parse(ldtIngreso.Text);
                num = Math.Sqrt(num);
                ldtRespuesta.Text = num.ToString();
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ldtIngreso.Text))
            {
                double num = double.Parse(ldtIngreso.Text);
                num = Math.Sqrt(num);
                ldtRespuesta.Text = num.ToString();
            }

        }
        private void cuadrado_Click(object sender, EventArgs e)
        {
            double num = double.Parse(ldtIngreso.Text);
            num = Math.Pow(num, 2);
            ldtRespuesta.Text = num.ToString();
        }
        private void Limpiar()
        {
            
            ldtIngreso.Text = string.Empty;
            ldtRespuesta.Text = string.Empty;
        }

        
        private void btn0_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "0";
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "1";
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "2";
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "3";
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "4";
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "5";
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "6";
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "7";
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "8";
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = ldtIngreso.Text + "9";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = string.Empty;
            ldtRespuesta.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ldtIngreso.Text.Length == 1)
                ldtIngreso.Text = "";
            else
                ldtIngreso.Text = ldtIngreso.Text.Substring(0, ldtIngreso.Text.Length - 1);


        }

        private void button19_Click(object sender, EventArgs e)
        {
            ldtIngreso.Text = string.Empty;
            ldtRespuesta.Text = string.Empty;
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            if (!ldtIngreso.Text.Contains(".")) ;
            ldtIngreso.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double num = double.Parse(ldtIngreso.Text);
            num *= -1;
            ldtRespuesta.Text = num.ToString();

        }

        private void ldtRespuesta_Click(object sender, EventArgs e)
        {

        }
    }
}
