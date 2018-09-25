using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE05.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador;
            int CantidadNum;
            double Maximo = 0;
            double[] Ocurrencia;
            int Indice = 0;
            double[] ArregloNum;

            Console.Write("Ingrese la cantidad de números que desee: ");
            CantidadNum = Int16.Parse(Console.ReadLine());

            ArregloNum = new double[CantidadNum];
            Ocurrencia = new double[CantidadNum];

            for (Contador = 0; Contador < CantidadNum; Contador++)
            {
                Console.Write("Capture un número: ");
                ArregloNum[Contador] = double.Parse(Console.ReadLine());

                if (Contador == 0)
                {

                    Maximo = ArregloNum[Contador];
                }

                if (Contador != 0)
                {
                    
                    if (ArregloNum[Contador]> Maximo)
                        Maximo = ArregloNum[Contador];
                }

            }

            for (Contador = 0; Contador < CantidadNum; Contador++)
            {

                if (Maximo == ArregloNum[Contador])
                {
                    Indice = Contador + 1;
                    Ocurrencia[Contador] = Indice;
                    break;    
        
                }
               
            }


            Console.WriteLine("\nEl indice de la primer ocurrencia: {0}", Ocurrencia[Contador]);
           
            Console.ReadKey();
        }
    }
}
