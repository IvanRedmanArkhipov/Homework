using System;
using System.Diagnostics;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            for (int i = 0; i < processes.Length / 2; i++)
            {

                Process[] processes2 = Process.GetProcesses();
                Console.WriteLine($"Process name: {processes2[i].ProcessName}");
                Console.WriteLine($"ID: {processes2[i].Id}");
            }

            Console.WriteLine("Введите номер нужного действия:");
            Console.WriteLine("1. Завершить по имени (Name)");
            Console.WriteLine("2. Завершить по ID");

            var num = Console.ReadLine();

            if (num == "1")
            {
                Console.WriteLine("Введите имя процесса");

                Process[] processName = Process.GetProcessesByName(Console.ReadLine());

                for (int i = 0; i < processName.Length; i++)
                {
                    processName[i].Kill();
                }
            }
            else if (num == "2")
            {
                Console.WriteLine("Введите ID процесса");

                Process processId = Process.GetProcessById(Convert.ToInt32(Console.ReadLine()));
                processId.Kill();
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите номер нужного действия");
            }
        }
    }
}