namespace LabyrinthGame.Core;
using System.Collections.Generic;


public class LabyrinthGame()
{


}

public class ScenarioList {
    public List<Scenario>? Scenarios {get; set;}
}

public class Scenario {
    public int ScenarioID { get; set; }
    public string? ScenarioDescription {get; set;}
    public List<Option>? Options { get; set; }
}

public class Option {
    public int NextOptionID {get; set;}
    public string? OptionText {get; set;}
}
