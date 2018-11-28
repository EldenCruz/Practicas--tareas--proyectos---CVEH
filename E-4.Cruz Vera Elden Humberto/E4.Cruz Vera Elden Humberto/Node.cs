using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4.Cruz_Vera_Elden_Humberto
{
    class Node
    {
        public string key;
        public Node left, right, middle;

        public Node(string item)
        {
            key = item;
            left = right = middle = null;
        }
    }
}
