using System;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                char[] chars = new char[text.Length - 1];
                for (int n = 1; n <= text.Length - 1; n++)
                {
                    chars[n] = text[i];
                    if (n == text.Length - 1)
                    {
                        string string1 = new string(chars);
                        Console.WriteLine(string1);
                    }
                }
            }
        }
    }
}
