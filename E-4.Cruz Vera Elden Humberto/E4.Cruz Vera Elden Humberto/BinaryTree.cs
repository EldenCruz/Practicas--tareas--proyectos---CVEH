using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Cruz_Vera_Elden_Humberto
{
    class BinaryTree
    {
        // Raiz del arbol 
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        //Recorrido Postorden
        public void PrintPostorder(Node node)
        {   // Si el nodo es nulo 
            if (node == null)
                return;

            // pasa por el nodo izquierdo
            PrintPostorder(node.left);

            // pasa por el nodo centro
            PrintPostorder(node.middle);

            // pasa por el nodo derecho
            PrintPostorder(node.right);

            // pasa por la raiz
            Console.Write(node.key + " ");
        }


        // recorrido preorden
        public void PrintPreorder(Node node)
        {   // si el nodo es nullo
            if (node == null)
                return;

            // pasa por la raiz
            Console.Write(node.key + " ");

            // pasa por el nodo izquierdo
            PrintPreorder(node.left);

            // pasa por el nodo del centro
            PrintPreorder(node.middle);

            // pasa por el nodo derecho
            PrintPreorder(node.right);
        }

        public void PrintPostorder() { PrintPostorder(root); }
        public void PrintPreorder() { PrintPreorder(root); }
    }
}
