namespace OppsWorld.Classes___Interfaces;

public class Dog : IAnimal
{
    public void speak()
    {
        Console.WriteLine("Dog is Barking....");
    }

    public void move()
    {
        Console.WriteLine("Dog is moving....");
    }
}