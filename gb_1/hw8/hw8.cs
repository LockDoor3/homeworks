using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;


namespace hw8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (File.Exists("appconfig.json"))
            {
                Deserialize("1");
                Console.WriteLine("Вы хотите переписать информацию о себе? (Да/Нет)");
                string answer = Console.ReadLine();
                if (answer == "да" | answer == "Да" | answer == "+")
                {
                    File.Delete("appconfig.json");
                    Serialize("0");
                }
            }
            else
            {
                Serialize("0");
            }
        }

        public static string Serialize(string a)
        {
            Console.WriteLine("Привет!");
            appConfig appconfig = new appConfig();
            Console.WriteLine("Введите имя");
            appconfig.Name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            appconfig.Age = Console.ReadLine();
            Console.WriteLine("Укажите свое место работы");
            appconfig.Work = Console.ReadLine();
            string json = JsonSerializer.Serialize(appconfig);
            File.WriteAllText("appconfig.json", json);
            return a;
        }

        public static string Deserialize(string a)
        {
            appConfig jsondd = JsonSerializer.Deserialize<appConfig>(File.ReadAllText("appconfig.json"));
            Console.WriteLine($"Версия: {jsondd.Version}");
            Console.WriteLine(jsondd.description);
            Console.WriteLine($"Привет, {jsondd.Name}");
            Console.WriteLine($"Возраст: {jsondd.Age}");
            Console.WriteLine($"Место работы: {jsondd.Work} ");
            return a;
        }
    }

    [Serializable]
    public class appConfig
    {
        public string Version
        {
            get
            {
                return "1.0.0";
            }
        }
        public string description
        {
            get
            {
                return "Персональный менеджер";
            }
        }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Work { get; set; }
    }
}