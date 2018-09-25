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
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Minimo = 0;

            try
            {
                Console.Write("Ingrese el primer número: ");
                Num1 = Int16.Parse(Console.ReadLine());

                Console.Write("Ingrese el primer número: ");
                Num2 = Int16.Parse(Console.ReadLine());

                Console.Write("Ingrese el primer número: ");
                Num3 = Int16.Parse(Console.ReadLine());

                if (Num1 < Num2)
                {
                    Minimo = Num1;
                    if (Num1 < Num3)
                        Minimo = Num1;
                    else
                        Minimo = Num3;
                }
                else
                {
                    Minimo = Num2;
                    if (Num2 < Num3)
                        Minimo = Num2;
                    else
                        Minimo = Num3;
                }
                Console.Write("\nEl valor minimo es: {0}", Minimo);
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
