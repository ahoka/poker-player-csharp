using System;

namespace Poker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var player = new Player();
            player.Start();

            Console.ReadLine();

            player.Stop();
        }
    }
}
