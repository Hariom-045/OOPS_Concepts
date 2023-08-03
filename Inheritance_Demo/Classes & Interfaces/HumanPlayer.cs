namespace OppsWorld.Classes___Interfaces;

public class HumanPlayer : Player, IPlayer
{
    public void play()
    {
        Console.WriteLine("Playing with Human player");
    }

   
    public void celebrateVictory()
    {
        Console.WriteLine("Human player won Hurray.....");
    }

    
}