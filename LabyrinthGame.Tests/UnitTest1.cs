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

}
