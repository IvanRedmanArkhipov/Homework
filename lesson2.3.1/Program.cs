using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace lesson2._3._1
{
    public class PointClass
    {
        public int X;
        public int Y;
    }
    public struct PointStruct
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            PointClass a = new PointClass();
            PointClass b = new PointClass();
            PointStruct c = new PointStruct();
            PointStruct d = new PointStruct();
            a.X = rnd.Next(1, 10);
            a.Y = rnd.Next(1, 10);
            b.X = rnd.Next(1, 10);
            b.Y = rnd.Next(1, 10);
            c.X = a.X;
            c.Y = a.Y;
            d.X = b.X;
            d.Y = b.Y;
            Console.WriteLine(PointDistance1(a, b));
            Console.WriteLine(PointDistance2(c, d));
            Console.WriteLine(PointDistance3(c, d));
            Console.WriteLine(PointDistance4(c, d));
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        [Benchmark]
        public static float PointDistance1(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public static float PointDistance2(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public static double PointDistance3(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        [Benchmark]
        public static float PointDistance4(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
    }
}
