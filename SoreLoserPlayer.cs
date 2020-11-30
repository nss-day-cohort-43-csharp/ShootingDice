namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll < otherRoll)
            {
                throw new RageQuitException();
            }

            DeclareWinner(this, myRoll, other, otherRoll);
        }
    }
}