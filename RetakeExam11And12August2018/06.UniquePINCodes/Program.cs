using System;

namespace _06.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            public static bool isPrimeM(int number)
            {
                double sqrtNum = Math.Floor(Math.Sqrt(number));
                bool isPrime = true;
                for (int i = 2; i <= Math.Floor(sqrtNum); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                return isPrime;
            }

            static void Main()
            {
                int l = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                for (int i = 2; i <= l; i += 2)
                {
                    for (int j = 2; j <= m; j++)
                    {
                        if (isPrimeM(j))
                        {
                            for (int k = 2; k <= n; k += 2)
                            {
                                string result = $"{i} {j} {k}";
                                Console.WriteLine(result);
                            }
                        }
                    }
                }
            }
    }
}
