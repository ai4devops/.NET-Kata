namespace Exercice2.Tests;

public class Exercice2Tests
{
    [Fact]
    public void ReturnsCorrectSumForValidRange()
    {
        Assert.Equal(15, Exercice2.SumRange(1, 5)); // 1+2+3+4+5=15
        Assert.Equal(25, Exercice2.SumRange(3, 7)); // 3+4+5+6+7=25
        Assert.Equal(5, Exercice2.SumRange(5, 5));  // 5
    }

    [Fact]
    public void ReturnsMinusOneWhenMinIsGreaterThanMax()
    {
        Assert.Equal(-1, Exercice2.SumRange(5, 1));
        Assert.Equal(-1, Exercice2.SumRange(10, 5));
    }

    [Fact]
    public void ReturnsCorrectSumForNegativeRanges()
    {
        Assert.Equal(0, Exercice2.SumRange(-3, 3)); // -3+-2+-1+0+1+2+3=0
        Assert.Equal(-15, Exercice2.SumRange(-5, -1)); // -5+-4+-3+-2+-1=-15
    }

    [Fact]
    public void ReturnsCorrectSumWhenRangeIncludesZero()
    {
        Assert.Equal(6, Exercice2.SumRange(0, 3)); // 0+1+2+3=6
        Assert.Equal(-6, Exercice2.SumRange(-3, 0)); // -3+-2+-1+0=-6
    }
}
