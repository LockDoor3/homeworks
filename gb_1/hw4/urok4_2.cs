using System;

namespace urok4_2
{

    class Program
    {
        enum season { NaN, Winter, Spring, Summer, Autumn }
        static season OfMonth(int n)
        {
            try
            {
                if (n <= 0 || n > 12)
                    throw new Exception("������: ������� ����� �� 1 �� 12");
                switch ((n % 12) / 3)
                {
                    case 0:
                        return season.Winter;
                    case 1:
                        return season.Spring;
                    case 2:
                        return season.Summer;
                    default: return season.Autumn;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return season.NaN;
            }
        }
        static string Season(season s)
        {
            switch (s)
            {
                case season.Winter:
                    return "����";
                case season.Spring:
                    return "�����";
                case season.Summer:
                    return "����";
                case season.Autumn:
                    return "�����";
                default: return "";
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("������� ����� ������: ");
                Console.WriteLine(Season(OfMonth(Convert.ToInt32(Console.ReadLine()))));
            }
            while (true);
        }

    }
}