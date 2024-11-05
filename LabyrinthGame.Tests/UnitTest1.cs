using Shouldly;


namespace LabyrinthGame.Tests;


public class LabyrinthGameTests
{
    // Utifrån en lista eller array vill vi kunna slumpa ett ord
    [Fact]
    public void TestWordSelection()
    {
        // Arrange
        string[] words = ["apple", "banana", "cherry"];


        // Act
        var selectedWord = Core.LabyrinthGame.SelectRandomWord(words);


        // Assert
        words.ShouldContain(selectedWord);
    }
