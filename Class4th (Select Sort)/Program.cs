namespace Class4th__Select_Sort_
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에 위치한 결과를
            // 교체하는 방식으로 정렬하는 알고리즘입니다.
            int[] array = new int[] { 13, 1, 21, 25, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                int select = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];
                        select = j;
                    }
                }
                Swap(ref array[i], ref array[select]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion
        }
    }
    
}
