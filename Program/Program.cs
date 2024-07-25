namespace Program
{
    internal class Program
    {
        static void Num(int a)
        {
            int j = 0;
            for (int i = 1; i < a; i++)
            {
                if(a % i == 0)
                {
                    j += i;
                }
            }
            if(a == j)
            {
                Console.Write(a + " 는 완전수입니다.");
            }
            else
            {
                Console.Write(a + " 는 완전수가 아닙니다.");
            }
        }
        static void Main(string[] args)
        {
            Num(8128);
        }
    }
}
