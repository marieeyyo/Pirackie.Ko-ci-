using System;

namespace PirackieKości
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pirateNames = { "Czerwonobrody", "Kapitan Bomba", "Anna Baryła" };
            int[] pirateRandomNums = new int[3];
            int[] piratePoints = new int[3];

            Random random = new Random();

            Console.WriteLine("Witajcie, piraci! Witajcie w grze Pirackie Kości!");

            for (int round = 0; round < 10; round++)
            {
                Console.WriteLine("Naciśnij dowolny klawisz, aby rzucić kośćmi.");
                Console.ReadKey();

                for (int pirate = 0; pirate < 3; pirate++)
                {
                    pirateRandomNums[pirate] = random.Next(1, 7);
                    Console.WriteLine($"{pirateNames[pirate]} rzucił(a) kośćmi i wyrzucił(a) {pirateRandomNums[pirate]}");
                }

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                int maxRoll = pirateRandomNums.Max();
                int winningPiratesCount = pirateRandomNums.Count(num => num == maxRoll);

                if (winningPiratesCount == 1)
                {
                    int winningPirate = Array.IndexOf(pirateRandomNums, maxRoll);
                    piratePoints[winningPirate]++;
                    Console.WriteLine($"{pirateNames[winningPirate]} zdobył(a) tę rundę!");
                }
                else
                {
                    Console.WriteLine("Remis w tej rundzie!");
                }

                for (int pirate = 0; pirate < 3; pirate++)
                {
                    Console.WriteLine($"{pirateNames[pirate]}: {piratePoints[pirate]} punktów");
                }

                Console.WriteLine();
            }

            int maxPoints = piratePoints.Max();
            int winningPirates = piratePoints.Count(points => points == maxPoints);

            if (winningPirates == 1)
            {
                int winningPirate = Array.IndexOf(piratePoints, maxPoints);
                Console.WriteLine($"{pirateNames[winningPirate]} zwycięża grę Pirackie Kości z {maxPoints} punktami!");
            }
            else
            {
                Console.WriteLine("Remis w grze Pirackie Kości!");
            }

            Console.ReadKey();
        }
    }
}