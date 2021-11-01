using System;

namespace Lesson1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число фибоначи для 0 - " + FNum(0));
            Console.WriteLine("Число фибоначи для 1 - " + FNum(1));
            Console.WriteLine("Число фибоначи для 2 - " + FNum(2));
            Console.WriteLine("Число фибоначи для 3 - " + FNum(3));
        }
        static public int FNum(int N)
        {
            if (N == 0)
            {
                return (0);
            }
            if (N == 1)
            {
                return (1);
            }
            else
            {
                return (FNum(N - 2) + FNum(N - 1));
            }
        }
    }
}
