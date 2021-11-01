using System;

namespace Lesson2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число 2 - " + Num(2));
            Console.WriteLine("Число 359 - " + Num(359));
            Console.WriteLine("Число 17 - " + Num(17));
            Console.WriteLine("Число -3 - " + Num(-3));
            Console.WriteLine("Число -75 - " + Num(-75));
            Console.WriteLine("Число 1 - " + Num(1));
        }
        static public string Num(int n)
        {
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if (n % i != 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0)
            {
                return ("Простое");
            }
            else
            {
                return ("Не простое");
            }
        }
    }
}
