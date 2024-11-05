namespace LabyrinthGame.Core;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Scenario
{
    public int Id { get; set; }

    public string Description { get; set; }

    [JsonPropertyName("options")] // Kanske behövs beroende på namnen i JSON
    public List<Option> Options { get; set; }
}

public class Option
{
    [JsonPropertyName("OptionsText")]
    public string OptionsText { get; set; }

    [JsonPropertyName("next_scenario_id")]
    public int NextScenarioId { get; set; }
}

public class ScenarioCollection
{
    [JsonPropertyName("scenarios")]
    public List<Scenario> Scenarios { get; set; }
}
