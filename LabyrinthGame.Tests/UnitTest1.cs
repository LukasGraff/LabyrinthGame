namespace LabyrinthGame.Tests;

using LabyrinthGame.Core;
using Shouldly;


public class LabyrinthGameTests
{
    // Utifrån en lista eller array vill vi kunna slumpa ett ord
    [Fact]
    public void TestOpenLockedDoor()
    {
        // arrange
        var Door1 = new Core.Objective.LockedDoor();

        // act
        Door1.UnlockDoor();

        // assert
        Door1.IsOpen.ShouldBeTrue();

    }
    [Fact]
    public void TestPlayScenario()
    {
        var s = new ScenarioCollection
        {
            Scenarios = new List<Scenario>()
            {
                new Scenario{
                    Id=2,
                    Description="sss",
                    Options= new List<Option>{
                        new Option{
                            NextScenarioId=3
                        }
                    }
                }
            }
        };

        // arrange
        var x = new Game(s);

        // act
        var result = x.GetScenarioById(2);




        // assert
        result.Description.ShouldBe("sss");



    }
    [Fact]
    public void TestPlayScenario2()
    {
        var s = new ScenarioCollection
        {
            Scenarios = new List<Scenario>()
            {
                new Scenario{
                    Id=2,
                    Description="sss",
                    Options= new List<Option>{
                        new Option{
                            NextScenarioId=3
                        }
                    }
                }
            }
        };

        // arrange
        var x = new Game(s);

        // act
        var result = x.GetScenarioById(22222);




        // assert
        result.ShouldBeNull();

    }

    [Fact]
    public void TestOptions()
    {
        var s = new ScenarioCollection
        {
            Scenarios = new List<Scenario>()
            {
                new Scenario{
                    Id=2,
                    Description="sss",
                    Options = new List<Option>
                    {new Option
                    {
                            NextScenarioId=3
                    }
                    }
                }
            }
        };

        // arrange
        var x = new Game(s);

        // act
        var result = x.GetPlayerChoice(2);




        // assert
        result.ShouldBe(2);
    }

}