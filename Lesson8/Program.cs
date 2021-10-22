using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings1.Default.UserName))
            {
                Console.WriteLine("Hello World!");
                Properties.Settings1.Default.UserName = Console.ReadLine();
                Properties.Settings1.Default.UserAge = Console.ReadLine();
                Properties.Settings1.Default.UserWork = Console.ReadLine();

                Properties.Settings1.Default.Save();
            }
            else
            {

            }
        } 
    }
}
