using System;

namespace ShootingDice
{
    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write($"{Name}, please enter your roll (1-{DiceSize}): ");
            int roll = int.Parse(Console.ReadLine());
            while (roll < 1 || roll > DiceSize)
            {
                Console.Write($"stop tryna put numbers in that aren't on the dice. Please enter your roll (1-{DiceSize}): ");
                roll = int.Parse(Console.ReadLine());
            }
            return roll;
        }
    }
}
