using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int number;
        public Node leftSub;
        public Node rightSub;

        public void DisplayNode()
        {
            Console.WriteLine(number + " ");
        }

    }

}
