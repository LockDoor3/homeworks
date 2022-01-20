using System;
using System.Collections;
using System.Collections.Generic;

namespace urok_5
{
    public class BinaryTree
    {
        private Tree root;

        public void insert(int value)
        {
            if (root != null)
                root.Insert(value);
            else
                root = new Tree(value);
        }

        public Tree Find(int value)
        {
            if (root != null)
                return root.Find(value);
            else
                return null;
        }
        public void rm(int value)
        {
            Tree current = root;
            Tree parant = root;
            bool isLeftchild = false;
            if (current == null)
                return;
            while (current != null && current.Data != value)
            {
                parant = current;
                if (value < current.Data)
                {
                    current = current.Left;
                    isLeftchild = true;
                }
                else
                {
                    current = current.Right;
                    isLeftchild = false;
                }
            }

            if (current == null)
                return;
            if (current.Right == null && current.Left == null)
            {
                if (current == root)
                    root = null;
                else
                {
                    if (isLeftchild)
                        parant.Left = null;
                    else
                        parant.Right = null;
                }
            }
            else if (current.Right == null)
            {
                if (current == root)
                    root = current.Left;
                else
                {
                    if (isLeftchild)
                        parant.Left = current.Left;
                    else
                    {
                        parant.Right = current.Left;
                    }
                }
            }
            else if (current.Left == null)
            {
                if (current == root)
                    root = current.Right;
                else
                {
                    if (isLeftchild)
                        parant.Left = current.Right;
                    else
                        parant.Right = current.Right;
                }
            }
            else
            {
                Tree successor = GetSuccess(current);
                if (current == root)
                    root = successor;
                else if (isLeftchild)
                    parant.Left = successor;
                else
                    parant.Right = successor;
            }
        }
        private Tree GetSuccess(Tree node)
        {
            Tree parentOfSuccessor = node;
            Tree successor = node;
            Tree current = node.Right;
            while (current != null)
            {
                parentOfSuccessor = successor;
                successor = current;
                current = current.Left;
            }
            if (successor != node.Right)
            {
                parentOfSuccessor.Left = successor.Right;
                successor.Right = node.Right;
            }
            successor.Left = node.Left;
            return successor;
        }
        public void Print()
        {
            root.PrintTree(root);
        }
        public void BFS(BinaryTree tree)
        {
            tree.root.BFS(tree.root);
        }
        public void DFS(BinaryTree tree)
        {
            tree.root.DFS(tree.root);
        }
    }
}