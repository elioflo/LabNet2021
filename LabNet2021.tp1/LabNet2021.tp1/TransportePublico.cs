using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp1
{
    abstract class TransportePublico
    {
        public string Id { get; private set; }
        public int Pasajeros { get; private set; }

        protected TransportePublico(string id, int pasajeros)
        {
            Id = id;
            Pasajeros = pasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}
