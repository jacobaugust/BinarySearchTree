using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Add(20);
            theTree.Add(25);
            theTree.Add(45);
            theTree.Add(15);
            theTree.Add(67);
            theTree.Add(43);
            theTree.Add(80);
            theTree.Add(33);
            theTree.Add(67);
            theTree.Add(99);
            theTree.Add(91);
            theTree.UserInputForSearch();
            Console.ReadLine();

        }
    }
}
