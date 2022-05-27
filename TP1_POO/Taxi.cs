using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP1_POO
{
    public class Taxi : TransportePublico
    {
        public Taxi(int pasajeros) : base(pasajeros)
        {

        }

        public override string Avanzar()
        {
            Random r = new Random();
            Thread.Sleep(25);
            return $"Voy a {r.Next(45,81)} km/h";
        }

        public override string Detenerse()
        {
            return $"Me detuve";
        }

        public override string ToString()
        {
            return $"Soy un taxi con {this.pasajeros} pasajeros ";
        }

    }
}
