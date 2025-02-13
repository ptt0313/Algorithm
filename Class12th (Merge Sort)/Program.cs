﻿namespace Class12th__Merge_Sort_
{
    internal class Program
    {
        static void Merge(int[] list, int start, int middle, int end)
        {
            int count = 0;
            int left = start;
            int right = middle + 1;
            int[] temporaryArray = new int[(end - start) + 1];

            // 두 부분을 병합합니다.
            while (left <= middle && right <= end)
            {
                if (list[left] <= list[right])
                {
                    temporaryArray[count++] = list[left++];
                }
                else
                {
                    temporaryArray[count++] = list[right++];
                }
            }
            // 남은 왼쪽 배열의 요소들을 복사합니다.
            while (left <= middle)
            {
                temporaryArray[count++] = list[left++];
            }

            // 남은 오른쪽 배열의 요소들을 복사합니다.
            while (right <= end)
            {
                temporaryArray[count++] = list[right++];
            }
            // 원본 배열에 정렬된 임시 배열의 값을 복사합니다.
            for (int i = 0; i < temporaryArray.Length; i++)
            {
                list[start + i] = temporaryArray[i];
            }


            //for(int count = 0; count < temporaryArray.Length;count++)
            //{
            //    if (list[left] < list[right] || right >= temporaryArray.Length)
            //    {
            //        temporaryArray[count] = list[left];
            //        left++;
            //    }
            //    else if(list[left] > list[right])
            //    {
            //        temporaryArray[count] = list[right];
            //        right++;
            //    }
            //}
            //for(int i = left; left < list.Length; i++)
            //{
            //    list[i] = temporaryArray[i];
            //}

        }
        static void MergeSort(int[] list, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                MergeSort(list, start, middle);
                MergeSort(list, middle + 1, end);
                Merge(list, start, middle, end);
            }
        }
        static void Main(string[] args)
        {
            #region 병합 정렬
            // 하나의 리스트를 두 개의 균등한 크기로 분할하고 분할된
            // 부분 리스트를 정렬한 다음, 두 개의 정렬된 부분 리스트를
            // 합하여 전체가 정렬된 리스트가 되게 하는 방법입니다.

            // 1. 리스트의 길이가 0 또는 1이면 이미 정렬된 것으로 봅니다.

            // 2. 그렇지 않은 경우

            // 2-1. 정렬되지 않은 리스트를 절반으로 잘라 비슷한 크기의 두 부분 리스트로 나눕니다.

            // 2-2. 각 부분 리스트를 재귀적으로 병합 정렬을 이용해 정렬합니다.

            // 2-3. 두 부분 리스트를 다시 하나의 정렬된 리스트로 병합합니다.

            int[] array = new int[] { 21, 10, 12, 20, 25, 13, 15, 22 };
            MergeSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            #endregion
        }
    }
    
}
