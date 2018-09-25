using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE03.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador;
            int CantidadNum;
            double Ocurrencia = 0;
            int Indice = 0;
            double[] ArregloNum;

            try
            {
                Console.Write("Ingrese la cantidad de números que desee: ");
                CantidadNum = Int16.Parse(Console.ReadLine());

                ArregloNum = new double[CantidadNum];

                for (Contador = 0; Contador < CantidadNum; Contador++)
                {
                    Console.Write("Capture un número: ");
                    ArregloNum[Contador] = double.Parse(Console.ReadLine());


                    if (ArregloNum[Contador] > Ocurrencia)
                    {
                        Ocurrencia = ArregloNum[Contador];
                        Indice = Contador + 1;
                    }

                }

                Console.WriteLine("El indice de la última ocurrencia es: {0}", Indice);

            }

            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                Console.Write("\nPresione una tecla para salir ");
                Console.ReadKey();
            }
        }
    }
}
