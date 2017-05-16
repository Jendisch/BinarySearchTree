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
        public void Add(int input)
        {
            Node newNode = new Node(input);
            if (newNode.Number >= rootNode.Number && rootNode.RightSubTree == null)
            {
                rootNode.RightSubTree = newNode;
                newNode.ParentNode = rootNode;
            }
            else if (newNode.Number >= rootNode.Number)
                Add(rootNode.RightSubTree, newNode);
            else if (newNode.Number < rootNode.Number && rootNode.LeftSubTree == null)
            {
                rootNode.LeftSubTree = newNode;
                newNode.ParentNode = rootNode;
            }
            else
                Add(rootNode.LeftSubTree, newNode);
        }
        private void Add(Node currentNode, Node newNode)
        {
            if (newNode.Number >= currentNode.Number && currentNode.RightSubTree == null)
            {
                currentNode.RightSubTree = newNode;
                newNode.ParentNode = currentNode;
            }
            else if (newNode.Number >= currentNode.Number)
                Add(currentNode.RightSubTree, newNode);
            else if (newNode.Number < currentNode.Number && currentNode.LeftSubTree == null)
            {
                currentNode.LeftSubTree = newNode;
                newNode.ParentNode = currentNode;
            }
            else
                Add(currentNode.LeftSubTree, newNode);
        }
        public string Find(int data)
        {
            Node currentNode = rootNode;
            try
            {
                while (data != currentNode.Number)
                {
                    if (data > currentNode.Number)
                        currentNode = currentNode.RightSubTree;
                    else
                        currentNode = currentNode.LeftSubTree;
                }
                return "Found it!";
            }
            catch
            {
                return "Unable to find it";
            }
        }

    }
}
