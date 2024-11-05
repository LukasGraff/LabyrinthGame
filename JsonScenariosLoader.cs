using System.Text.Json;

class JsonScenariosLoader
{
    public IEnumerable<Scenario> Scenarios { get; }

    public JsonScenariosLoader(string fileName)
    {
        Scenarios = LoadScenarios(fileName);

    }


    private static IEnumerable<Scenario> LoadScenarios(string filePath)
    {
        var json = File.ReadAllText(filePath);
        var scenarios = JsonSerializer.Deserialize<Scenario>(json);
        if (scenarios == null)
        {
            throw new Exception($"Couldn't read file {filePath}");
        }
        return scenarios;
    
}


}