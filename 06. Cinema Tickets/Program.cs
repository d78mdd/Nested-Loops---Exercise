using System;

namespace _06.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int obsthoBileti = 0;

            int broiBiletiStudent = 0;
            int broiBiletiStandard = 0;
            int broiBiletiKid = 0;

            for ( ; ; )
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                string imeNaFilma = input;
                int mestaVZalata = int.Parse(Console.ReadLine());

                int zaetiMesta = 0;

                for (int j = 0; j < mestaVZalata; j++)
                {
                    string input2 = Console.ReadLine();

                    if (input2 == "End")
                    {
                        break;
                    }

                    string tipBilet = input2;

                    switch (tipBilet)
                    {
                        case "student":
                            broiBiletiStudent++;
                            break;
                        case "standard":
                            broiBiletiStandard++;
                            break;
                        case "kid":
                            broiBiletiKid++;
                            break;
                        default:
                            Console.WriteLine("expected input: student/standard/kid/End");
                            continue;
                    }

                    zaetiMesta++;
                }

                obsthoBileti += zaetiMesta;

                double procentZapalnenost = (double)zaetiMesta / (double)mestaVZalata * 100;
                Console.WriteLine($"{imeNaFilma} - {procentZapalnenost:F2}% full.");

            }

            double procentStudentskiBileti = (double)broiBiletiStudent / (double)obsthoBileti * 100;

            double procentStandartniBileti = (double)broiBiletiStandard / (double)obsthoBileti * 100;
            double procentDetskiBileti = (double)broiBiletiKid / (double)obsthoBileti * 100;

            Console.WriteLine($"Total tickets: {obsthoBileti}");
            Console.WriteLine($"{procentStudentskiBileti:F2}% student tickets.");
            Console.WriteLine($"{procentStandartniBileti:F2}% standard tickets.");
            Console.WriteLine($"{procentDetskiBileti:F2}% kids tickets.");

        }
    }
}
