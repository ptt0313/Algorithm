namespace Class17th__Back_Tracking_
{
    internal class Program
    {
        static void Hanoi(int n, char from, char by, char to)
        {
            if (n == 1)
            {
                Console.WriteLine("[" + n + "]" + from + "->" + to);
            }
            else
            {
                Hanoi(n - 1, from, to, by);
                Console.WriteLine("[" + n + "]" + from + "->" + to);
                Hanoi(n - 1, by, from, to);
            }
            //if(n % 2 == 1 && n > 0)
            //{
            //    Console.WriteLine(from + " -> " + to);
            //    Hanoi(n - 1, 'A','C','B');
            //    Hanoi(n - 1, 'B','C','A');
            //}
            //else if(n % 2 == 0 && n > 0)
            //{
            //    Console.WriteLine(from + " -> " + to);
            //    Hanoi(n - 1, 'C', 'A', 'B');
            //    Hanoi(n - 1, 'A', 'B', 'C');
            //}
        }
        static void Main(string[] args)
        {
            #region 백트레킹
            // 해를 찾아가는 도중에 지금의 경로가 해가 될 것 같지 않으면,
            // 더 이상 깊이 들어가지 않고, 이전 단계로 다시 돌아가는 알고리즘입니다.

            // 백트레킹의 유망성 판단
            // 해가 될 만한지 판단한 후에 유망하지 않다고 결정되면,
            // 그 노드의 이전 노드로 돌아가 다음 자식 노드로 이동합니다.

            // 해가 될 만한 가능성이 있으면 유망하다. (Promising)
            // 유망하지 않은 노드에 가지 않는 것 (Pruning)

            #region 하노이의 탑
            // 1. 한번의 하나의 원판만 이동합니다.
            // 2. 맨 위의 원판만 이동합니다.
            // 3. 크기가 작은 원판 위에 큰 원판을 쌓을 수 없습니다.

            Hanoi(3, 'A', 'B', 'C');

            #endregion
            #endregion
        }
    }
    
}
