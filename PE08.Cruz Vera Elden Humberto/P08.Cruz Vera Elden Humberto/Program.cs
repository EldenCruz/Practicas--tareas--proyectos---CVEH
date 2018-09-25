using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            string AlReves ="";
            string NumeroAux = "";
            

         
                Console.Write("Capture un numero entero de 5 digitos: ");
                Numero = Int32.Parse(Console.ReadLine());

              


                NumeroAux = Numero.ToString();

                for (int Contador = NumeroAux.Length - 1; Contador >= 0; Contador--)
                {
                    AlReves = AlReves + NumeroAux[Contador].ToString();
                }

                Console.WriteLine("\nNumero ingresado: {0}", NumeroAux);

                Console.WriteLine("Número al reves: {0}", AlReves);

                if (AlReves == NumeroAux)
                {
                    Console.WriteLine("\nEl número es palindromo");
                }

                else
                {
                    Console.WriteLine("\nEl número no es palindromo");
                }

                Console.WriteLine("\nPresione una tecla para salir: ");
                Console.ReadKey();
            }
           

            
        
    }
}
