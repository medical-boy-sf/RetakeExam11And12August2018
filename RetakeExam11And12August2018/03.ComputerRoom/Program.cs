using System;

namespace _03.ComputerRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int spentHours = int.Parse(Console.ReadLine());
            int peopleInGroup = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double pricePerPerson = 0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    if (timeOfDay == "day")
                    {
                        pricePerPerson = 10.5;
                    }
                    else
                    {
                        pricePerPerson = 8.4;
                    }

                    break;
                case "june":
                case "july":
                case "august":
                    if (timeOfDay == "day")
                    {
                        pricePerPerson = 12.6;
                    }
                    else
                    {
                        pricePerPerson = 10.2;
                    }

                    break;
            }

            if (peopleInGroup >= 4)
            {
                pricePerPerson = pricePerPerson - pricePerPerson * 0.1;
            }

            if (spentHours >= 5)
            {
                pricePerPerson = pricePerPerson - pricePerPerson * 0.5;
            }

            double totalPrice = pricePerPerson * peopleInGroup * spentHours;
            Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
            Console.WriteLine($"Total cost of the visit: {totalPrice:F2}");
        }
    }
}
