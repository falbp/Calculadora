using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ModeloCalculadora modeloCalculadora = new ModeloCalculadora();
        MetodosCalculadora metodosCalculadora = new MetodosCalculadora();



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "1";
            }
            else
            {
                txtValores.Text = txtValores.Text + "1";
            }
           
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "2";
            }
            else
            {
                txtValores.Text = txtValores.Text + "2";
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "3";
            }
            else
            {
                txtValores.Text = txtValores.Text + "3";
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "4";
            }
            else
            {
                txtValores.Text = txtValores.Text + "3";
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "5";
            }
            else
            {
                txtValores.Text = txtValores.Text + "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if(txtValores.Text == ""){
                txtValores.Text = "6";
            }
            else
            {
                txtValores.Text = txtValores.Text + "6";
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if(txtValores.Text == "")
            {
                txtValores.Text = "7";
            }
            else
            {
                txtValores.Text = txtValores.Text + "7";
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if(txtValores.Text == "")
            {
                txtValores.Text = "8";
            }
            else
            {
                txtValores.Text = txtValores.Text + "8";
            }
           
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "9";
            }
            else
            {
                txtValores.Text = txtValores.Text + "8";
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (txtValores.Text == "")
            {
                txtValores.Text = "0";
            }
            else
            {
                txtValores.Text = txtValores.Text + "0";
            }
           
        }

        private void btnPunto_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtValores.Text.Contains('.') == false)
            {
                this.txtValores.Text = this.txtValores.Text + ".";
            }
        }

        private void btnMenos_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "-";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnMas_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "+";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "/";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "*";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnIgual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                modeloCalculadora.B = double.Parse(this.txtValores.Text);

                switch (modeloCalculadora.C)
                {
                    case "+":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Sumar(modeloCalculadora));
                        break;

                    case "-":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Menos(modeloCalculadora));
                        break;

                    case "*":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Multiplicar(modeloCalculadora));
                        break;

                    case "/":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Dividir(modeloCalculadora));
                        break;

                    case "^":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Potencias(modeloCalculadora));
                        break;

                    case "%":
                        this.txtValores.Text = Convert.ToString(metodosCalculadora.Mod(modeloCalculadora));
                        break;

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error",ex.ToString());
            }            
        }

        private void btnRaizCuadrada_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "√";
            this.txtValores.Clear();
            this.txtValores.Focus();
            this.txtValores.Text = Convert.ToString(metodosCalculadora.RaizCuadrada(modeloCalculadora));
        }

        private void btnPotencias_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "^";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "%";
            this.txtValores.Clear();
            this.txtValores.Focus();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnElevadoAlCubo_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "^3";
            this.txtValores.Clear();
            this.txtValores.Focus();
            this.txtValores.Text = Convert.ToString(metodosCalculadora.PotenciasAlCubo(modeloCalculadora));
        }

        private void btnElevadoAlCuadrado_Click(object sender, RoutedEventArgs e)
        {
            modeloCalculadora.A = double.Parse(txtValores.Text);
            modeloCalculadora.C = "^2";
            this.txtValores.Clear();
            this.txtValores.Focus();
            this.txtValores.Text = Convert.ToString(metodosCalculadora.PotenciasAlCuadrado(modeloCalculadora));

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            this.txtValores.Clear();
        }
    }
}
