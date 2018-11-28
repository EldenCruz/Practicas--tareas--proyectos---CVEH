using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Cruz_Vera_Elden_Humberto
{
    class Graphe
    {
        public int Vertices { get; set; } 
        List<int>[] Lista;
        public Graphe(int Valor) 
        {
            Vertices = Valor;  
            Lista = new List<int>[Valor]; 
            for (int i = 0; i < Valor; i++)
            {
                Lista[i] = new List<int>();
            }
        }

        public void Insert(int Indice, int Valor) 
        {
            Lista[Indice].Add(Valor); 
        }



        public void InsertCity(int Valor, int Dato) 
        {
            List<string> City = new List<string>();
            if (Dato == 1 || Dato == 2)
            {
                City.Add("Boston");
                City.Add("Chicago");
                City.Add("Denver");
                City.Add("LA");
                City.Add("New York");
                City.Add("San Francisco");
                City.Add("Miami");
                City.Add("Atlanta");
            }
            if (Dato == 3)
            {
                City.Add("Atlanta");
                City.Add("Chicago");
                City.Add("San Francisco");
                City.Add("Boston");
                City.Add("Denver");
                City.Add("LA");
                City.Add("New York");
                City.Add("Miami");
            }
            if (Dato == 4)
            {
                City.Add("Denver");
                City.Add("Chicago");
                City.Add("New York");
                City.Add("Atlanta");
                City.Add("San Francisco");
                City.Add("Boston");
                City.Add("LA");
                City.Add("Miami");
            }

            bool[] Visita = new bool[Vertices]; 
            Stack<int> Pila = new Stack<int>();  
            Visita[Valor] = true; 
            Pila.Push(Valor); 
            
                   
            while (Pila.Count != 0) 
            {
                Valor = Pila.Pop(); 
                Console.Write("{0}-> ", City[Valor]);                 
                foreach (int item in Lista[Valor]) 
                {
                    if (!Visita[item]) 
                    {
                        Visita[item] = true; 
                        Pila.Push(item);
                    }
                }
            }
            Console.WriteLine("Ruta Finalizada");
            
        }
    }
}
