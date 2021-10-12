using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иван", "Архипов", "Борисович"));
            Console.WriteLine(GetFullName("Сергей", "Семёнов", "Александрович"));
            Console.WriteLine(GetFullName("Алексей", "Шевченко", "Сергеевич"));
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            var fullName = ($"{lastName} {firstName} {patronymic}");
            return fullName;
        }
    }
}
