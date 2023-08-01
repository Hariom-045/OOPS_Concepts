
namespace OppsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Cat());
            animals.Add(new Dog());
            animals.Add((new Giraffe()));
            AnimalUtility.makeNoise(animals);

        }
    }
}