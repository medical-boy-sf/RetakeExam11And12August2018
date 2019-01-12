using System;

namespace _05.ComputerFirm
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double rating = 0;
            double sales = 0;
            double discount = 0;
            double totalSales = 0;
            double totalRating = 0;

            for (int i = 0; i < n; i++)
            {
                int pc = int.Parse(Console.ReadLine());
                rating = pc % 10;
                totalRating += rating;
                sales = (int)(pc / 10);

                switch (rating)
                {
                    case 3:
                        discount = 0.5;
                        totalSales += sales * discount;
                        break;
                    case 4:
                        discount = 0.7;
                        totalSales += sales * discount;
                        break;
                    case 5:
                        discount = 0.85;
                        totalSales += sales * discount;
                        break;
                    case 6:
                        discount = 1;
                        totalSales += sales * discount;
                        break;
                }
            }

            rating = rating / n;
            Console.WriteLine($"{totalSales:F2}");
            Console.WriteLine($"{(totalRating / n):F2}");
        }
    }
}
