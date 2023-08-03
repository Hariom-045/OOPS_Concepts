namespace OppsWorld.Classes___Interfaces;

public class HumanPlayer : IPlayer
{
    public void play()
    {
        Console.WriteLine("Playing with Human player");
    }

    public void celebrateVictory()
    {
        Console.WriteLine("Yayy...");
    }
}