using System;
namespace GameOfNumbers
{
    class Program
    {
        static void Main()
        {
            int firstLine = int.Parse(Console.ReadLine());
            int secondLine = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            int combination = 0;
            int fitI = 0;
            int fitK = 0;

            for (int i = firstLine; i <= secondLine; i++)
            {
                for (int k = firstLine; k <= secondLine; k++)
                {
                    if (sum == magicNumber)
                    {
                        break;
                    }
                    sum = i + k;
                    combination++;
                    fitI = i;
                    fitK = k;
                }
            }

            if (sum == magicNumber)
            {
                Console.WriteLine($"Number found! {fitK} + {fitI} = {sum}");
            }
            else
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
