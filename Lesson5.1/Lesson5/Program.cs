using System;
using System.IO;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("file.txt", Console.ReadLine());
        }
    }
}
