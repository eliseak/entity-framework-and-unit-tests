using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Asserts
{
    public class Calculadora
    {
        public int SomarInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        public double SomarDecimais(double num1, double num2)
        {
            return num1 + num2;
        }

        public int Dividir(int num, int por)
        {
            if (num > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            return num / por;
        }
    }
}
