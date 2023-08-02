namespace OppsWorld.Classes___Interfaces;

public class Goat : IAnimal, IGrazable
{
    public void speak()
    {
        Console.WriteLine("Goat is making sound....");
    }

    public void move()
    {
        Console.WriteLine(("Goat is moving...."));
    }

    public void graze()
    {
        Console.WriteLine("Goat is grazing....");
    }
}