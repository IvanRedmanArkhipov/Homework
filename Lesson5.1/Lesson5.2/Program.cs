using System;
using System.IO;

namespace Lesson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("startup.txt", Convert.ToString(DateTime.Now));
        }
    }
}
