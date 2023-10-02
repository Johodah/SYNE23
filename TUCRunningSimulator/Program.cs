
﻿// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isRunning = true;
        int runnerEnergy = 50;
        int coveredDistance = 10;

        while (isRunning)
        {
            Console.WriteLine("Välkommen till Running Simulator!");
            Console.WriteLine("=====================================");

            Console.WriteLine("Du startar med 50 energipoäng.");
            Console.WriteLine("Du måste slutföra en löpbana som är 10 km lång.");
            Console.WriteLine("Du anger din hastighet för varje 1 km i enheterna 1.snabbast (2km), 2. snabb, 3. måttlig, 4. långsam, 5. promenad eller 6. för att avsluta.");

            bool playAgain = true;

            while (playAgain)
            {
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        runnerEnergy = runnerEnergy - 15;
                        coveredDistance = coveredDistance - 2;
                        if (runnerEnergy <= 0 || coveredDistance < 0)
                        {
                            runnerEnergy = 0;
                            Console.WriteLine("Du misslyckades, fett sämst.");
                            playAgain = false;

                        }

                        else if (coveredDistance == 0)
                        {
                            Console.WriteLine("Du vann! TJoho!!!!!!");
                        }
                        Console.WriteLine($"Du valde snabbast, då har du {runnerEnergy} kvar och {coveredDistance} km kvar.");

                        break;
                    case "2":
                        runnerEnergy = runnerEnergy - 10;
                        coveredDistance = coveredDistance - 1;
                        if (runnerEnergy <= 0 || coveredDistance < 0)
                        {
                            runnerEnergy = 0;
                            Console.WriteLine("Du misslyckades, fett sämst.");
                            playAgain = false;

                        }

                        else if (coveredDistance == 0)
                        {
                            Console.WriteLine("Du vann! TJoho!!!!!!");
                        }
                        Console.WriteLine($"Du valde snabb, då har du {runnerEnergy} kvar och {coveredDistance} km kvar.");
                        break;
                    case "3":
                        runnerEnergy = runnerEnergy - 8;
                        coveredDistance = coveredDistance - 1;
                        if (runnerEnergy <= 0 || coveredDistance < 0)
                        {
                            runnerEnergy = 0;
                            Console.WriteLine("Du misslyckades, fett sämst.");
                            playAgain = false;

                        }

                        else if (coveredDistance == 0)
                        {
                            Console.WriteLine("Du vann! Tjoho!!!!!!");
                        }
                        Console.WriteLine($"Du valde måttlig, då har du {runnerEnergy} kvar och {coveredDistance} km kvar.");
                        break;
                    case "4":
                        runnerEnergy = runnerEnergy - 5;
                        coveredDistance = coveredDistance - 1;
                        if (runnerEnergy <= 0 || coveredDistance < 0)
                        {
                            runnerEnergy = 0;
                            Console.WriteLine("Du misslyckades, fett sämst.");
                            playAgain = false;

                        }

                        else if (coveredDistance == 0)
                        {
                            Console.WriteLine("Du vann! TJoho!!!!!!");
                        }
                        Console.WriteLine($"Du valde långsam, då har du {runnerEnergy} kvar och {coveredDistance} km kvar.");
                        break;
                    case "5":
                        runnerEnergy = runnerEnergy - 2;
                        coveredDistance = coveredDistance - 1;
                        if (runnerEnergy <= 0 || coveredDistance < 0)
                        {
                            runnerEnergy = 0;
                            Console.WriteLine("Du misslyckades, fett sämst.");
                            playAgain = false;

                        }

                        else if (coveredDistance == 0)
                        {
                            Console.WriteLine("Du vann! TJoho!!!!!!");
                        }
                        Console.WriteLine($"Du valde promenad, då har du {runnerEnergy} kvar och {coveredDistance} km kvar.");
                        break;
                    case "6":
                        Console.WriteLine("Då stänger vi av, tack och hej leverpastej!");
                        Environment.Exit(6);
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("välj ett av valen 1-6, tackar tackar");
                        playAgain = false;
                        Environment.Exit(6);

                        break;
                    }
                }
        }
    }
}


// snabbast = 15 energy, 2km
// snabb = 10 energy, 2km
// måttlig = 8 energy, 1km
// långsam = 5 energy, 1km
// promenad = 2 energy, 1km
