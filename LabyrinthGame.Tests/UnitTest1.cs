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

        Item.Key Key1 = new() //Behöver ha en nyckel
        {
            hasKey = true // ge nyckeln till spelaren
        }; 
        
        // Låst dörr:
        Door = locked;
        



        // Act
        var selectedWord = Core.LabyrinthGame.SelectRandomWord(words);
        //öppna dörren

        // Assert
        words.ShouldContain(selectedWord);

        //Presentera nästa val
    }
}
