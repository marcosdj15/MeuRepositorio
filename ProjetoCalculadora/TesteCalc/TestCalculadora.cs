using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoCalculadora;

namespace TesteCalc
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void TestSoma()
        {
             Program s = new Program ();
             int resultado = s.Soma(5,6);
             Assert.AreEqual(11, resultado);
         
        }
    }
}
