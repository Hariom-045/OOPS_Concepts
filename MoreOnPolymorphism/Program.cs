using OppsWorld.Classes___Interfaces;

namespace OppsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here we have created the list of interface type so we are coding against
            //an interface and it's good practice. Only thing to keep in mind is if we're coding against
            // the interface then we should abide by the interface contracts/rules/methods.
            List<IGrazable> grazableAnimals = new List<IGrazable>();
            grazableAnimals.Add(new Goat());
            grazableAnimals.Add(new Horse());
            grazeTheAnimals(grazableAnimals);

        }

        private static void grazeTheAnimals(List<IGrazable> grazableAnimals)
        {
            for (int i = 0; i < grazableAnimals.Count; i++)
            {
                grazableAnimals[i].graze();
            }
        }
    }
}