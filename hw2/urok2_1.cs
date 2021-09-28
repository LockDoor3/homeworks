using System;

namespace urok2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите минимальную температуру:");
            string a1 = Console.ReadLine();
            int a = int.Parse(a1);
            Console.WriteLine("¬ведите максимальную температуру:");
            string b1 = Console.ReadLine();
            int b = int.Parse(b1);
            int c = (a + b) / 2;
            Console.WriteLine($"—редн€€ температура: {c}");
        }
    }
}
