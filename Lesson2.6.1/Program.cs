using System;
using System.Collections.Generic;

namespace Lesson2._6._1
{
    class Program
    {
        //bfs
        static void Main(string[] args)
        {
            Random rand = new Random();
            var queue = new Queue<int>();
            int r;
            r = rand.Next(1, 10);
            bool[] used = new bool[r + 1];
            int[][] g = new int[r + 1][];

            for (int i = 0; i < r + 1; i++)
            {
                g[i] = new int[r + 1];
                for (int j = 0; j < r + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
            }
            used[r] = true;
            queue.Enqueue(r);
            Console.WriteLine(r + 1);
            while (queue.Count != 0)
            {
                r = queue.Peek();
                queue.Dequeue();

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[r][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            queue.Enqueue(i);
                            Console.WriteLine(i + 1);
                        }
                    }
                }
            }
        }
    }
}
