using OppsWorld;
using OppsWorld.Classes___Interfaces;

namespace OppsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // ComputerPlayer computerPlayer = new ComputerPlayer();
            //computerPlayer.play();
            //computerPlayer.celebrateVictory();
            //HumanPlayer humanPlayer = new HumanPlayer();
            //humanPlayer.play();
            //humanPlayer.celebrateVictory();
            //Till this point we can see that there's is plenty of things wrong because celebrate victory method
            // is doing same work in both and is redundent, also in future if Iplayer Interface is implemented
            // by some other class then also we're bound to implement the celbration method. But celebration is
            // same always. if it needs to be unique then insted of implementing it in every player we can inherit
            // it and override the method if we found it necessary to do so.
            
            
            //After using Inheritance
            ComputerPlayer computerplayer = new ComputerPlayer();
            computerplayer.play();
            //Here only defined method runs in parent class
            computerplayer.celebrateVictory();

            HumanPlayer humanPlayer = new HumanPlayer();
            humanPlayer.play();
            //Now overriden method will be running.
            humanPlayer.celebrateVictory();




        }
    }
}