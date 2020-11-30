using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            while (true)
            {
                Console.Write("Sooo what do you want to roll? ");
                string userDefinedRoll = Console.ReadLine();

                try
                {
                    int rollValue = int.Parse(userDefinedRoll);
                    return rollValue;
                }
                catch (Exception)
                {
                    continue;
                }
            }

        }
    }
}