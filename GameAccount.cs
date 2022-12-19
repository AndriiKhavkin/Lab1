using System;
using System.Collections.Generic;

namespace Lab1
{
    public class GameAccount
    {
        public GameAccount(string userName, int rating = 0, int gamesCount = 0)
        {
            UserName = userName;
            CurrentRating = rating < 1 ? 1 : rating;//перевірка чи не є рейтинг менше 1
            GamesCount = gamesCount;
        }
            
        private string UserName;
        private int CurrentRating;
        private int GamesCount;
        
        private List<GameHistory> GamesHistory = new List<GameHistory>();
        
        public void WinGame(ref GameAccount opponentName, int gameRating)
        {
            if (CurrentRating < gameRating || opponentName.GetRating() < gameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + opponentName.GetUserName() + "(" + opponentName.GetRating() + ")" + " cannot play with rating " + gameRating);
                return;
            }
            
            opponentName.SetGamesCount(opponentName.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating += gameRating;
            opponentName.SetRating(opponentName.GetRating() - gameRating);

            GamesHistory.Add( new GameHistory(this, opponentName, true, gameRating));
        }
            
        public void LoseGame(ref GameAccount opponentName, int gameRating)
        {            
            if (CurrentRating < gameRating || opponentName.GetRating() < gameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + opponentName.GetUserName() + "(" + opponentName.GetRating() + ")" + " cannot play with rating " + gameRating);
                return;
            }
            
            opponentName.SetGamesCount(opponentName.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating -= gameRating;
            opponentName.SetRating(opponentName.GetRating() + gameRating);
            
            GamesHistory.Add(new GameHistory(this, opponentName, true, gameRating));
        }
        
        public int GetRating() { return CurrentRating;}
        public void SetRating(int Value) { CurrentRating = Value < GlobalInfo.MinRating ? GlobalInfo.MinRating : Value ;}
        public int GetGamesCount() { return GamesCount;}
        public void SetGamesCount(int Value) { GamesCount = Value < 0 ? 0 : Value;}
        public string GetUserName() { return UserName;}

        

        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player: " + UserName + "\t\tRating: " + CurrentRating + "\tGames amount: " + GamesCount);
        }            


        public void ShowHistory()
        {
            Console.WriteLine("\nGame history of " +  UserName + ": ");
            foreach (GameHistory History in GamesHistory)
            {
                History.ShowInfo();
            }
        }
    }
}