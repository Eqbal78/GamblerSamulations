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
            int percent=50;
            int winning = 0;
            int lossing = 0;
            
            int value = (stake * percent) / 100;
            winning = stake + value;
            Console.WriteLine("The Winning value of gambler is : " + winning);

            lossing = stake - value;
            Console.WriteLine("The Lossing value of gambler is : " + lossing);

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
