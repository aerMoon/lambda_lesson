using System;
delegate int MyDelegate();
namespace LambdaAsResult
{
    internal class Program
    {
        static MyDelegate Сalculate(int n)
        {
            int count = 0;
            // результат через лямбда выражение:
            //---------------------------------
            return () => {
                count+=n;
                return count;
            };
            //---------------------------------
        }
        static void Main(string[] args)
        {
            MyDelegate next = Сalculate(1);
            for (int i = 1; i<=5; i++)
            {
                Console.Write(next()+" ");
            }
            Console.WriteLine();
            next=Сalculate(3);
            for (int i = 1; i<=5; i++)
            {
                Console.Write(next()+" ");
            }
            Console.WriteLine();

        }
    }
}
