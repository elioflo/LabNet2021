using LabNet2021.tp2.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LabNet2021.tp2.Test
{
    [TestClass]
    public class PuntoDosTest
    {
        [TestMethod]
        public void Dividir_RecibeUnoYDos_DevuelveUnMedio()
        {
            decimal dividendo = 1;
            decimal divisor = 2;
            decimal resultado = dividendo.DividirPor(divisor);

            decimal resultadoEsperado = 0.5M;

            Assert.AreEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_RecibeCienYCero_TiraExcepcion()
        {
            decimal dividendo = 100;
            decimal divisor = 0;
            dividendo.DividirPor(divisor);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir_RecibeCeroYCero_TiraExcepcion()
        {
            decimal dividendo = 0;
            decimal divisor = 0;
            dividendo.DividirPor(divisor);
        }
    }
}
