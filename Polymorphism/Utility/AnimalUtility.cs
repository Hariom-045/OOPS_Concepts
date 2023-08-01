using System.Collections;

namespace OppsWorld;

public class AnimalUtility
{
    public static void makeNoise(List<IAnimal> animals)
    {
        Console.WriteLine("Total Animals are : "+ animals.Count);
        for (int i = 0; i < animals.Count; i++)
        {
            animals[i].sound();
        }
    }
}