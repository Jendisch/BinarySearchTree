using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {

        private int number;
        private Node rightSubTree;
        private Node leftSubTree;
        private Node parentTree;

        public Node(int number)
        {
            this.number = number;
            RightSubTree = null;
            LeftSubTree = null;
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public Node RightSubTree
        {
            get
            {
                return rightSubTree;
            }
            set
            {
                rightSubTree = value;
            }
        }

        public Node LeftSubTree
        {
            get
            {
                return leftSubTree;
            }
            set
            {
                leftSubTree = value;
            }
        }

        public Node ParentNode
        {
            get
            {
                return parentTree;
            }
            set
            {
                parentTree = value;
            }
        }
    }
}
