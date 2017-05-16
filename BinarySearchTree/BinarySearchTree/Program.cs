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

            BST theTree = new BinarySearchTree.BST();

            //Add Root Number
            theTree.Insert(30);
            
            //Add Nodes
            theTree.Insert(60);
            theTree.Insert(10);
            theTree.Insert(29);
            theTree.Insert(47);
            theTree.Insert(44);
            theTree.Insert(18);
            theTree.Insert(55);
            theTree.Insert(50);
            theTree.Insert(1);
            theTree.Insert(7);
            theTree.Insert(33);
            theTree.Insert(4);
            theTree.Insert(24);
            theTree.Insert(34);
            theTree.Insert(15);
            theTree.Insert(12);

            //Search For Number
            theTree.Search(12);
            Console.ReadKey();
        }
    }
}

