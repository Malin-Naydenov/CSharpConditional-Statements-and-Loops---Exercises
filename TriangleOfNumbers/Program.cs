using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
