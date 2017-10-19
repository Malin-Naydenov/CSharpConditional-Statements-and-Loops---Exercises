using System;


namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleRoom = 0;
            double suite = 0;


            if (month == "May" || month == "October")
            {
                studio = 50 * nightsCount;
                doubleRoom = 65 * nightsCount;
                suite = 75 * nightsCount;
                if (nightsCount > 7)
                {
                    studio -= (studio * 0.05);
                }
                if (nightsCount > 7 && month == "October")
                {
                    studio = 50 * (nightsCount - 1);
                    studio -= (studio * 0.05);
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = 60 * nightsCount;
                doubleRoom = 72 * nightsCount;
                suite = 82 * nightsCount;
                if (nightsCount > 14)
                {
                    doubleRoom -= (doubleRoom * 0.10);
                }
                if (nightsCount > 7 && month == "September")
                {
                    studio = 60 * (nightsCount - 1);
                    
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68 * nightsCount;
                doubleRoom = 77 * nightsCount;
                suite = 89 * nightsCount;
                if (nightsCount > 14)
                {
                    suite -= (suite * 0.15);
                }
                
            }
            Console.WriteLine($"Studio: {studio:F2} lv.");
            Console.WriteLine($"Double: {doubleRoom:F2} lv.");
            Console.WriteLine($"Suite: {suite:F2} lv.");
        }
    }
}
