using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LabyrinthGame.Core
{
    public class Game
{
    private ScenarioCollection _scenarios; // Privat variabel som lagrar alla scenarier

    public Game(ScenarioCollection scenarios)
    {
        _scenarios = scenarios; // Initierar med scenarios från json
    }

    public void Start()
    {
        Console.WriteLine("Starting the game..."); 
        PlayScenario(1); // Kör playscenario metoden
    }

    private void PlayScenario(int scenarioId)
    {
        var scenario = GetScenarioById(scenarioId); // hämtar scenariot baserat på ID
        if (scenario == null || scenario.Options == null) // kontroll om null för options och scenario
        {
            Console.WriteLine("Scenario not found or has no options! Ending game."); // enkelt error meddeelande
            return; 
        }

        Console.WriteLine($"\nScenario {scenario.Id}: {scenario.Description}"); 
        DisplayOptions(scenario); // optionsmetod för att visa options för scenario

        int choice = GetPlayerChoice(scenario.Options.Count); // ta emot index för alternativet som valts
        if (choice >= 0) // felhantering av input annars else
        {
            int nextScenarioId = scenario.Options[choice].NextScenarioId; // ID för nästa scenario utefter choicen
            PlayScenario(nextScenarioId); 
        }
        else
        {
            Console.WriteLine("Invalid choice, try again."); 
            PlayScenario(scenarioId); // upprepning av scenario med aktuell scenario id
        }
    }

    private Scenario? GetScenarioById(int id)
    {
        // Returnerar scenariot som matchar det specifika ID:t eller null om det inte hittas
        return _scenarios.Scenarios?.Find(s => s.Id == id);
    }

    private void DisplayOptions(Scenario scenario)
    {
        if (scenario.Options == null) // Kontroll om alternativen är null
        {
            Console.WriteLine("No options available for this scenario."); // Meddelande om inga alternativ finns
            return; // Avslutar metoden
        }

        for (int i = 0; i < scenario.Options.Count; i++) // Loopar genom alternativen
        {
            // varje alternativ med ett nummer 
            Console.WriteLine($"{i + 1}. {scenario.Options[i].OptionsText}");
        }
    }

    private int GetPlayerChoice(int optionCount)
    {
        Console.Write("Choose an option: "); //  spelare väljer ett alternativ
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= optionCount)
        {
            
            return choice - 1;
        }
        return -1; 
    }
}


    public class Scenario
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        [JsonPropertyName("options")]
        public List<Option>? Options { get; set; }
    }

    public class Option
    {
        [JsonPropertyName("OptionsText")]
        public string? OptionsText { get; set; }

        [JsonPropertyName("next_scenario_id")]
        public int NextScenarioId { get; set; }
    }

    public class ScenarioCollection
    {
        [JsonPropertyName("scenarios")]
        public List<Scenario>? Scenarios { get; set; }
    }
}
