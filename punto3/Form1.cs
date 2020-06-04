using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculadora calculos = new Calculadora();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text += "4";
        }


        private void buttonPunto_Click(object sender, EventArgs e)
        {
            resultado.Text += ".";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (resultado.Text!="")
            {
                resultado.Text += "/";
            }
        }


        private void buttonProducto_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                resultado.Text += "*";
            }

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                resultado.Text += "-";
            }

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "")
            {
                resultado.Text += "+";
            }

        }
        LinkedList<Calculadora> ListaCalculos = new LinkedList<Calculadora>();
        private void buttonIgual_Click(object sender, EventArgs e)
        {

            if (resultado.Text.Contains("+"))
            {
                string[] nums = resultado.Text.Split("+");
                calculos.Numero1 = float.Parse(nums[0], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Numero2 = float.Parse(nums[1], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Operacion = resultado.Text;
                resultado.Text = "";
                resultado.Text += calculos.Suma();
            }
            else if (resultado.Text.Contains("-"))
            {
                string[] nums = resultado.Text.Split("-");
                calculos.Numero1 = float.Parse(nums[0], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Numero2 = float.Parse(nums[1], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Operacion = resultado.Text;
                resultado.Text = "";
                resultado.Text += calculos.Resta();
            }
            else if (resultado.Text.Contains("*"))
            {
                string[] nums = resultado.Text.Split("*");
                calculos.Numero1 = float.Parse(nums[0], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Numero2 = float.Parse(nums[1], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Operacion = resultado.Text;
                resultado.Text = "";
                resultado.Text += calculos.Multiplicacion();
            }
            else if (resultado.Text.Contains("/"))
            {
                string[] nums = resultado.Text.Split("/");
                calculos.Numero1 = float.Parse(nums[0], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Numero2 = float.Parse(nums[1], CultureInfo.InvariantCulture.NumberFormat);
                calculos.Operacion = resultado.Text;
                if (calculos.Numero2!=0)
                {
                    resultado.Text = "";
                    resultado.Text += calculos.Division();
                } else
                {
                    resultado.Text = "Math ERROR";
                }
            }
            calculos.Fecha = DateTime.Now;
            calculos.Operacion += "="+resultado.Text;
            calculos.Operacion = calculos.Fecha.ToShortDateString() + " " + calculos.Fecha.ToShortTimeString() + " --> " + calculos.Operacion;
            Calculadora Ncalculos = new Calculadora();
            Ncalculos.Fecha = calculos.Fecha;
            Ncalculos.Operacion = calculos.Operacion;
            ListaCalculos.AddLast(Ncalculos);
            HLista.Items.Clear();
            foreach (Calculadora item in ListaCalculos)
            {
                HLista.Items.Add(item.Operacion);
            }
            resultado.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==48)
            {
                resultado.Text += "0";
            } 
            else if (e.KeyChar==49)
            {
                resultado.Text += "1";
            } 
            else if (e.KeyChar==50)
            {
                resultado.Text += "2";
            } 
            else if (e.KeyChar==51)
            {
                resultado.Text += "3";
            } 
            else if (e.KeyChar==52)
            {
                resultado.Text += "4";
            } 
            else if (e.KeyChar==53)
            {
                resultado.Text += "5";
            } 
            else if (e.KeyChar==54)
            {
                resultado.Text += "6";
            } 
            else if (e.KeyChar==55)
            {
                resultado.Text += "7";
            } 
            else if (e.KeyChar==56)
            {
                resultado.Text += "8";
            }
            else if (e.KeyChar == 57)
            {
                resultado.Text += "9";
            }
            else if (e.KeyChar == 57)
            {
                resultado.Text += "9";
            }
            else if (e.KeyChar == 42 && resultado.Text != "")
            {
                resultado.Text += "*";
            }
            else if (e.KeyChar == 43 && resultado.Text != "")
            {
                resultado.Text += "+";
            }
            else if (e.KeyChar == 45 && resultado.Text != "")
            {
                resultado.Text += "-";
            }
            else if (e.KeyChar == 46 && resultado.Text != "")
            {
                resultado.Text += ".";
            }
            else if (e.KeyChar == 47 && resultado.Text!="")
            {
                resultado.Text += "/";
            }
        }
        private void HLista_DoubleClick(object sender, EventArgs e)
        {
            foreach (Calculadora item in ListaCalculos)
            {
                if (item.Operacion.CompareTo(HLista.SelectedItem) == 0)
                {
                    calculos = item;
                }
            }
            ListaCalculos.Remove(calculos);
            HLista.Items.Clear();
            foreach (Calculadora item in ListaCalculos)
            {
                HLista.Items.Add(item.Operacion);
            }
        }

        private void HLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonProducto_MouseHover(object sender, EventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

    }
}
