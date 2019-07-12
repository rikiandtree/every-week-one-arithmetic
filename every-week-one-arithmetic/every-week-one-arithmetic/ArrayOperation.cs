using System;
using System.Collections.Generic;
using System.Text;

namespace every_week_one_arithmetic
{
    class ArrayOperation
    {

        #region 插入排序
        /// <summary>
        /// 一般插入排序
        /// </summary>
        /// <param name="arr">操作的数组</param>
        public static void InsertionSort(int[] arr)
        {
            int length = arr.Length;
            if (length<2)
            {
                return;
            }
            for (int i = 1; i < length; i++)
            {
                int j = i-1;
                int temp = arr[i];              //当前待排序的数字
                while (j>=0&&arr[j]>temp)       //依次向前比较，找到自身位置
                {
                    
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;              

            }
        }


        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="arr">待操作数组</param>
        public static void ShellSort(int[] arr)
        {
            int length = arr.Length;
            if (length<2)
            {
                return;
            }
            int gap = length / 2;           //分组间隔
            while (gap>0)                   //分组间隔每次缩小2倍
            {
                for (int i = gap; i < length; i++)  
                {
                    //类似插入排序，不过数据已经分组，待排序数组，依次与组内数据比较
                    //以便找到合适位置
                    int j = i - gap;
                    int temp = arr[i];
                    while (j>=0&&arr[j]>temp)
                    {
                        arr[j + gap] = arr[j];
                        j  -= gap;
                    }
                    arr[j + gap] = temp;
                }

                gap /= 2;
            }
        }
        #endregion


        public static void SelectionSort(int[] arr)
        {
            int length = arr.Length;
            if (length<2)
            {
                return;
            }

            for (int i = 0; i < length-1; i++)
            {
                int min = arr[i];
                int minIndex = i;
                for (int j = i+1; j < length; j++)
                {
                    if (min>arr[j])
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }

                if (minIndex!=i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }

            }
        }

        public static void SelectionSortOp(int[] arr)
        {
            int length = arr.Length;
            if (length < 2)
            {
                return;
            }

            int index = 0;
            while (index <= length / 2)
            {
                //int min

            }
        }

        public static void HeapSort(int[] arr)
        {
            int length = arr.Length;
            if (length<2)
            {
                return;
            }

            for (int i = length/2; i >= 0; i--)
            {
                AdjustHeap(arr, i, length);
            }

            for (int i = 0; i < length; i++)
            {
                Swap(arr, 0, length - 1 - i);
                AdjustHeap(arr, 0, length - i - 1);


            }
        }

        private static void AdjustHeap(int[] arr,int index,int length)
        {
            //int length = arr.Length;
            int leftIndex = index * 2+1;
            int rightIndex = index * 2 + 2;
            if (leftIndex>= length)
            {
                return;
            }

            int maxIndex = leftIndex;
            if (rightIndex< length)
            {
                if (arr[leftIndex]<arr[rightIndex])
                {
                    maxIndex = rightIndex;
                }
            }

            if (arr[maxIndex]>arr[index])
            {
                Swap(arr, maxIndex, index);
                AdjustHeap(arr, maxIndex,length);
            }


        }


        private static void Swap(int[] arr,int index1,int index2)
        {
            int length = arr.Length;
            if (index1>=length ||index2>=length)
            {
                return;
            }
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
