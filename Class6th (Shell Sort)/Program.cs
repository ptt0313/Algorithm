namespace Class6th__Shell_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬
            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로
            // 정렬한 후, 점진적으로 더 작은 간격을 사용하는 정렬 알고리즘입니다.


            // 일정한 기준 분류 -> 연속적이지 않은 부분 리스트 생성 -> 각 부분 리스트를 삽입 정렬을 이용하여 정리
            // -> 모든 부분의 리스트가 정렬되면 다시 전체 리스트를 더 적은 개수로 반복 -> 리스트의 개수가 1이 될 때까지 반복.

            int[] array = new int[] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };
            int gap = 0;
            int key = 0;
            int i = 0;
            int j = 0;

            for (gap = array.Length / 2; gap > 0; gap /= 2)
            {
                if (gap % 2 == 0)
                {
                    gap++;
                }
                for (i = gap; i < array.Length; i++)
                {
                    key = array[i];

                    for (j = i; j >= gap && array[j - gap] > key; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = key;
                }
            }

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(array[k]);
            }

            //while(gap != 1)
            //{
            //    for (i = 0; i < array.Length; i++)
            //    {
            //        key = array[i];

            //        for (j = 0 ; j < array.Length && array[j] > key; j =+ gap)
            //        {
            //            array[i] = array[j];
            //            array[j] = key;
            //        }

            //    }
            //    gap = gap / 2;
            //    if( gap % 2 == 0 )
            //    {
            //        gap++;
            //    }
            //}
            //for (int i = 1; i < array.Length; i++)
            //{
            //    key = array[i];

            //    for (j = i - 1; j >= 0 && array[j] > key; j--)
            //    {
            //        array[j + 1] = array[j];
            //    }

            //    array[j + 1] = key;
            //}

            //for(int k = 0; k < array.Length; k++)
            //{
            //    Console.Write(array[k] + " ");
            //}
            #endregion
        }
    }
   
}
