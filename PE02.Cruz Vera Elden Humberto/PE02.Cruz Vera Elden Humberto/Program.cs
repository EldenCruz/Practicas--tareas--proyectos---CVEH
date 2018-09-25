using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE02.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int Cantidad = 0;
            string[] Arreglo;

            try
            {
                Console.Write("Ingrese la cantidad de datos que usted desea ingresar: ");
                Cantidad = Int16.Parse(Console.ReadLine());

                Arreglo = new string[Cantidad];
                Console.WriteLine();

                for (Contador = 0; Contador < Cantidad; Contador++)
                {
                    Console.Write("Ingrese un valor: ");
                    Arreglo[Contador] = Console.ReadLine();
                }

                Console.WriteLine();


                for (Contador = Cantidad - 1; Contador > -1; Contador--)
                {
                    Console.WriteLine("Valor {0}: {1}", Contador + 1, Arreglo[Contador]);
                }

            }

            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.Write("Presione una tecla para salir ");
                Console.ReadKey();
            }
        }
    }
}
