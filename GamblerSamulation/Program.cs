using System;

namespace GamblerSamulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game!");

            Gambler gambler = new Gambler();
            gambler.Game();
        }
    }
}
