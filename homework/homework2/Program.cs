using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSumm(Console.ReadLine()));
        }

        static int GetSumm(string numbers)
        {
            var number = "";
            int Summ = 0;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int i = 0; numbers[i] < Convert.ToChar(" "); i++)
                {
                    number = number + numbers[i];
                }

                number = Convert.ToInt32(number);
                Summ = Summ + number;
                number = Convert.ToString(number);
            }

            return Summ;
        }
    }
}
