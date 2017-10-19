using System;

namespace RestourantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int price = 0;
            double totalPrice = 0;
            string halls = "";
            double person = 0;

            if (groupSize <= 50)
            {
                halls = "Small Hall";
                if (package == "Normal")
                {
                    price = 2500 + 500;
                    totalPrice = price - (price * 0.05);

                }
                else if (package == "Gold")
                {
                    price = 2500 + 750;
                    totalPrice = price - (price * 0.10);

                }
                else if (package == "Platinum")
                {
                    price = 2500 + 1000;
                    totalPrice = price - (price * 0.15);

                }

            }
            if (groupSize > 50 && groupSize <= 100)
            {
                halls = "Terrace";
                if (package == "Normal")
                {
                    price = 5000 + 500;
                    totalPrice = price - (price * 0.05);
                }
                else if (package == "Gold")
                {
                    price = 5000 + 750;
                    totalPrice = price - (price * 0.10);
                }
                else if (package == "Platinum")
                {
                    price = 5000 + 1000;
                    totalPrice = price - (price * 0.15);
                }
            }
            if (groupSize > 100 && groupSize <= 120)
            {
                halls = "Great Hall";
                if (package == "Normal")
                {
                    price = 7500 + 500;
                    totalPrice = price - (price * 0.05);
                }
                else if (package == "Gold")
                {
                    price = 7500 + 750;
                    totalPrice = price - (price * 0.10);
                }
                else if (package == "Platinum")
                {
                    price = 7500 + 1000;
                    totalPrice = price - (price * 0.15);
                }
            }
            if (totalPrice != 0)
            {
            person = totalPrice / groupSize;
            Console.WriteLine($"We can offer you the {halls}");
            Console.WriteLine($"The price per person is {person:f2}$");

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}