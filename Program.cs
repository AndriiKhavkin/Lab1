using System;
using System.Threading;

namespace Lab1
{
    public class Lab1
    {
        public static void Game(ref GameAccount UserName, ref GameAccount opponentName)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int value1 = rnd.Next(1, 7);
            Thread.Sleep(5);
            Random rnd2 = new Random(DateTime.Now.Millisecond);
            int value2 = rnd2.Next(1, 7);
            Console.WriteLine("Game: Player1 threw away:" + value1 + " Player 2 threw away:" + value2);
            if (value1 > value2)
            {
                Console.WriteLine("Player 1 win this game");
                UserName.WinGame(ref opponentName, 20);
            }
            else if (value1 == value2)
            {
                Console.WriteLine("Draw - rating did not change");
            }else{
                Console.WriteLine("Player 2 win this game");
                opponentName.WinGame( ref  UserName, 20);
            }
        }
        public static void Main(String[] args)
        {
            GameAccount Player1 = new GameAccount("Pavel", 100);
            GameAccount Player2 = new GameAccount("Illya", 100);
            
            Game(ref Player1, ref Player2);
            Game(ref Player1, ref Player2);
            Game(ref Player1, ref Player2);
            Game(ref Player1, ref Player2);
            
            Player1.ShowPlayerInfo();
            Player2.ShowPlayerInfo();
            Player1.ShowHistory();
            Player2.ShowHistory();
        }
    }
} 