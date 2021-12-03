using System;

namespace Homework2._7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер первой стороны");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер второй стороны");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[N, M];
            for (int j = 0; j < M; j++)
                A[0, j] = 1;
            for (int i = 1; i < N; i++)
            {
                A[i, 0] = 1;
                for (int j = 1; j < M; j++)
                    A[i, j] = A[i, j - 1] + A[i - 1, j];
            }
            Console.WriteLine($"Для прямоугольного поля размера {M} на {N} клеток, количество путей из верхней левой клетки в правую нижнюю - {A[N - 1, M - 1]}");
            Console.WriteLine("(если ходить можно только на одну клетку вправо или вниз)");
            Console.ReadKey();
        }
    }
}
