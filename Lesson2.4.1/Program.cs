using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
    public class BechmarkClass
    {
        [Benchmark]
        public void hashSet101()
        {
            static string RandomString(int length)
            {
                var result = new char[length];
                var r = new Random();
                for (int i = 0; i < result.Length; i++)
                {
                    do
                        result[i] = (char)r.Next(127);
                    while (result[i] < '!');
                }
                return new string(result);

                var hashSet = new HashSet<string>();

                for (var i = 1; i <= 10000; i++)
                {
                    hashSet.Add(RandomString(15));
                }
            }
        }
    }
}
