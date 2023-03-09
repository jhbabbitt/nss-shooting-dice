using System;

namespace ShootingDice
{
    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            base.Play(other);
            int myRoll = Roll();
            Console.WriteLine($"{Name} rolls a {myRoll + 1}");
            Console.WriteLine($"{other.Name} rolls a {other.Roll()}");

            if (myRoll + 1 > other.Roll())
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll + 1 < other.Roll())
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}

