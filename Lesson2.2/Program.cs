using System;

namespace Lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            var monthOfYear = Convert.ToInt32(Console.ReadLine()) - 1;
            string monthTitle = "";
            switch (monthOfYear)
            {
                case 0:
                    monthTitle = "Январь";
                    break;
                case 1:
                    monthTitle = "Февраль";
                    break;
                case 2:
                    monthTitle = "Март";
                    break;
                case 3:
                    monthTitle = "Апрель";
                    break;
                case 4:
                    monthTitle = "Май";
                    break;
                case 5:
                    monthTitle = "Июнь";
                    break;
                case 6:
                    monthTitle = "Июль";
                    break;
                case 7:
                    monthTitle = "Август";
                    break;
                case 8:
                    monthTitle = "Сентябрь";
                    break;
                case 9:
                    monthTitle = "Октябрь";
                    break;
                case 10:
                    monthTitle = "Ноябрь";
                    break;
                case 11:
                    monthTitle = "Декабрь";
                    break;
            }

            Console.WriteLine("Это " + monthTitle);
        }
    }
}
