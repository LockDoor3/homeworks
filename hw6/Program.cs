using hw6;

BankAccount account = new();
BankAccount account1 = new(2500, "EUR");
BankAccount account2 = new(44500, "JPY");
BankAccount account3 = new(550, "EUR");
BankAccount account4 = new(15060, "USD");

Console.WriteLine(account.ToString());
Console.WriteLine(account3.ToString());

Console.WriteLine(account1.GetHashCode());
Console.WriteLine(account3.GetHashCode());

Console.WriteLine(account2.Equals(account4));
Console.WriteLine(account2.Equals(account2));
Console.WriteLine(account3.Equals(account1));

Console.WriteLine(account3 == account1);
Console.WriteLine(account2 != account1);
Console.WriteLine(account2 != account2);