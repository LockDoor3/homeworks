using System;

namespace urok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            string ask = "";
            var lenght = Rnd(0);
            for (int i = 0; i < lenght; i++)
            {
                tree.insert(Rnd(1));
            }
            Console.WriteLine("который из?");
            Console.WriteLine("1) Поиск в ширину");
            Console.WriteLine("2) Поиск в глубину");
            Console.WriteLine("3) Скрыть дерево");
            while (true)
            {
                try
                {
                    ask = Console.ReadLine();
                    if (ask == "1")
                        tree.BFS(tree);
                    else if (ask == "2")
                        tree.DFS(tree);
                    else if (ask == "3")
                        tree.Print();
                    else
                        Console.WriteLine("Выберите число 1-3");
                }
                catch
                {
                }
            }
        }
        public static int Rnd(int a)
        {
            Random x = new();
            BinaryTree btree = new();
            string b = "";
            b = Convert.ToString(x.Next(0, 200));
            for (int i = 0; i < b.Length; i++)
            {
                a = x.Next(0, 200);
                btree.insert(a);
                return a;
            }
            return a;
        }
    }
}