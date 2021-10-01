using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную и максимальную температуру за день");
            var tempMin = Convert.ToSingle(Console.ReadLine());
            var tempMax = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Среднесуточная температура: " + (tempMax + tempMin) / 2);
        }
    }
}
