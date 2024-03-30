using System;

namespace _04.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiHora = int.Parse(Console.ReadLine()); // broi ocenki
            double srednaOcenkaZaPrezentacia = 0;
            double sumaOcenkiZaUspeh = 0;
            int broiPrezentacii = 0;

            for ( ; ; )
            {
                string input = Console.ReadLine();
                
                if (input == "Finish")
                {
                    break;
                }

                string imeNaPrezentacia = input;

                double sumaOcenki = 0;
                for (int j = 0; j < broiHora; j++)
                {
                    double ocenka = double.Parse(Console.ReadLine());
                    sumaOcenki += ocenka;
                }
                srednaOcenkaZaPrezentacia = sumaOcenki / (int)broiHora;
                Console.WriteLine($"{imeNaPrezentacia} - {srednaOcenkaZaPrezentacia:F2}.");

                sumaOcenkiZaUspeh += srednaOcenkaZaPrezentacia;
                broiPrezentacii++;
            }

            if (broiPrezentacii > 0)
            {
                double sredenUspeh = sumaOcenkiZaUspeh / broiPrezentacii;
                Console.WriteLine($"Student's final assessment is {sredenUspeh:F2}.");
            }
        }
    }
}
