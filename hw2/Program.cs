using System;

namespace projectBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount test0 = new();
            test0.printInfo();
            test0.addCash(9842);
            Console.WriteLine("");

            BankAccount test1 = new(10260);
            test1.printInfo();
            test1.sendCash(22500);
            test1.addCash(0);
            Console.WriteLine("");

            BankAccount test2 = new(1986, "Bank");
            test2.printInfo();
            test2.sendCash(2022);
            test2.addCash(100);
            Console.WriteLine("");

            string enter = "";
            enter = chooseBank(enter);
            Console.WriteLine("Сколько вы хотите поставить?");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            BankAccount test3 = new(money, enter);
            test3.printInfo();
            Console.WriteLine("Сколько вы хотите добавить?");
            test3.addCash(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Сколько вы хотите отправить?");
            test3.sendCash(Convert.ToInt32(Console.ReadLine()));
        }

        private static void banksTable()
        {
            Console.WriteLine($"1) {enumBanks.Sberbank}");
            Console.WriteLine($"2) {enumBanks.Alpha}");
            Console.WriteLine($"3) {enumBanks.Tinkoff}");
            Console.WriteLine($"4) {enumBanks.VTB}");
        }

        private static string chooseBank(string userenter)
        {
            int _numberbank;
            Console.WriteLine("Выберете банк:");
            banksTable();
            _numberbank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (_numberbank)
            {
                case 1:
                    userenter = "Sberbank";
                    break;
                case 2:
                    userenter = "Alpha";
                    break;
                case 3:
                    userenter = "Tinkoff";
                    break;
                case 4:
                    userenter = "VTB";
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Выберете число!");
                    userenter = "";
                    Console.ResetColor();
                    break;
            }
            return userenter;
        }
    }
}