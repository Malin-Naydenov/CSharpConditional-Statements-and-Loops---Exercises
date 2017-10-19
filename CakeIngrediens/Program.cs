using System;


namespace CakeIngrediens
{
    class Program
    {
        static void Main()
        {
            int countIngredient = 0;
            for (int i = 1; i <= 20; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                countIngredient++;
            }
            Console.WriteLine($"Preparing cake with {countIngredient} ingredients.");
        }
    }
}
