using System;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool specialno = true;

                int cifra1 = i / 1000;
                int cifra2 = (i - cifra1 * 1000) / 100;
                int cifra3 = (i - cifra1 * 1000 - cifra2 * 100) / 10;
                int cifra4 = i - cifra1 * 1000 - cifra2 * 100 - cifra3 * 10;

                if (n % cifra1 != 0)
                {
                    specialno = false;
                }
                if (cifra2 == 0 || n % cifra2 != 0)
                {
                    specialno = false;
                }
                if (cifra3 == 0 || n % cifra3 != 0)
                {
                    specialno = false;
                }
                if (cifra4 == 0 || n % cifra4 != 0)
                {
                    specialno = false;
                }

                if (specialno)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
