﻿namespace Class9th__Binary_Search_
{
    internal class Program
    {
        static void BinarySearch(int[] list, int key)
        {
            int left = 0;
            int right = list.Length - 1;

            while (left <= right)
            {
                // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.
                int pivot = (left + right) / 2;

                // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색을 종료합니다.
                if (list[pivot] == key)
                {
                    Console.WriteLine("Key Found : " + list[pivot]);
                    return;
                }
                // 3. [pivot]의 값이 찾는 값보다 크다면 left ~ pivot 사이의 값을 검색합니다.
                else if (list[pivot] > key)
                {
                    right = pivot - 1;
                }
                // 4. [pivot]의 값이 찾는 값보다 작다면 pivot ~ right 사이의 값을 검색합니다.
                else
                {
                    left = pivot + 1;
                }

            }
            Console.WriteLine("Not key Found");


            //static void BinarySearch(int num)
            //{
            //    int[] array = new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 50 };

            //    int middle;
            //    int left = 0;
            //    int right = array.Length;

            //    if( num < array[left])
            //    {
            //        Console.WriteLine("can not be find num");
            //    }
            //    else if ( num > array[right-1])
            //    {
            //        Console.WriteLine("can not be find num");
            //    }
            //    else
            //    {
            //        while( left < right )
            //        {
            //            middle = (left+right)/2;
            //            if(num >  array[middle])
            //            {
            //                left = middle+1;
            //            }
            //            else
            //            {
            //                right = middle-1;
            //            }

            //            if (num == array[middle])
            //            {
            //                Console.WriteLine(num + "은 " + middle +"번째 인덱스 입니다. ");
            //            }
            //            else if (left > right)
            //            {
            //                Console.WriteLine("can not be find num");
            //            }
            //        }
            //    }


            //}
        }
        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            // 좁혀가는 방식으로 동작하는 탐색 알고리즘입니다.
            int[] array = new int[] { 5, 6, 11, 13, 27, 55, 66, 99 };

            //BinarySearch(30);
            //BinarySearch(50);
            //BinarySearch(55);
            //BinarySearch(0);

            BinarySearch(array, 33);

            #endregion
        }
    }

}
