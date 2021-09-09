using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp1
{
    class Taxi : TransportePublico
    {
        public Taxi(string id, int pasajeros) : base(id, pasajeros)
        {
        }

        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Taxi{{Id:{Id}, Pasajeros:{Pasajeros}}}";
        }
    }
}
