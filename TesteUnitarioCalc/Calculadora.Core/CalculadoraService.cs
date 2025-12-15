using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Core
{
    public class CalculadoraService
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            
            return a - b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return a / b;
        }

        public class NumeroNegativoException : Exception
        {
            public NumeroNegativoException(string message){}

        }

        public int MultiplicarApenasPositivos(int a, int b) {

                 
            if (a < 0 || b < 0) 
            {
                throw new NumeroNegativoException("Não é possível multiplicar números negativos.");
            }
            return a * b;

        }
    }
}
