using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp2.Logica
{
    public static class DecimalExtensions
    {
        public static decimal DividirPorCero(this decimal dividendo)
        {
            return dividendo / 0;
        }

        public static decimal DividirPor(this decimal dividendo, decimal divisor)
        {
            return dividendo / divisor;
        }
    }
}
