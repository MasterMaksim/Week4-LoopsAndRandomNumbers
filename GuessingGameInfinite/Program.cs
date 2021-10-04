using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1,11);

            bool loopActive = true;

            while(loopActive)
            {
                Console.WriteLine("Sisesta juhusliku numbri 1-10: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                

                if(cpuNumber == userNumber)
                {
                    Console.WriteLine("Sa oled võitnud!");
                    loopActive = false;
                    Console.WriteLine($"Juhuslik number on {cpuNumber}");
                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
