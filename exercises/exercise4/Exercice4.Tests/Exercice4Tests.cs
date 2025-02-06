namespace Exercice4.Tests;

public class Exercice4Tests
{
    [Fact]
    public void HandlesTodaysDateCorrectly()
    {
        string today = DateTime.Today.ToString("yyyy-MM-dd");
        Assert.Equal(0, Exercice4.DaysUntil(today));
    }

    [Fact]
    public void ReturnsOneForTomorrow()
    {
        string tomorrow = DateTime.Today.AddDays(1).ToString("yyyy-MM-dd");
        Assert.Equal(1, Exercice4.DaysUntil(tomorrow));
    }

    [Fact]
    public void ReturnsZeroForYesterday()
    {
        string yesterday = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
        Assert.Equal(0, Exercice4.DaysUntil(yesterday));
    }
}
