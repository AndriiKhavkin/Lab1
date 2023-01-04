using System;
using System.Threading;

namespace Lab1
{
    public class Lab1
    {
        
        public static void Main(String[] args)
        {
            GameAccount Player1 = new GameAccount("Pavel", 100);
            GameAccount Player2 = new GameAccount("Illya", 100);
            
            GameLogic.Game(ref Player1, ref Player2);
            GameLogic.Game(ref Player1, ref Player2);
            GameLogic.Game(ref Player1, ref Player2);
            GameLogic.Game(ref Player1, ref Player2);
            
            Player1.ShowPlayerInfo();
            Player2.ShowPlayerInfo();
            Player1.ShowHistory();
            Player2.ShowHistory();
        }
    }
} 