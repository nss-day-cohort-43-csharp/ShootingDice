using System;

namespace ShootingDice
{
    public class Player
    {
        public string Name { get; set; }
        public int DiceSize { get; set; } = 6;

        public virtual int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }

        public virtual void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            DeclareWinner(this, myRoll, other, otherRoll);
        }

        public void DeclareWinner(Player player1, int roll1, Player player2, int roll2)
        {
            Console.WriteLine($"{player1.Name} rolls a {roll1}");
            Console.WriteLine($"{player2.Name} rolls a {roll2}");
            if (roll1 > roll2)
            {
                Console.WriteLine($"{player1.Name} Wins!");
            }
            else if (roll1 < roll2)
            {
                Console.WriteLine($"{player2.Name} Wins!");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
        }
    }
}