using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp2.Logica
{
    public class Logic
    {

        public void UnaExcepcion()
        {
            throw new NotImplementedException();
        }

        public void UnaExcepcionPersonalizada()
        {
            throw new ExcepcionPersonalizada("Metodo no implementado... necesito mas tiempo!");
        }
    }
}
