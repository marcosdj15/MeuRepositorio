using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace TestCalculadora
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculadora s = new Calculadora();
            int Resultado = s.Soma(4,6);
            Console.WriteLine("Resultado é :" + Resultado);
 
        }
    }
}
