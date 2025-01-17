namespace Exercice1;

public class Exercice1
{
    public static void BeerSong(int bouteilles)
    {
        while (bouteilles > 0)
        {
            Console.WriteLine($"{bouteilles} bottle{(bouteilles > 1 ? "s" : "")} of beer on the wall, {bouteilles} bottle{(bouteilles > 1 ? "s" : "")} of beer!");
            bouteilles--;
            Console.WriteLine($"Take one down and pass it around, {(bouteilles > 0 ? bouteilles.ToString() : "no more")} bottle{(bouteilles == 1 ? "" : "s")} of beer on the wall!\n");
        }
        Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer!");
        Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall!\n");
    }
}