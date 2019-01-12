using System;

namespace _04.OwnBusiness
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            string volumePC = "";
            double volPC = 0;
            double volume = width * length * height;

            while (volumePC != "Done" && volPC <= volume)
            {
                volumePC = Console.ReadLine();
                if (volumePC != "Done")
                {
                    volPC += double.Parse(volumePC);
                }
                else
                {
                    break;
                }
            }

            double difference = volume - volPC;

            if (difference < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(difference)} Cubic meters more.");
            }

            else
            {
                Console.WriteLine($"{difference} Cubic meters left.");
            }
        }
    }
}
