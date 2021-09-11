using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNet2021.tp2.Logica;
using System;

namespace LabNet2021.tp2.Test
{
    [TestClass]
    public class PuntoUnoTest
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCero_RecibeCienComoDividendo_TiraExcepcion()
        {
            decimal dividendo = 100;

            dividendo.DividirPorCero();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCero_RecibeCeroComoDividendo_TiraExcepcion()
        {
            decimal dividendo = 100;

            dividendo.DividirPorCero();
        }
    }
}
