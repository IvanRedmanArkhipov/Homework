using System;

namespace Lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a2 = new int[3, 3];

            a2[0, 0] = 1;
            a2[0, 1] = 2;
            a2[0, 2] = 3;

            a2[1, 0] = 4;
            a2[1, 1] = 5;
            a2[1, 2] = 6;

            a2[2, 0] = 7;
            a2[2, 1] = 8;
            a2[2, 2] = 9;

            Console.WriteLine($"{a2[0, 0]} {a2[1, 1]} {a2[2, 2]}");
        }
    }
}
