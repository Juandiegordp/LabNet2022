using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP1_POO
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            Random r = new Random();
            Thread.Sleep(25);
            return $"Voy a {r.Next(10,41)} km/h";

        }
        public override string Detenerse()
        {
            return $"Me detuve";
        }

        public override string ToString()
        {
            return $"Soy un Omnibus con {this.pasajeros} pasajeros";
        }
    }
}
