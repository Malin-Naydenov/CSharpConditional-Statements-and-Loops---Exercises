using System;


namespace CountOfIntegers
{
    class Program
    {
        static void Main()
        {
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    int integer = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {

                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
