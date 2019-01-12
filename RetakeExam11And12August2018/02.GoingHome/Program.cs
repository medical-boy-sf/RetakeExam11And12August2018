using System;
namespace _02.GoingHome
{
    class Program
    {
        static void Main()
        {
            int distance = int.Parse(Console.ReadLine());
            decimal expenseFuelPer100km = decimal.Parse(Console.ReadLine());
            decimal priceFuelPerLitre = decimal.Parse(Console.ReadLine());
            decimal moneyWon = decimal.Parse(Console.ReadLine());

            decimal litresFuelConsumed = (distance * expenseFuelPer100km) / 100;
            decimal totalSum = litresFuelConsumed * priceFuelPerLitre;

            if (moneyWon >= totalSum)
            {
                Console.WriteLine($"You can go home. {(moneyWon - totalSum):F2} money left.");
            }

            else
            {
                Console.WriteLine($"Sorry, you cannot go home. Each will receive {(moneyWon / 5):F2} money.");
            }
        }
    }
}
