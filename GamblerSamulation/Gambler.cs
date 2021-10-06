using System;
using System.Collections.Generic;
using System.Text;

namespace GamblerSamulation
{
    class Gambler
    {
        public void Game()
        {
            int stake = 100;
            int bet = 1;
            int stakeValue;

            Random ran = new Random();
            int toss = ran.Next(0, 2);
            if (toss == 1)
            {
                stakeValue = stake + bet;
                Console.WriteLine("Won the Game " + stakeValue);
            }
            else
            {
                stakeValue = stake - bet;
                Console.WriteLine("Loss the Game " + stakeValue);
            }
            
        }
    }
}
