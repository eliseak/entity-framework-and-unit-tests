using System;

namespace Calculadora
{
    public class CalculadoraSimples
    {
        // Adiciona dois números
        public int Adicionar (int parcela1, int parcela2)
        {
            return parcela1 + parcela2;
        }

        // Multiplica dois números
        public int Multiplicar(int fator1, int fator2)
        {
            // Demo:
            //return n1 + n2; 

            //Correção:
            return fator1 * fator2;
        }

        // Subtrai dois números
        public int Subtrair (int aditivo, int subtrativo)
        {
            return aditivo - subtrativo;
        }

        // Divide dois números
        public float Dividir (int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

    }
}
