using System;

namespace urok4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFullName("���������", "����", "��������");
            GetFullName("�������", "������", "����������");
            GetFullName("��������", "�������", "�������������");
        }

        static void GetFullName(string lastName, string firstName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }
    }
}