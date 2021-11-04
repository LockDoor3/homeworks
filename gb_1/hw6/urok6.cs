using System;
using System.Diagnostics;
using System.Threading;

namespace urok6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("\n1 - Завершить процесс \n2 - Просмотреть список процессов \n3 - Выйти \n");

                var answer1 = Console.ReadLine();


                if (answer1 == "1")
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("\n1 - Завершить по имени \n2 - Завершить по ID \n3 - Отмена \n");

                    var answer2 = Console.ReadLine();

                    if (answer2 == "1")
                    {
                        Console.WriteLine("Введите имя процесса");

                        Process[] process = Process.GetProcessesByName(Convert.ToString(Console.ReadLine()));

                        for (int i = 0; i < process.Length; i++)
                        {
                            process[i].Kill();
                        }

                        Console.WriteLine(write.Succsessfully(""));
                    }
                    else if (answer2 == "2")
                    {
                        Console.WriteLine("Введите ID процесса");

                        Process process = Process.GetProcessById(Convert.ToInt16(Console.ReadLine()));
                        process.Kill();

                        Console.WriteLine(write.Succsessfully(""));
                    }
                    else if (answer2 == "3")
                    {
                        Console.WriteLine(write.Declined(""));
                    }
                    else
                    {
                        Console.WriteLine("Введите корректный ответ!");
                    }
                }
                else if (answer1 == "2")
                {
                    try
                    {
                        Process[] a = Process.GetProcesses();

                        for (int i = 0; i < a.Length / 2; i++)
                        {

                            Process[] c = Process.GetProcesses();
                            Console.WriteLine($"Name: {c[i].ProcessName}");
                            Console.WriteLine($"ID: {c[i].Id}");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error happened");

                    }
                }

                else if (answer1 == "3")
                {
                    Console.WriteLine("Введите корректный ответ!");
                }
            } while (true);

        }
    }


    public class write
    {
        public static string Succsessfully(string a)
        {
            Console.WriteLine("Готово!");
            return a;
        }
        public static string Declined(string b)
        {
            Console.WriteLine("Отменено");
            return b;
        }
    }
}