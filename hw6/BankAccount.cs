using System;
namespace hw6
{
    public class BankAccount
    {
        private int _idOfAccount;
        private int _balance;
        private string _typeOfBank;
        private static int _idUpper;


        public int Id
        {
            get { return _idOfAccount; }
            set { _idOfAccount += _idUpper; }
        }
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public string Type
        {
            get { return _typeOfBank; }
            set { _typeOfBank = value; }
        }


        public BankAccount() : this(0)
        {
            random();
            _idOfAccount += _idUpper;
        }

        public BankAccount(int bal) : this(bal, string.Empty)
        {
            random();
            _idOfAccount += _idUpper;
        }

        public BankAccount(int bal, string typ)
        {
            random();
            _idOfAccount += _idUpper;
            _balance = bal;
            _typeOfBank = typ;
        }


        public static bool operator ==(BankAccount a, BankAccount b)
        {
            if (a is not null && b is not null)
                return(a.Balance == b.Balance && a.Type == b.Type);
            return false;
        }

        public static bool operator !=(BankAccount a, BankAccount b)
        {
            if (a is not null && b is not null)
                return (a.Balance != b.Balance || a.Type != b.Type);
            return false;
        }

        public override string ToString()
        {
            if (Id != 0 && Balance != 0 && Type != null )
                return (Id,Balance, Type).ToString();

            if (Id != 0)
                return Id.ToString();
            if (Balance != 0)
                return Balance.ToString();

            if (Type != null)
                return Type.ToString();

            else
                return null;
        }

        public override int GetHashCode()
        {
            return (Id, Balance, Type).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BankAccount a = obj as BankAccount;

            if (obj == null)
                return false;

            if (a as BankAccount == null)
                return false;

            return (a.Id == this.Id && a.Balance == this.Balance && a.Type == this.Type);
        }


        public void printInfo()
        {
            if (_typeOfBank != "")
            {
                welcomePrint();
                illusionOfWait();
                Console.WriteLine($"ID: {_idOfAccount}");
                Thread.Sleep(500);
                Console.WriteLine($"Баланс: {_balance}$");
            }
            else
            {
                illusionOfWait();
                Console.WriteLine($"ID: {_idOfAccount}");
                Thread.Sleep(500);
                Console.WriteLine($"Баланс: {_balance}$");
                Console.WriteLine($"Банк: Bitcoin_Bank_America");
            }
        }

        // добавить
        public void addCash(int add)
        {
            _balance += add;
            waiting();
            if (add != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Успех!");
                Console.ResetColor();
                Console.WriteLine($"Баланс: {_balance}$");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неизвестная ошибка, попробуйте еще раз.");
                Console.ResetColor();
            }
        }

        public void transfer(BankAccount bill, int sum)
        {
            waiting();

            if (bill.Balance != 0)
            {
                if (sum == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Успех!");
                    Console.ResetColor();
                }
                else if (sum < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Сумма отправки должна быть больше нуля.");
                    Console.ResetColor();
                }
                else if (bill.Balance >= sum)
                {
                    bill.Balance -= sum;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Успех!");
                    Console.ResetColor();
                    Console.WriteLine($"Баланс: {bill.Balance}$");
                }
                else if (sum > bill.Balance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Отмена от операции. Отсутствие средств.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неизвестная ошибка, попробуйте еще раз.");
                    Console.ResetColor();
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нехватка средств, пополните счет.");
                Console.ResetColor();
            }
        }


        private void random()
        {
            Random random = new();
            _idUpper = random.Next(0, 100);
        }


        private void illusionOfWait()
        {
            Console.Write("Подождите...");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }
            Console.WriteLine("");
        }
        private void waiting()
        {
            Console.Write("Wait");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(650);
                Console.Write(".");
            }
            Console.WriteLine("");
        }

        private void welcomePrint()
        {
            string write = $"Добро пожаловать в: {_typeOfBank}";
            for (int i = 0; i < write.Length; i++)
            {
                Thread.Sleep(300);
                Console.Write(write[i]);
            }
            Console.WriteLine();
        }
    }
}
