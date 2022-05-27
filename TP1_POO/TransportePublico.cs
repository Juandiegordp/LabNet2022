using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_POO
{
    public abstract class TransportePublico
    {
        protected TransportePublico(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public int pasajeros { get; set; }

        public abstract string Avanzar();

        public abstract string Detenerse();


    }
}
