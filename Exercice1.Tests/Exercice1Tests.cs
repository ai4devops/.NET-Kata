namespace Exercice1.Tests;

public class Exercice1Tests
{
    [Fact]
    public void ShouldPrintCorrectSongFor3Bottles()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        Exercice1.BeerSong(3);

        // Assert
        var expectedOutput =
            "3 bottles of beer on the wall, 3 bottles of beer!\n" +
            "Take one down and pass it around, 2 bottles of beer on the wall!\n\n" +
            "2 bottles of beer on the wall, 2 bottles of beer!\n" +
            "Take one down and pass it around, 1 bottle of beer on the wall!\n\n" +
            "1 bottle of beer on the wall, 1 bottle of beer!\n" +
            "Take one down and pass it around, no more bottles of beer on the wall!\n\n" +
            "No more bottles of beer on the wall, no more bottles of beer!\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall!\n\n";

        Assert.Equal(expectedOutput, output.ToString());
    }

    [Fact]
    public void ShouldPrintCorrectSongFor1Bottle()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        Exercice1.BeerSong(1);

        // Assert
        var expectedOutput =
            "1 bottle of beer on the wall, 1 bottle of beer!\n" +
            "Take one down and pass it around, fini bottles of beer on the wall!\n\n" +
            "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall!\n\n";

        Assert.Equal(expectedOutput, output.ToString());
    }
}