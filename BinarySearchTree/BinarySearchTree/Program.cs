﻿using System;
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
        }
    }
}




//public void Add(Node<T> node, T value)
//{
//    if (root == null)
//    {
//        root = new Node<T>(value);
//        count++;
//    }
//    else if (value.CompareTo(node.NodeValue) == 0)
//    {
//        throw new Exception("Unable to add because this value already exists in the tree.");
//    }
//    else if (value.CompareTo(node.NodeValue) < 0)
//    {
//        if (node.LeftChild == null)
//        {
//            node.LeftChild = new Node<T>(value);
//            node.LeftChild.Parent = node;
//            count++;
//        }
//        else
//        {
//            Add(node.LeftChild, value);
//        }
//    }
//    else
//    {
//        if (node.RightChild == null)
//        {
//            node.RightChild = new Node<T>(value);
//            node.RightChild.Parent = node;
//            count++;
//        }
//        else
//        {
//            Add(node.RightChild, value);
//        }
//    }
//}

//public bool Search(T value)
//{
//    Node<T> current = root;
//    while (current != null)
//    {
//        if (current.NodeValue.Equals(value))
//        {
//            return true;
//        }
//        current = value.CompareTo(current.NodeValue) < 0 ? current.LeftChild : current.RightChild;
//    }
//    return false;
//}