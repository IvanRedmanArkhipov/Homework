using System;

namespace lesson_2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 5, 17, 21 }; 
            Console.WriteLine(BinarySearch(nums1, 17));
            int[] nums2 = { 1, 2, 5, 9, 17, 21, 199, 313 };
            Console.WriteLine(BinarySearch(nums2, 9));
            int[] nums3 = { 1, 7, 2, 5, 17, 21 };
            Console.WriteLine(BinarySearch(nums3, 2));
            int[] nums4 = { 1, 2, 5, 17, 21, 3 };
            Console.WriteLine(BinarySearch(nums4, 3));
        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    max = mid + 1;
                }
            }
            return -1;
        }
    }
}
