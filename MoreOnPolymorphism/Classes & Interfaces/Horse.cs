namespace OppsWorld.Classes___Interfaces;

public class Horse : IAnimal, IGrazable
{
    public void speak()
    {
        Console.WriteLine("Horse is making sound...");
    }

    public void move()
    {
        Console.WriteLine("Horse is moving with horse power....");
    }

    public void graze()
    {
        Console.WriteLine("Horse is Grazing.....");
    }
}