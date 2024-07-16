namespace Class8th__Two_Pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터
            // 두 개의 포인터를 두고 값들을 비교하여 문제를 해결하는 알고리즘입니다.

            //부분합
            // 1. 시작점과 끝점이 첫번째 원소의 인덱스를 가리키게 합니다. 시작점과 끝점 사이의 인덱스 전부 더합니다.
            // 2. 현재 부분합이 M과 같다면 카운트합니다.
            // 3. 현재 부분합이 M보다 작다면 end를 1증가시킵니다.
            // 4. 현재 부분합이 M보다 크거나 같다면 start를 1증가시킵니다.

            //int[] array = { 1, 2, 5, 2, 5, };
            //int target = 5;
            //int start = 0;
            //int end = 0;
            //int m = 0;
            //int count = 0;

            //while (start < target || end < target)
            //{
            //    if(m == target)
            //    {
            //        count++;
            //    }
            //    if(m < target)
            //    {
            //        m += array[end ++];
            //    }
            //    else
            //    {
            //        m -= array[start ++];
            //    }

            //}

            //Console.Write(count);

            int count = 0;
            int sum = 0;

            int start = 0;
            int end = 0;

            int m = 5;

            int[] list = new int[] { 1, 2, 5, 2, 5 };

            while (start <= end)
            {
                if (sum >= m)
                {
                    sum -= list[start++];
                }
                else if (end >= list.Length)
                {
                    break;
                }
                else
                {
                    sum += list[end++];
                }

                if (sum == m)
                {
                    count++;
                }
            }

            Console.WriteLine("count의 값 : " + count);
            #endregion
        }
    }
    
}
