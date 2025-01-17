namespace Exercice4;

public class Exercice4
{
    public static int DaysUntil(string futureDate)
    {
        DateTime targetDate;
        if (!DateTime.TryParse(futureDate, out targetDate))
        {
            throw new ArgumentException("Invalid date format");
        }

        DateTime today = DateTime.Today;
        if (targetDate <= today)
        {
            return 0;
        }

        return (targetDate - today).Days;
    }
}
