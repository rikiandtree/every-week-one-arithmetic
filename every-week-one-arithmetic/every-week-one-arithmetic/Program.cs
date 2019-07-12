using System;

namespace every_week_one_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 1, 6, 9, 8, 7, 3, 4,10,25,15,12,20 };
            //ArrayOperation.InsertionSort(arr);
            // ArrayOperation.ShellSort(arr);
            // ArrayOperation.SelectionSort(arr);
            ArrayOperation.HeapSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
