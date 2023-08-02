namespace OppsWorld.Classes___Interfaces;

public class Cat : IAnimal
{
    public void speak()
    {
        Console.WriteLine("Cat is making mew mew sound....");
    }

    public void move()
    {
        Console.WriteLine("Cat is doing cat walk.....");
    }
}