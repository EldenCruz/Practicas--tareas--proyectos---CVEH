using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE07.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumsAleatorio = new Random();

            int[] ArregloNumero = new int[100];

            for(int Contador = 0; Contador<100; Contador++)
            {
                ArregloNumero[Contador] = NumsAleatorio.Next();
            }

            int Auxiliar;
            int Contador2 = 0;
            int Contador3 = 0;

            for (Contador2 = 1; Contador2 < ArregloNumero.Length; Contador2++)
                for (Contador3 = ArregloNumero.Length - 1; Contador3 >= Contador2; Contador3--)
                {
                    if (ArregloNumero[Contador3 - 1] > ArregloNumero[Contador3])
                    {
                        Auxiliar = ArregloNumero[Contador3 - 1];
                        ArregloNumero[Contador3 - 1] = ArregloNumero[Contador3];
                        ArregloNumero[Contador3] = Auxiliar;
                    }
                }

            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int Contador = 0; Contador < ArregloNumero.Length; Contador++)
            {
                Console.WriteLine(ArregloNumero[Contador] + "  ");
            }

            Console.ReadKey();

        }
    }
}
