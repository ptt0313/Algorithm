﻿namespace Program
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
            static void Main(string[] args)
        {
            #region 소수
            // 1과 자신 이외에 나누어 떨어지지 않는 수입니다.

            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(n));

            #endregion

            #region 합성수
            // 1보다 큰 자연수중에서 소수가 아닌 수로, 약수가 3개 이상인 수입니다.
            #endregion

            #region 에라토스테네스의 체
            // 소수를 판정하는 방법으로, 자연수를 순서대로 늘어놓은 표에서
            // 합성수를 차례대로 지워나가면서 소수의 목록을 얻어내는 방법입니다.

            #endregion
        }
    }
}
