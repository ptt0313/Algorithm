namespace Program
{
    internal class Program
    {
        static void BinarySearch(int num)
        {
            int[] array = new int[] { 1, 5, 10, 15, 20, 25, 30, 35, 40, 50 };

            int middle;
            int left = 0;
            int right = array.Length;
            
            if( num < array[left])
            {
                Console.WriteLine("can not be find num");
            }
            else if ( num > array[right-1])
            {
                Console.WriteLine("can not be find num");
            }
            else
            {
                while( left < right )
                {
                    middle = (left+right)/2;
                    if(num >  array[middle])
                    {
                        left = middle+1;
                    }
                    else
                    {
                        right = middle-1;
                    }
                
                    if (num == array[middle])
                    {
                        Console.WriteLine(num + "은 " + middle +"번째 인덱스 입니다. ");
                    }
                    else if (left > right)
                    {
                        Console.WriteLine("can not be find num");
                    }
                }
            }
            
            
        }
        static void Main(string[] args)
        {
            #region 이진 탐색
            // 탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            // 좁혀가는 방식으로 동작하는 탐색 알고리즘입니다.

            BinarySearch(30);
            BinarySearch(50);
            BinarySearch(55);
            BinarySearch(0);


            #endregion
        }
    }
}
