namespace Class3th__Bubble_Sort_
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
            #region 거품 정렬
            // 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘입니다.

            int[] array = new int[] { 13, 1, 21, 25, 4 };
            int l = array.Length;

            for (int i = 0; i < l - 1; i++)
            {
                for (int j = 0; j < (l - i) - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            #endregion
        }
    }
}
