using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BST
    {

        public Node rootNode;

        public BST()
        {

        }
        public BST(int value)
        {
            rootNode = new Node(value);
        }

        public void AddRoot(int value)
        {
            rootNode = new Node(value);
        }
        public void Insert(int input)
        {
            Node newNode = new Node(input);
            if (rootNode == null)
            {
                AddRoot(input);
            }
            else if (rootNode.RightSubTree == null)
            {
                if (newNode.Number >= rootNode.Number)
                {
                    rootNode.RightSubTree = newNode;
                    newNode.ParentNode = rootNode;
                }
            }
            else if (newNode.Number >= rootNode.Number)
            {
                Add(rootNode.RightSubTree, newNode);
            }
            else if (rootNode.LeftSubTree == null)
            {
                if (newNode.Number < rootNode.Number)
                {
                    rootNode.LeftSubTree = newNode;
                    newNode.ParentNode = rootNode;
                }
            }
            else
            {
                Add(rootNode.LeftSubTree, newNode);
            }
        }

        private void Add(Node workingNode, Node newNode)
        {
            if (newNode.Number >= workingNode.Number && workingNode.RightSubTree == null)
            {
                workingNode.RightSubTree = newNode;
                newNode.ParentNode = workingNode;
            }
            else if (newNode.Number >= workingNode.Number)
                Add(workingNode.RightSubTree, newNode);
            else if (newNode.Number < workingNode.Number && workingNode.LeftSubTree == null)
            {
                workingNode.LeftSubTree = newNode;
                newNode.ParentNode = workingNode;
            }
            else
                Add(workingNode.LeftSubTree, newNode);
        }

        public void Search(int value, Node currentNode = null)
        {
            if (currentNode == null)
            {
                currentNode = rootNode;
                Search(value, currentNode);
            }
            else if (value > currentNode.Number)
            {
                if (currentNode.RightSubTree == null)
                {
                    Console.WriteLine("Your value cannot be found in the binary search tree");
                    return;
                }
                currentNode = currentNode.RightSubTree;
                Console.WriteLine("Take a right down the tree.");
                Search(value, currentNode);
            }
            else if (value < currentNode.Number)
            {
                if (currentNode.LeftSubTree == null)
                {
                    Console.WriteLine("Your value cannot be found in the binary search tree");
                    return;
                }
                currentNode = currentNode.LeftSubTree;
                Console.WriteLine("Take a left down the tree.");
                Search(value, currentNode);
            }
            else if (value == currentNode.Number)
            {
                currentNode.Number = value;
                Console.WriteLine("Your value was found!");
            }
            else
            {
                Console.WriteLine("Your value cannot be found in the binary search tree");
            }
        }
    }
}


