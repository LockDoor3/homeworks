using System;

namespace urok3
{
    class urok3_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¬ведите слово:");
            string input = Console.ReadLine();
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            Console.WriteLine(output);

        }
    }
}