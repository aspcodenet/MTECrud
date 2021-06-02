using System;

namespace MTECrud
{
    public class GameSystem
    {


        public int RunGameRound()
        {
            Console.WriteLine("Jag tänker på ett tal mellan 1 och 100. Gissa vilket:");

            Random oRand = new Random();
            int secretTal = oRand.Next(1, 100);
            int antalGissningar = 0;
            while (true)
            {
                int gissning = Convert.ToInt32(Console.ReadLine());
                antalGissningar++;
                if (gissning == secretTal)
                {

                    Console.WriteLine("Hurra! Det var rätt");
                    break;
                }
                else if (gissning < secretTal)
                {
                    Console.WriteLine("Nej! Mitt tal är högre än så");
                }
                else if (gissning > secretTal)
                {
                    Console.WriteLine("Nej! Mitt tal är lägre än så");
                }

            }

            return antalGissningar;
        }


        public void Run()
        {
            while (true)
            {
                RunGameRound();
            }
        }
    }
}