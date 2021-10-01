using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            var num = Convert.ToInt32(Console.ReadLine());
            var ostatok = num % 2;
            if (ostatok == 0) {
                Console.WriteLine("Число чётно");
            } else
            {
                Console.WriteLine("Число нечётно");
            }
        }
    }
}
