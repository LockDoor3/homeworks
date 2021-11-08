using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Security.Cryptography;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Benchmark).Assembly).Run(args);
            Console.ReadKey();
        }
    }
    [StatisticalTestColumn]
    [LongRunJob]
    [MemoryDiagnoser]
    [MinColumn, MaxColumn]
    [KeepBenchmarkFiles]
    [AsciiDocExporter]

    public class Benchmark
    {
        public struct PointStruct
        {
            public int X;
            public int Y;
        }
        public class PointClass
        {
            public int X;
            public int Y;
        }
        public float PointDistance()
        {
            PointStruct pointOne = new PointStruct();
            PointStruct pointTwo = new PointStruct();
            pointOne.X = 1;
            pointOne.Y = 2;
            pointTwo.X = 5;
            pointTwo.Y = 6;
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public float PointDistanceC()
        {
            PointClass pointOne = new PointClass();
            PointClass pointTwo = new PointClass();
            pointOne.X = 5;
            pointOne.Y = 30;
            pointTwo.X = 90;
            pointTwo.Y = 15;
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public double PointDistanceDouble()
        {
            PointStruct pointOne = new PointStruct();
            PointStruct pointTwo = new PointStruct();
            pointOne.X = 10;
            pointOne.Y = 5;
            pointTwo.X = 15;
            pointTwo.Y = 6;
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public float PointDistanceShort()
        {
            PointStruct pointOne = new PointStruct();
            PointStruct pointTwo = new PointStruct();
            pointOne.X = 25;
            pointOne.Y = 3;
            pointTwo.X = 15;
            pointTwo.Y = 4;
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        [Benchmark]
        public void test_1()
        {
            PointDistance();
        }
        [Benchmark]
        public void test_2()
        {
            PointDistanceC();
        }
        [Benchmark]
        public void test_3()
        {
            PointDistanceDouble();
        }
        [Benchmark]
        public void test_4()
        {
            PointDistanceShort();
        }
    }
}