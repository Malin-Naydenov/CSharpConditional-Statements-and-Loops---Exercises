using System;

namespace TestNumbers
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combination = 0;
            for (int i = number1; i >= 1; i--)
            {
                for (int k = 1; k <= number2; k++)
                {
                    if(sum >= specialNumber)
                    { break; }
                    sum = sum + 3 * (i * k);
                    combination++;

                }
            }
            if (sum >= specialNumber)
            {
                Console.WriteLine($"{combination} combinations");
                Console.WriteLine($"Sum: {sum} >= {specialNumber}");
            }
            else
            {
                Console.WriteLine($"{combination} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
