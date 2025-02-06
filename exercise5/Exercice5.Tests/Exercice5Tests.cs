namespace Exercice5.Tests;

public class UnitTest1
{
    [Fact]
    public void FindsPairThatSumsToTarget()
    {
        var result = Exercice5.FindSumPair([3, 5, 9, 2, 8, 10, 11], 19);
        Assert.Contains(9, result);
        Assert.Contains(10, result);
    }

    [Fact]
    public void ReturnsEmptyArrayWhenNoPairSumsToTarget()
    {
        var result = Exercice5.FindSumPair([3, 5, 7, 2, 8, 10, 11], 20);
        Assert.Empty(result);
    }

    [Fact]
    public void WorksWithNegativeNumbers()
    {
        var result = Exercice5.FindSumPair([-3, 4, 1, 2], -1);
        Assert.Contains(-3, result);
        Assert.Contains(2, result);
    }

    [Fact]
    public void FindsCorrectPairWithMixedNumbers()
    {
        var result = Exercice5.FindSumPair([1, 2, 3, -2, -1, -4], -1);
        Assert.Contains(-2, result);
        Assert.Contains(1, result);
    }

    [Fact]
    public void ReturnsEmptyArrayForEmptyInput()
    {
        var result = Exercice5.FindSumPair([], 5);
        Assert.Empty(result);
    }
}
