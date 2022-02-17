using System;

namespace MySort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 9, 6, 2, 5, 8 };
            //Display(arr);

            //SelectSort(arr);

            //BubbleSort(arr);
            //InsertSort(arr);
            //Display(arr);

            ////找最大数
            //int maxNum = FindMaxNumber(arr, 0, arr.Length - 1);
            //Console.WriteLine(maxNum);


            int i = 5;
            int left = i >> 1;
            Console.WriteLine("left is: {0}", left);
            Console.ReadKey();
        }
        #region 一、简单排序
        /// <summary>
        /// 1.选择排序。
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(arr, i, minIndex);
            }
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// 打印数组的每个值。
        /// </summary>
        /// <param name="arr"></param>
        public static void Display(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 2.冒泡排序。
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// 3.插入排序。
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                    }
                }
            }
        }
        #endregion

        #region 二、递归排序

        public static int FindMaxNumber(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }
            int mid = left + ((right - left) >> 1);
            int maxLeft = FindMaxNumber(arr, left, mid);
            int maxRight = FindMaxNumber(arr, mid + 1, right);
            return Math.Max(maxLeft, maxRight);
        }
        #endregion

        //public static void QuickSort(int[] arr, int L, int R)
        //{
        //    Random rd = new Random();
        //    int i = rd.Next(L, R);
        //    Swap(arr, i, R);
        //    //分区,Lmin:相等区域的左侧索引,Rmin：相等区域的右侧索引。
        //    int Lmin, Rmin;
        //    Partition(arr, L, R, out Lmin, out Rmin);

        //    //递归
        //    QuickSort(arr, L, Lmin - 1);
        //    QuickSort(arr, Rmin + 1, R);
        //}
        //public static void Partition(int[] arr, int L, int R, out int Lmin, out int Rmin)
        //{
        //    int less = L - 1;
        //    int mass = R + 1;

        //    for (int i = L; i <= mass; i++)
        //    {
        //        if (arr[i] < arr[R])
        //        {
        //            Swap(arr, i, --mass);
        //        }
        //        else if (arr[i] == arr[R])
        //        {
        //            i++;
        //        }
        //        else
        //        {
        //        }
        //    }
        //}
    }
}
