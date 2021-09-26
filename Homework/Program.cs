using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();

            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
        }
    }
}
