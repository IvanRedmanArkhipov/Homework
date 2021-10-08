using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] a2 = new string[5,2];

            a2[0, 0] = "Bruce Park";
            a2[0, 1] = "9(3113)490-42-12";

            a2[1, 0] = "Ruby Wade";
            a2[1, 1] = "20(153)720-02-84";

            a2[2, 0] = "Miguel Steele";
            a2[2, 1] = "947(58)735-88-80";

            a2[3, 0] = "Javier Hall";
            a2[3, 1] = "1(17)608-43-84";

            a2[4, 0] = "Marjorie Price";
            a2[4, 1] = "78(632)805-64-15";

            Console.WriteLine($"{a2[0,0]} - {a2[0,1]}");
            Console.WriteLine($"{a2[1,0]} - {a2[1,1]}");
            Console.WriteLine($"{a2[2,0]} - {a2[2,1]}");
            Console.WriteLine($"{a2[3,0]} - {a2[3,1]}");
            Console.WriteLine($"{a2[4,0]} - {a2[4,1]}");
        }
    }
}
