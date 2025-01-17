namespace Exercice3.Tests;

public class Exercice3Tests
{
    [Fact]
    public void SplitsWordsBasedOnSizeAndSortsThemAlphabetically()
    {
        var words = new List<string> { "apple", "bat", "banana", "car", "dog", "elephant" };
        var size = 3;
        var result = Exercice3.SizeSplitter(words, size);
        Assert.Equal(new List<List<string>>
        {
            new List<string> { "bat", "car", "dog" },
            new List<string> { "apple", "banana", "elephant" }
        }, result);
    }

    [Fact]
    public void HandlesAnEmptyArray()
    {
        var words = new List<string>();
        var size = 3;
        var result = Exercice3.SizeSplitter(words, size);
        Assert.Equal(new List<List<string>> { new List<string>(), new List<string>() }, result);
    }

    [Fact]
    public void HandlesNoWordsOfTheGivenSize()
    {
        var words = new List<string> { "apple", "banana", "elephant" };
        var size = 3;
        var result = Exercice3.SizeSplitter(words, size);
        Assert.Equal(new List<List<string>>
        {
            new List<string>(),
            new List<string> { "apple", "banana", "elephant" }
        }, result);
    }

    [Fact]
    public void HandlesAllWordsOfTheGivenSize()
    {
        var words = new List<string> { "cat", "dog", "bat" };
        var size = 3;
        var result = Exercice3.SizeSplitter(words, size);
        Assert.Equal(new List<List<string>>
        {
            new List<string> { "bat", "cat", "dog" },
            new List<string>()
        }, result);
    }

    [Fact]
    public void SortsWordsAlphabeticallyWithinEachGroup()
    {
        var words = new List<string> { "dog", "bat", "apple", "cat" };
        var size = 3;
        var result = Exercice3.SizeSplitter(words, size);
        Assert.Equal(new List<List<string>>
        {
            new List<string> { "bat", "cat", "dog" },
            new List<string> { "apple" }
        }, result);
    }
}
