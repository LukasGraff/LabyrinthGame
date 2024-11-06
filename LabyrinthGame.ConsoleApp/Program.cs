
using LabyrinthGame.Core;
using System;
using System.IO;

namespace LabyrinthGame.ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello friend, can you help me out of here? Press 'y' to start or 'n' to quit:");
            
            string? userInput = Console.ReadLine()?.ToLower();

            if (userInput == "y")
            {
                // Console.WriteLine("Current Working Directory: " + Directory.GetCurrentDirectory()); 

                string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", ".."));
                string filePath = Path.Combine(projectDirectory, "Scenarios.json");
               //  Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

                // Ladda scenarier från filen med JsonLoader
                ScenarioCollection? scenarios = JsonLoader.LoadScenariosFromFile(filePath);

                if (scenarios != null)
                {
                    // skappar en instance och kör spel
                    Game game = new Game(scenarios);
                    game.Start();
                }
                else
                {
                    Console.WriteLine("No scenarios found or file could not be loaded.");
                }
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
