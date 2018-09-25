using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01mejor.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int CantNum = 0;
            int Min = 0;
            int Max = 0;
            int Numero;

            try
            {
                Console.Write("Por favor ingrese la cantidad de números: ");
                CantNum = Int16.Parse(Console.ReadLine());

                Console.WriteLine();

                for (Contador = 0; Contador < CantNum; Contador++)
                {
                    Console.Write("Ingrese un valor: ");
                    Numero = Int16.Parse(Console.ReadLine());

                    if (Contador == 0)
                    {
                        Min = Numero;
                        Max = Numero;
                    }

                    if (Contador != 0)
                    {
                        if (Numero < Min)
                            Min = Numero;
                        if (Numero > Max)
                            Max = Numero;
                    }
                }

                Console.WriteLine("\nValor minimo: {0}", Min);
                Console.WriteLine("Valor maximo: {0}", Max);
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
