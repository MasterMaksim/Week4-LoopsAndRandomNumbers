using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta juhusliku numbri 1-10: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuNumber == userNumber)
                {
                    Console.WriteLine("Sa oled võitnud!");
                    Console.WriteLine($"Juhuslik number on {cpuNumber}");
                    break;
                }
                else if(i == 2)
                {
                    Console.WriteLine("Arvuti võidab!");
                    Console.WriteLine($"Juhuslik number on {cpuNumber}");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number.{3 - i} katset on jäänud");
                }
                
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
