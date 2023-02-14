using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class MetodosCalculadora
    {
        public double Sumar(ModeloCalculadora cal) {
            return cal.A + cal.B; 
        }

        public double Menos(ModeloCalculadora cal)
        {
            return cal.A - cal.B;
        }

        public double Multiplicar(ModeloCalculadora cal)
        {
            return cal.A * cal.B;
        }

        public double Dividir(ModeloCalculadora cal)
        {
            return cal.A / cal.B;
        }

        public double RaizCuadrada(ModeloCalculadora cal)
        {
            return Math.Sqrt(cal.A);
        }

        public double Potencias(ModeloCalculadora cal)
        {
            return Math.Pow(cal.A,cal.B);
        }

        public double PotenciasAlCuadrado(ModeloCalculadora cal)
        {
            return Math.Pow(cal.A, 2);
        }

        public double PotenciasAlCubo(ModeloCalculadora cal)
        {
            return Math.Pow(cal.A, 3);
        }

        public double Mod(ModeloCalculadora cal)
        {
            return cal.A % cal.B;
        }
    }
}
