using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");

            string name = Console.ReadLine();

            Console.Write($"Привет, {name}, сегодня {DateTime.Now}");
        }
    }
}
