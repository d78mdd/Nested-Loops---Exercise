using System;

namespace _03.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            for ( ; ; )
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else
                {
                    int number = int.Parse(input);

                    bool isPrime = true;

                    if (number < 0)
                    {
                        Console.WriteLine("Number is negative.");
                        continue;
                    }

                    for (int j = 2; j < number; j++)
                    {
                        if (number % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        sumPrime += number;
                    }
                    else
                    {
                        sumNonPrime += number;
                    }
                }


            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
