using System.Text.Json;
using LabyrinthGame.Core;
public class JsonLoader
{

    public static ScenarioCollection LoadScenariosFromFile(string filePath)
    {
        // Kontrollera om filen existerar
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Filen kunde inte hittas: {filePath}");
        }

        try
        {
            // Läs in filen som en sträng
            string jsonContent = File.ReadAllText(filePath);

            // Deserialisera JSON till ScenarioCollection
            ScenarioCollection scenarios = JsonSerializer.Deserialize<ScenarioCollection>(jsonContent);
            return scenarios;
        }
        catch (Exception ex)
        {
            // Hantera fel vid inläsning och deserialisering
            Console.WriteLine($"Fel vid inläsning av JSON: {ex.Message}");
            return null;
        }
    }
}