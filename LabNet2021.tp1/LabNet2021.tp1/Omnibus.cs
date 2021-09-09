using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp1
{
    class Omnibus : TransportePublico
    {
        public Omnibus(string id, int pasajeros) : base(id, pasajeros)
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
            return $"Omnibus{{Id:{Id}, Pasajeros:{Pasajeros}}}";
        }
    }
}
