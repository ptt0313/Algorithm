namespace Class16th__Euclidean_Algorithm_
{
    internal class Program
    {
        static int Euclidean(int a, int b)
        {
            //if(Math.Max(a, b) % Math.Min(a, b) == 0)
            //{
            //    return Math.Min(a, b);
            //}
            //int x = Math.Max(a,b) % Math.Min(a,b);
            //return Euclidean(Math.Min(a, b) , x);

            if (b == 0)
            {
                return a;
            }
            else
            {
                return Euclidean(b, a % b);
            }
        }
        static int GreatestCommonDivisor(int a, int b)
        {
            int x = 1;

            for (int i = 2; i <= Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    x = x * i;
                    a = a / i;
                    b = b / i;
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            #region 유클리드 호제법
            // 두개의 자연수 또는 정식의 최대공약수를 구하는 알고리즘으로,
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘입니다.

            // Console.Write(GreatestCommonDivisor(5, 15));

            Console.Write(Euclidean(19332, 78696));
            #endregion



        }
    }
   
}
