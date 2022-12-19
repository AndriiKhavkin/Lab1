using System;

namespace Lab1
{
    public class GameHistory
    {
        private static int Games = 0;
        private int GameID;
        private GameAccount FirstPlayer;
        private GameAccount SecondPlayer;
        private bool didWinFirstPlayer;
        private int GameRating;

        public string GetPlayerOneName() { return FirstPlayer.GetUserName(); }
        public string GetPlayerTwoName() { return SecondPlayer.GetUserName(); }
        public bool IsFirstPlayerWin() { return didWinFirstPlayer; }

        public GameHistory(GameAccount firstPlayer, GameAccount secondPlayer, bool bFirstPlayerWin, int RatingGame)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            didWinFirstPlayer = bFirstPlayerWin;
            GameRating = RatingGame;
            GameID = Games++;
        }

        public void ShowInfo()
        { 
            Console.Write("Game ID: " + GameID + "  Player One: " + FirstPlayer.GetUserName() + "  Player Two: " + SecondPlayer.GetUserName() + "  Rating for the game: " + GameRating + "  Winner of the game was ");
            if (didWinFirstPlayer)
            {
                Console.WriteLine(FirstPlayer.GetUserName());
            }
            else
            {
                Console.WriteLine(SecondPlayer.GetUserName());
            }
        }
    }
    
}