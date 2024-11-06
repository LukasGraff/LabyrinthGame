namespace LabyrinthGame.Tests;

using LabyrinthGame.Core;
using Shouldly;


public class LabyrinthGameTests
{
    // Utifrån en lista eller array vill vi kunna slumpa ett ord
    [Fact]
    public void TestOpenLockedDoor()
    {
        // Arrange
        //(spelare valt en väg med en) låst dörr.
        //kan öppnas med en en key.
        //annars säg att spelaren får välja en annan väg.

        Item.Key Key1 = new(); //Behöver att det finns en nyckel

        Key1.hasKey = true; // ge nyckeln till spelaren
         
        
        // Låst dörr:
        Objective.LockedDoor Door1 = new(); // presentera ny låst dörr Door1
        Door1.isLocked = true; // Dörren är låst.
        // Act

        if (Key1.hasKey==true)
        {
            Door1.isLocked = false; // Dörren upplåst
            
        } else
        {
            // door can't be opened cuz you dont have key1.
        }

        //öppna dörren

        // Assert
        Door1.isLocked.ShouldBe(false);

        //Presentera nästa val
    }
}
