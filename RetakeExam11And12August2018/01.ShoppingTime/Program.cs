using System;

namespace _01.ShoppingTime
{
    class Program
    {
        static void Main()
        {
            int time = int.Parse(Console.ReadLine());
            double pricePeripheral = double.Parse(Console.ReadLine());
            double priceSoftware = double.Parse(Console.ReadLine());
            double priceFrappe = double.Parse(Console.ReadLine());

            time -= 5;
            time -= 3 * 2;
            time -= 2 * 2;

            double totalSum = 3 * pricePeripheral + 2 * priceSoftware + priceFrappe;
            Console.WriteLine($"{totalSum:F2}");
            Console.WriteLine(time);
            
        }
    }
}
