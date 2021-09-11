using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNet2021.tp2.Logica;

namespace LabNet2021.tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Read();
        }

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Practica ExtensionMethods + Exceptions + Unit Test (Opcional).".ToUpper());
                Console.WriteLine("1-Dividir por cero");
                Console.WriteLine("2-Realizar una division");
                Console.WriteLine("3-Llamar un metodo");
                Console.WriteLine("4-Llamar un metodo (con exception personalizada!)");
                Console.WriteLine("5-Salir");

                decimal opcionElegida = ObtenerInputDecimalValido(1,2,3,4,5);
                switch (opcionElegida)
                {
                    case 1:
                        PuntoUno();
                        break;
                    case 2:
                        PuntoDos();
                        break;
                    case 3:
                        PuntoTres();
                        break;
                    case 4:
                        PuntoCuatro();
                        break;
                    default:
                        Console.WriteLine("Adios!");
                        break;
                }

                if (opcionElegida == 5) break;

            }
        }
        static decimal ObtenerInputDecimalValido(params decimal[] opciones)
        {
            decimal opcion = 0;
            while (true)
            {
                bool esNumero = Decimal.TryParse(Console.ReadLine(), out opcion);
                bool esOpcionValida = opciones.Any()? esNumero && opciones.Contains(opcion): esNumero;

                if (esOpcionValida) break;

                Console.WriteLine("Opcion incorrecta! Ingrese un opcion valida...");
            }
            return opcion;
        }

        static decimal ObtenerInputDecimal()
        {
            decimal numero = 0;
            while (true)
            {
                bool esNumero = Decimal.TryParse(Console.ReadLine(), out numero);
                if (esNumero) break;

                Console.WriteLine("Opss! Ingrese un numero (no muy muy grande)...");
            }
            return numero;
        }

        static void PuntoUno()
        {
            Console.WriteLine();
            Console.WriteLine("Realizando division por cero... ingrese un numero:");
            decimal dividendo = ObtenerInputDecimal();

            try
            {
                decimal resultado = dividendo.DividirPorCero();
                Console.WriteLine($"Realizando division por cero... Resultado: {resultado}");
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Termino de realizarse la operacion.");
            }
        }

        static void PuntoDos()
        {
            try 
            {
                Console.WriteLine("Realizando division... Ingrese dividendo:");
                decimal dividendo = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine("Realizando division... Ingrese divisor:");
                decimal divisor = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine($"Realizando division... Resultado {dividendo.DividirPor(divisor)}");
            } 
            catch (DivideByZeroException e) 
            {
                Console.WriteLine("Para dividir por cero seleccionar la opcion uno.");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Ingresaste un numero muy muy grande!");
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Termino de realizarse la operacion.");
            }

        }

        static void PuntoTres()
        {
            Console.WriteLine("Llamando metodo...");
            try
            {
                Logic logic = new Logic();
                logic.UnaExcepcion();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Mensaje: {e.Message}");
                Console.WriteLine($"Tipo de excepcion: {e.GetType()}");
            }
        }

        static void PuntoCuatro()
        {
            Console.WriteLine("Selecciono la opcion 4");
        }
    }
}
