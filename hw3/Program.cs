using System;
using System.IO;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string Start = "/Users/pc/Desktop/mail.txt";
            string Mail = "/Users/pc/Desktop/mail2.txt";

            s = File.ReadAllText(Start);
            SearchMail(ref s);
            File.AppendAllText(Mail, s);
        }
        public static string SearchMail(ref string s)
        {
            var splited = s.Split('&', '\n');
            s = "";

            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i].Contains('@'))
                    s += $"\n {splited[i]}";
            }

            return s;
        }
    }
}
