using System;

namespace _02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();

                int oddSum = 0;
                int evenSum = 0;

                for (int indexNaCifra = 0; indexNaCifra < currentNum.Length; indexNaCifra++)
                {
                    int currentDigit = int.Parse(currentNum[indexNaCifra].ToString());

                    if (indexNaCifra % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
