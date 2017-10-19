using System;


namespace IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int numberA = 0;
            int numberB = 0;
            if (number1 > number2)
            {
                numberA = number2;
                numberB = number1;
            }
            else if (number1 < number2)
            {
                numberA = number1;
                numberB = number2;
            }
            for (int i = numberA; i <= numberB; i++)
            {
                Console.WriteLine(numberA);
                numberA++;
            }
        }
    }
}
