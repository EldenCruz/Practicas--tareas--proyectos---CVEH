using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int Contador2 = 0;
            int Sum;
            int Suma1 = 0;
            int Suma2 = 0;
            int[] Suma4 = new int[4];
            int[] Suma9 = new int[9];
            for (Contador = 0; Contador < 4; Contador++)
            {
                Console.Write("Ingrese el valor {0}: ", Contador + 1);
                Suma4[Contador] = Int16.Parse(Console.ReadLine());

                Suma1 = Suma4[Contador] + Suma1;
            }

            for (Contador = 4; Contador < 9; Contador++)
            {
                Console.Write("Ingresa el valor {0}: ", Contador + 1);
                Suma9[Contador2] = Int16.Parse(Console.ReadLine());

                Suma2 = Suma9[Contador2] + Suma2;
            }

            for (Contador = 9; Contador < 15; Contador++)
            {
                Console.Write("Ingrese el valor {0}: ", Contador + 1);
                Sum = Int16.Parse(Console.ReadLine());
            }

            Console.WriteLine("Suma de los valores: {0} ", Suma1);

            Console.WriteLine("Suma de los valores: {0}", Suma1 + Suma2);
            Console.ReadKey();

        }
    }
}
