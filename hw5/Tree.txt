using System;
using System.Collections.Generic;

namespace urok_5
{
    public class Tree
    {
        private int data;
        private Tree lefttree;
        private Tree righttree;
        private bool del;

        public int Data { get => data; }
        public Tree Left { get => lefttree; set => lefttree = value; }
        public Tree Right { get => righttree; set => righttree = value; }

        public bool deleted
        {
            get { return del; }
        }

        public Tree(int value)
        {
            data = value;
        }

        public Tree()
        {
        }

        public void Insert(int value)  //вставка
        {
            if (value >= data)
            {
                if (righttree == null)
                    righttree = new Tree(value);
                else
                    righttree.Insert(value);
            }
            else
            {
                if (lefttree == null)
                    lefttree = new Tree(value);
                else
                    lefttree.Insert(value);
            }

        }

        public Tree Find(int value)
        {
            Tree currentT = this;
            while (currentT != null)
            {
                if (value == currentT.data && del == false)
                    return currentT;
                else if (value > currentT.data)
                    currentT = currentT.righttree;
                else
                    currentT = currentT.lefttree;
            }
            return null;
        }
        public void PrintTree(Tree startNode, string indent = "", Side? side = null)
        {
            if (startNode != null)
            {
                var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
                Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Data}");
                indent += new string(' ', 3);
                PrintTree(startNode.Left, indent, Side.Left);
                PrintTree(startNode.Right, indent, Side.Right);
            }
        }
        public enum Side
        {
            Left,
            Right
        }
        public void BFS(Tree tree)
        {
            Queue<Tree> queue = new Queue<Tree>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                Tree x = queue.Dequeue();
                if (x.Right != null)
                    queue.Enqueue(x.Right);
                if (x.Left != null)
                    queue.Enqueue(x.Left);
                Console.WriteLine(" " + x.Data);
            }
        }
        public void DFS(Tree tree)
        {
            Stack<Tree> stack = new Stack<Tree>();
            stack.Push(tree);

            while (stack.Count > 0)
            {
                Tree a = stack.Pop();
                if (a.Right != null)
                    stack.Push(a.Right);
                if (a.Left != null)
                    stack.Push(a.Left);
                Console.WriteLine(" " + a.Data);
            }
        }
    }
} 