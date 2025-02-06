namespace Exercice3;

public class Exercice3
{
    public static List<List<string>> SizeSplitter(List<string> words, int size)
    {
        var group1 = new List<string>();
        var group2 = new List<string>();

        foreach (var word in words)
        {
            if (word.Length == size)
            {
                group1.Add(word);
            }
            else
            {
                group2.Add(word);
            }
        }

        group1.Sort();
        group2.Sort();

        return new List<List<string>> { group1, group2 };
    }
}

