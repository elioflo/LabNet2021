using LabNet2021.tp2.Logica;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LabNet2021.tp2.Test
{
    [TestClass]
    public class PuntoCuatroTest
    {
        [TestMethod]
        [ExpectedException(typeof(ExcepcionPersonalizada))]
        public void LlamarMetodo_NoEstaImplementado_TiraExcepcion()
        {
            Logic logic = new Logic();
            logic.UnaExcepcionPersonalizada();
        }
    }
}
