using System;

namespace urok2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� �����:");
            var x1 = Console.ReadLine();
            var x = int.Parse(x1);
            if ((x % 2) == 0)
            {
                Console.WriteLine("������");
            }
            else
            {
                Console.WriteLine("��������");
            }

        }
        }
    }