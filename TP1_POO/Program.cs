using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TP1_POO
{
    internal class Program
    {
        public static List<TransportePublico> aleatorios()
        {
            Random r = new Random();
            List<TransportePublico> transportes = new List<TransportePublico>()
            {
                new Omnibus(r.Next(10, 101)),
                new Omnibus(r.Next(10,101)),
                new Omnibus(r.Next(10,101)),
                new Omnibus(r.Next(10,101)),
                new Omnibus(r.Next(10,101)),
                new Taxi(r.Next(1,5)),
                new Taxi(r.Next(1,5)),
                new Taxi(r.Next(1,5)),
                new Taxi(r.Next(1,5)),
                new Taxi(r.Next(1,5))
            };
            return transportes;

        }

        
        public static List<TransportePublico> ingresos()
        {
            Console.Clear();
            Random r = new Random();
            List<TransportePublico> transportes = new List<TransportePublico>();
            for (int i = 0; i<10; i++)
            {
                if (i<5)
                {
                    System.Console.Write("Ingrese cantidad pasajeros para el omnibus: ");
                    transportes.Add(new Omnibus(Int32.Parse(System.Console.ReadLine())));
                }
                else
                {
                    System.Console.Write("Ingrese cantidad pasajeros para el auto: ");
                    transportes.Add(new Taxi(Int32.Parse(System.Console.ReadLine())));
                }
            }
            return transportes;
        }

        public static void listarTransportes(List<TransportePublico> transportes)
        {
            Console.Clear();
            foreach (TransportePublico transporte in transportes)
            {
                System.Console.WriteLine(transporte.ToString() + " y " + transporte.Avanzar());
            }
            System.Console.ReadKey();

        }
        static void Main(string[] args)
        {
            int opc = 0;
            do
            {
                Console.Clear();
                List<TransportePublico> transportes = new List<TransportePublico>();
                System.Console.WriteLine("Bienvenido!");
                System.Console.WriteLine("1) Realizar con aleatorios");
                System.Console.WriteLine("2) Realizar con ingresos");
                System.Console.Write("Ingrese opcion (0 salir): ");
                opc = Int32.Parse(System.Console.ReadLine());
                switch (opc) {
                    case 1:
                        transportes = aleatorios();
                        listarTransportes(transportes);
                        break;
                    case 2:
                        transportes = ingresos();
                        listarTransportes(transportes);
                        break;

                }
            } while (opc != 0);

            System.Console.WriteLine("Nos vemos!");
            System.Console.ReadKey();
        }
    }
}
