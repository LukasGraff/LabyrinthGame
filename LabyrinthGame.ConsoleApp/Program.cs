
namespace LabyrinthGame.Core;
class Program
{
    static void Main()
    {
        // Ange filvägen till din JSON-fil
        // string filePath = @"C:\Users\LukasGraff\OneDrive - Brights\TMP\GroupProjects\LabyrinthGame\Scenarios.json"; // Eller den fullständiga vägen till din JSON-fil

       Console.WriteLine("Current Working Directory: " + Directory.GetCurrentDirectory()); 

        string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", ".."));
        string filePath = Path.Combine(projectDirectory, "Scenarios.json");
        Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
        
        // Ladda scenarier från filen
        ScenarioCollection scenarios = JsonLoader.LoadScenariosFromFile(filePath);

        if (scenarios != null)
        {
            // Skriv ut alla scenarier och deras alternativ
            foreach (var scenario in scenarios.Scenarios)
            {
                Console.WriteLine($"Scenario {scenario.Id}: {scenario.Description}");

                foreach (var option in scenario.Options)
                {
                    Console.WriteLine($"  - {option.OptionsText} (Next: {option.NextScenarioId})");
                }
            }
        }
    }
}