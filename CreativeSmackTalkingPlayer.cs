using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _allTaunts = new List<string>()
        {
            "I roll dice like Snoop Dogg lives life... HIGH!",
            "I'll have my dice say hello to the I.S.S. as they go by...",
            "Whats the difference in my dice and Bill Gates bank account? My Dice have bigger numbers"
        };

        public override void Play(Player other)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, _allTaunts.Count);
            string randomTaunt = _allTaunts[randomIndex];

            Console.WriteLine($"Hey {other.Name}! {randomTaunt}");
            base.Play(other);
        }
    }
}