using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Cruz_Vera_Elden_Humberto
{
    class PrintTree
    {
        public void PrintTree1()
        {
            BinaryTree tree = new BinaryTree(); // crea un objeto arbol de BinaryTree

            tree.root = new Node("A");
            tree.root.left = new Node("B");
            tree.root.middle = new Node("C");
            tree.root.right = new Node("D");
            tree.root.left.left = new Node("E");
            tree.root.left.middle = new Node("F");
            tree.root.left.right = new Node("G");
            tree.root.right.left = new Node("H");
            tree.root.right.middle = new Node("I");
            tree.root.right.right = new Node("J");
            tree.root.left.left.left = new Node("K");
            tree.root.left.left.middle = new Node("L");
            tree.root.left.left.right = new Node("M");
            tree.root.left.right.middle = new Node("N");
            tree.root.right.left.middle = new Node("O");
            tree.root.right.right.left = new Node("P");
            tree.root.right.right.right = new Node("Q");
            tree.root.left.right.middle.left = new Node("R");
            tree.root.left.right.middle.right = new Node("S");

            Console.WriteLine("Tree 1");
            Console.WriteLine("Recorrido preorden del arbol es ");
            tree.PrintPreorder();
            Console.WriteLine("\n\nRecorrido postorden del arbol es ");
            tree.PrintPostorder();
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        public void PrintTree2()
        {
            BinaryTree tree = new BinaryTree(); // crea un objeto arbol de BinaryTree

            tree.root = new Node("A");
            tree.root.left = new Node("B");
            tree.root.right = new Node("E");
            tree.root.left.left = new Node("C");
            tree.root.left.right = new Node("D");
            tree.root.right.right = new Node("F");
            tree.root.right.right.left = new Node("G");
            tree.root.right.right.right = new Node("H");

            Console.WriteLine("Tree 2");
            Console.WriteLine("Recorrido preorden " + "del arbol es ");
            tree.PrintPreorder();
            Console.WriteLine();
            Console.WriteLine("\nRecorrido postorden " + "del arbol es ");
            tree.PrintPostorder();
            Console.WriteLine();
            Console.Write("\nPresione una tecla para ver el Grafo: ");
            Console.ReadKey();
        }

        public void PrintGraphe()
        {
            Console.Clear();
            Console.WriteLine("Graphe\nTrayectorias\n");
            Console.WriteLine("Boston a LA");
            Graphe Graphe1 = new Graphe(5);
            Graphe1.Insert(0, 1);
            Graphe1.Insert(1, 2);
            Graphe1.Insert(2, 3);
            Graphe1.InsertCity(0, 1);
            Console.WriteLine("Millas recorridas: 2602 millas");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("\nNew York a San Francisco");
            Graphe Graphe2 = new Graphe(7);
            Graphe2.Insert(0, 1);
            Graphe2.Insert(1, 2);
            Graphe2.Insert(2, 3);
            Graphe2.Insert(4, 5);
            Graphe2.InsertCity(4, 2);
            Console.WriteLine("Millas recorridas: 2534 millas");
            Console.ReadKey();
            Console.WriteLine("\n\nAtlanta a San Francisco");
            Graphe Graphe3 = new Graphe(4);
            Graphe3.Insert(0, 1);
            Graphe3.Insert(1, 2);
            Graphe3.InsertCity(0, 3);
            Console.WriteLine("Millas recorridas: 2461 millas");
            Console.ReadKey();
            Console.WriteLine("\n\nDenver a New York");
            Graphe Graphe4 = new Graphe(4);
            Graphe4.Insert(0, 1);
            Graphe4.Insert(1, 2);
            Graphe4.InsertCity(0, 4);
            Console.WriteLine("Millas recorridas: 1630 millas");
            Console.ReadKey();
        }
    }
}
