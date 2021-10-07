using System;
using System.IO;

namespace urok5_2
{
    
    class Program
    {
        static void Main()
        {
            File.WriteAllText("D:\\startup.txt", $"{DateTime.Now}");
        }
    }
}