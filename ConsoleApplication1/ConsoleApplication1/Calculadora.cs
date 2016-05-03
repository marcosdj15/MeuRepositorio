using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculadora
    {
        public double result;

        static void Main(string[] args)
        {
        }

        public int Soma(int a, int b)
        {
            return a + b;
        }

        public double Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multi(int a, int b)
        {
            return a * b;
        }

        public void Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Impossivel Dividir por Zero !!");
            }
            else
            {
                result = a / b;
                Console.WriteLine("O Resultado é : " + result);
            }
            
        } 

    }
}
