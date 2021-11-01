using System;

namespace hw9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            Exceptions();
        }

        static int Formul(int num)
        {
            var d = 0;
            var i = 2;
            num = Convert.ToInt32(Console.ReadLine());
            for (int b = 0; b < num - 1; b++)
            {
                if (i < num)
                {
                    if (num % i == 0)
                    {
                        d += 1;
                        i += 1;
                    }
                    else
                    {
                        i += 1;
                    }
                }

                else
                {
                    if (d == 0)
                    {
                        Console.WriteLine("Простое");

                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Не простое");

                        Console.ReadKey();
                    }
                }
            }
            return num;
        }

        static string Exceptions()
        {

            try
            {
                Formul(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, попробуйте еще раз");
            }
            Console.ReadKey();
            return "";
        }
    }
}