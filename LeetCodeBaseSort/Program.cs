using System;

namespace LeetCodeBaseSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 3, 3, 5, 5, 8, 8 };
            //int[] arr = { 1, 1, 2 };
            Display(arr);
            int k = RemoveDuplicates(arr);
            Console.WriteLine("k is: {0}", k);
            Display(arr);
            Console.ReadKey();
        }

        public static void Display(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        /// <summary>
        /// 1、删除排序数组中的重复项。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 1;
            }
            int i = 1;
            int j = 0;
            for (i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    if ((j + 1) != i)
                    {
                        Swap(nums, i, j + 1);
                    }
                    j++;
                }
            }
            return j + 1;
        }

    }
}
