using System;
using System.Collections.Generic;

namespace Lesson2._7._1
{
    class Program
    {
        static void BucketSort(int[] array)
        {
            List<int> list1 = new List<int>() {};
            List<int> list2 = new List<int>() {};
            List<int> list3 = new List<int>() {};
            List<int> list4 = new List<int>() {};
            List<int> list5 = new List<int>() {};
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] <= 19)
                {
                    list1.Add(array[i]);
                }
                else if (array[i] <= 39)
                {
                    list2.Add(array[i]);
                }
                else if (array[i] <= 59)
                {
                    list3.Add(array[i]);
                }
                else if (array[i] <= 79)
                {
                    list4.Add(array[i]);
                }
                else if (array[i] <= 99)
                {
                    list5.Add(array[i]);
                }
            }
            List<int> list1s = new List<int>() { };
            List<int> list2s = new List<int>() { };
            List<int> list3s = new List<int>() { };
            List<int> list4s = new List<int>() { };
            List<int> list5s = new List<int>() { };
            int min = 99;
            int minnum = 0;
            while (list1.Count != 0)
            {
                for (int i = 0; i <= list1.Count - 1; i++)
                {
                    if (min >= list1[i])
                    {
                        min = list1[i];
                        minnum = i;
                    }
                }
                list1s.Add(min);
                min = 99;
                list1.RemoveAt(minnum);
            }
            while (list2.Count != 0)
            {
                for (int i = 0; i <= list2.Count - 1; i++)
                {
                    if (min >= list2[i])
                    {
                        min = list2[i];
                        minnum = i;
                    }
                }
                list2s.Add(min);
                min = 99;
                list2.RemoveAt(minnum);
            }
            while (list3.Count != 0)
            {
                for (int i = 0; i <= list3.Count - 1; i++)
                {
                    if (min >= list3[i])
                    {
                        min = list3[i];
                        minnum = i;
                    }
                }
                list3s.Add(min);
                min = 99;
                list3.RemoveAt(minnum);
            }
            while (list4.Count != 0)
            {
                for (int i = 0; i <= list4.Count - 1; i++)
                {
                    if (min >= list4[i])
                    {
                        min = list4[i];
                        minnum = i;
                    }
                }
                list4s.Add(min);
                min = 99;
                list4.RemoveAt(minnum);
            }
            while (list5.Count != 0)
            {
                for (int i = 0; i <= list5.Count - 1; i++)
                {
                    if (min >= list5[i])
                    {
                        min = list5[i];
                        minnum = i;
                    }
                }
                list5s.Add(min);
                min = 99;
                list5.RemoveAt(minnum);
            }
            string sorted = "";
            for (int i = 0; i <= list1s.Count - 1; i++)
            {
                sorted = sorted + " " + list1s[i];
            }
            for (int i = 0; i <= list2s.Count - 1; i++)
            {
                sorted = sorted + " " + list2s[i];
            }
            for (int i = 0; i <= list3s.Count - 1; i++)
            {
                sorted = sorted + " " + list3s[i];
            }
            for (int i = 0; i <= list4s.Count - 1; i++)
            {
                sorted = sorted + " " + list4s[i];
            }
            for (int i = 0; i <= list5s.Count - 1; i++)
            {
                sorted = sorted + " " + list5s[i];
            }
            Console.WriteLine(sorted);
        }
        static void Main(string[] args)
        {
            int[] array = new int[12] { 28, 84, 18, 10, 82, 8, 54, 6, 81, 64, 21, 61 };
            BucketSort(array);
        }
    }
}
