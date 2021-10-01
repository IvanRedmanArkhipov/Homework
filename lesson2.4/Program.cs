using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shopName = "MyShop";
            string productName1 = "Вода питьевая 1.5л";
            var cost1 = 27;
            string productName2 = "Молоко 2л";
            var cost2 = 74;
            var vneseno = 150;
            Console.WriteLine("__________________________");
            Console.WriteLine("|************************|");
            Console.WriteLine($"|***     {shopName}       ***|");
            Console.WriteLine("|************************|");
            Console.WriteLine("|" + productName1 + "...." + cost1 + "|");
            Console.WriteLine("|" +productName2 + "............." + cost2 + "|");
            Console.WriteLine("|________________________|");
            Console.WriteLine("|Итог................=" + (cost1 + cost2) + "|");
            Console.WriteLine("|Наличными............" + vneseno + "|");
            Console.WriteLine("|Сдача................." + (vneseno - cost1 - cost2) + "|");
            Console.WriteLine("|************************|");
            Console.WriteLine("|** СПАСИБО ЗА ПОКУПКУ **|");
            Console.WriteLine("|************************|");
            Console.WriteLine("|________________________|");
        }
    }
}
