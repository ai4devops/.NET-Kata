namespace Exercice5;

public class Exercice5
{
    public static int[] FindSumPair(int[] numbers, int target)
    {
        var complements = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            int complement = target - number;
            if (complements.ContainsKey(complement))
            {
                return [complement, number];
            }
            if (!complements.ContainsKey(number))
            {
                complements[number] = 1;
            }
        }

        return [];
    }
}
