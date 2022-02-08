using System;

namespace commonSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 9, 2, 5, 7, 6 };
            //PrintArray(nums);
            //InsertSort(nums);
            //PrintArray(nums);

            //Point myPoint;
            //myPoint.X = 100;
            //myPoint.Y = 200;
            //myPoint.Display();

            //myPoint.Increment();
            //myPoint.Display();

            //Point p2 = new Point(69, 89);
            //p2.Display();

            DrawCircle circle = new DrawCircle();
            circle.Draw();
            Console.ReadLine();
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void InsertSort(int[] arr)
        {
            arr[0] = 1;
            arr[1] = 2;
        }

        struct Point
        {
            public int X;
            public int Y;

            public Point(int XPos, int YPos)
            {
                X = XPos;
                Y = YPos;
            }
            public void Increment()
            {
                X++;
                Y++;
            }

            public void Display()
            {
                Console.WriteLine("X={0},Y={1}", X, Y);
            }
        }

    }
    public class DrawCircle : IDraw
    {
        public void Draw()
        {
            Console.WriteLine("绘制圆形");
            int i = 0;
            System.Int32 j = 20;
        }
    }
}
