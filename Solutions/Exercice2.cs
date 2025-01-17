namespace Exercice2;

public class Exercice2
{
    public static int SumRange(int min, int max)
    {
        if (min > max)
        {
            return -1;
        }

        if (min == max)
        {
            return min;
        }

        return min + SumRange(min + 1, max);
    }
}
