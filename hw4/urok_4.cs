using System;
using System.Linq;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Diagnosers;

namespace urok4
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Tests>();
            Console.ReadKey();
        }

    }

    [StatisticalTestColumn]
    [LongRunJob]
    [MemoryDiagnoser]
    [MinColumn, MaxColumn]
    [KeepBenchmarkFiles]
    [AsciiDocExporter]

    public class Tests
    {
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxz{}[]+=_-/?^%$#@!&*()0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string searchstr(string a)
        {
            a += RandomString(20000);
            foreach (var item in a)
            {

            }
            return a;
        }
        private HashSet<string> hash(HashSet<string> a)
        {
            while(a.Count < 20000)
                a.Add(RandomString(1));
            return a;
        }
        private void searchhash()
        {
            HashSet<string> a = new HashSet<string>();
            foreach (var item in a)
            {

            }
        }

        [Benchmark]
        public void testarray() => searchstr("");
        [Benchmark]
        public void testhash() => searchhash();

    }
