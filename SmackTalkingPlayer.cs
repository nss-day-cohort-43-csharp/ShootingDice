using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "Another one!";

        public override int Roll()
        {
            Console.WriteLine($"'{Taunt}' -- {Name}");
            return base.Roll();
        }
    }
}