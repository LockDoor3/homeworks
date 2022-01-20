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
                Console.WriteLine("�������� ��������: ");
                Console.WriteLine("\n1 - ��������� ������� \n2 - ����������� ������ ��������� \n3 - ����� \n");

                var answer1 = Console.ReadLine();


                if (answer1 == "1")
                {
                    Console.WriteLine("�������� ��������:");
                    Console.WriteLine("\n1 - ��������� �� ����� \n2 - ��������� �� ID \n3 - ������ \n");

                    var answer2 = Console.ReadLine();

                    if (answer2 == "1")
                    {
                        Console.WriteLine("������� ��� ��������");

                        Process[] process = Process.GetProcessesByName(Convert.ToString(Console.ReadLine()));

                        for (int i = 0; i < process.Length; i++)
                        {
                            process[i].Kill();
                        }

                        Console.WriteLine(write.Succsessfully(""));
                    }
                    else if (answer2 == "2")
                    {
                        Console.WriteLine("������� ID ��������");

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
                        Console.WriteLine("������� ���������� �����!");
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
                    Console.WriteLine("������� ���������� �����!");
                }
            } while (true);

        }
    }


    public class write
    {
        public static string Succsessfully(string a)
        {
            Console.WriteLine("������!");
            return a;
        }
        public static string Declined(string b)
        {
            Console.WriteLine("��������");
            return b;
        }
    }
}