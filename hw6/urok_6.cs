using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.fill(10);
            graph.print();
            graph.BFS(1);
            graph.DFS(1);
            Console.ReadKey();
        }
    }
    public class Graph
    {
        UI iu = new();
        private int value { get; set; }
        private List<int>[] list { get; set; }

        public void fill(int c)
        {
            list = new List<int>[c];
            Random rnd = new();
            int random = 0;

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new();
                value = Rnd(0);
                list[i].Add(value);
            }
            for (int i = 0; i < list.Length/2; i++)
            {
                random = rnd.Next(0, 9);
                value = Rnd(0);
                list[random].Add(value);
            }
        }
        public void print()
        {
            iu.print_text();
            iu.space();
            for (int i = 0; i < list.Length; i++)
            {
                foreach (var i in list[i])
                {
                    if(list[i].Count > 1)
                    {
                        Console.WriteLine($"{i}");
                        foreach (var items in list[i])
                        {
                            if(items != item)
                                Console.WriteLine($" ?{i}");
                        }
                        break;
                    }
                    Console.WriteLine(item);
                }
            }
            iu.space();
        }
        public static int Rnd(int a)
        {
            Random x = new();
            string b = "";
            b = Convert.ToString(x.Next(0, 200));

            for (int i = 0; i < b.Length; i++)
            {
                a = x.Next(0, 896);
                return a;
            }
            return a;
        }
        public void DFS(int a)
        {
            iu.DFS_text();
            Stack<Int32> stack = new Stack<int>();

            stack.Push(a);
            for (int b = 0; b < list.Length; b++)
            {
                stack.Pop();
                foreach (int item in list[b])
                {
                    if(list[b].Count > 1)
                    {
                        foreach (var items in list[b])
                        {
                            stack.Push(items);
                        }
                        break;
                    }
                    stack.Push(item);
                }
            }
        }
        public void BFS(int b)
        {
            iu.BFS_text();
            Queue<Int32> queue = new Queue<int>();

            queue.Enqueue(b);
            for(int a = 0; a < list.Length; a++)
            {
                queue.Dequeue();
                foreach (int item in list[a])
                {
                    queue.Enqueue(item);
                    Console.WriteLine($"visited {i}");
                }
            }
            iu.space();
        }
    }
    public class UI
    {
        public void space()
        {
            Console.WriteLine("\a");
        }
        public void BFS_text()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Добро пожаловать в BFS!");
            Console.ResetColor();
        }
        public void DFS_text()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Добро пожаловать в DFS!");
            Console.ResetColor();
            Console.WriteLine("Извините, я понятия не имею, как показать вам, что это работает, но вы можете проверить это с помощью отладки.");
        }
        public void print_text()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("hi monsieur, that's your graph!");
            Console.ResetColor();
        }
    }
}