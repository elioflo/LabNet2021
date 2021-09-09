using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2021.tp1
{
    class Program
    {
        static List<TransportePublico> Transportes = new List<TransportePublico>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("ATP: App de transporte publico.");
                Console.WriteLine("1-Ingresar transporte publico.");
                Console.WriteLine("2-Mostrar lista de transportes publicos.");
                Console.WriteLine("3-Salir.");
                int opcion = 0;
                while (true)
                {
                    bool EsNumero = Int32.TryParse(Console.ReadLine(), out opcion);
                    bool EsOpcionValida = EsNumero && (opcion == 1 || opcion == 2 || opcion == 3);
                    
                    if (EsOpcionValida) break;

                    Console.WriteLine("Opcion incorrecta! Ingrese un opcion valida:");
                }
                switch (opcion)
                {
                    case 1:
                        IngresarTransporte();
                        break;
                    case 2:
                        MostrarListaDeTransportes();
                        break;
                    default:
                        Console.WriteLine("Adios!");
                        break;
                }

                if(opcion == 3) break;
                
            }

            Console.Read();

        }

        static void MostrarListaDeTransportes()
        {
            Console.WriteLine();
            Console.WriteLine("Mostrando transportes publicos ingresados...");
            Transportes.ForEach(transporte => Console.WriteLine(transporte));
        }
        static void IngresarTransporte()
        {
            Console.WriteLine();
            Console.WriteLine("Tipo de transporte publico a ingresar:");
            Console.WriteLine("1-Omnibus.");
            Console.WriteLine("2-Taxi.");
            int opcion = 0;
            while (true)
            {
                bool EsNumero = Int32.TryParse(Console.ReadLine(), out opcion);
                bool EsOpcionValida = EsNumero && (opcion == 1 || opcion == 2);
                
                if (EsOpcionValida) break;
                
                Console.WriteLine("Opcion incorrecta! Ingrese un opcion valida:");
            }

            switch (opcion)
            {
                case 1:
                    IngresarOmnibus();
                    Console.WriteLine("Omnibus ingresado con exito!");
                    break;
                case 2:
                    IngresarTaxi();
                    Console.WriteLine("Taxi ingresado con exito!");
                    break;
            }

        }

        static void IngresarOmnibus()
        {
            Console.WriteLine();
            Console.WriteLine("Ingresando datos de Omnibus...");
            Console.WriteLine("Ingrese un id (por ej: Linea 60, Trolebus11...):");
            string id = Console.ReadLine();
            Console.WriteLine("Cantidad de pasajeros:");
            int pasajeros;
            while (true)
            {
                bool EsNumero = Int32.TryParse(Console.ReadLine(), out pasajeros);
                bool EsOpcionValida = EsNumero && pasajeros >= 0;

                if (EsOpcionValida) break;

                Console.WriteLine("Opcion incorrecta! Ingrese un opcion valida:");
            }
            Transportes.Add(new Omnibus(id, pasajeros));
        }
        
        static void IngresarTaxi() 
        {
            Console.WriteLine();
            Console.WriteLine("Ingresando datos de Taxi...");
            Console.WriteLine("Ingrese un id (por ej: C11, TAXI01...):");
            string id = Console.ReadLine();
            Console.WriteLine("Cantidad de pasajeros(Cantidad maxima 4 (?)):");
            int pasajeros;
            while (true)
            {
                bool EsNumero = Int32.TryParse(Console.ReadLine(), out pasajeros);
                bool EsOpcionValida = EsNumero && pasajeros >= 0 && pasajeros <= 4;

                if (EsOpcionValida) break;

                Console.WriteLine("Opcion incorrecta! Ingrese un opcion valida:");
            }
            Transportes.Add(new Taxi(id, pasajeros));
        }
    }
}
