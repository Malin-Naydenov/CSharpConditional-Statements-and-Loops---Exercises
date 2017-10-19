using System;
namespace CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int countIngredients = int.Parse(Console.ReadLine());
            double totalCalories = 0;
            for (int i = 0; i < countIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese": totalCalories += 500;break;
                    case "tomato sauce": totalCalories += 150;break;
                    case "salami": totalCalories += 600;break;
                    case "pepper": totalCalories += 50; break;
                    default: totalCalories += 0;break;
                }
            }
            
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
