using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //int targetKey;
    class Tree
    {
        List<int> treeList = new List<int>();
        public Node root;
        public int targetData;
        public Tree()
        {
            root = null;
        }
        public Node RootReturn()
        {
            return root;
        }
        public void Add(int newId)
        {
            Node newNode = new Node();
            newNode.number = newId;
            if (root == null)
            {
                root = newNode;
                treeList.Add(newNode.number);
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (newId < current.number)
                    {
                        current = current.leftSub;
                        if (current == null)
                        {
                            parent.leftSub = newNode;
                            treeList.Add(newNode.number);
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightSub;
                        if (current == null)
                        {
                            parent.rightSub = newNode;
                            treeList.Add(newNode.number);
                            return;
                        }
                    }
                    
                }
                
            }

        }
        public void UserInputForSearch()
        {
            Console.WriteLine("What number would like to search for?");
            targetData = Int32.Parse(Console.ReadLine());
            SearchTree();
        }
        public bool SearchTree()
        {
            bool setSearch = false;
            for (int i = 0; i < treeList.Count; i++)
            {
                if (treeList[i] == targetData)
                {
                    Console.WriteLine("Data is present in tree!");
                    Console.ReadLine();
                    setSearch = true;
                }
                else if (i <= treeList.Count)
                {

                    setSearch = false;
                }
                else
                {
                    Console.WriteLine("Data is not present in tree!");
                    Console.ReadLine();

                    setSearch = true;
                }
             
            }
            return setSearch;
        }
    }

}
