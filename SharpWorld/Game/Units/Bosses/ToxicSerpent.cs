namespace SharpWorld.Game.Units.Bosses
{
    class ToxicSerpent : Monster
    {
        public ToxicSerpent() : base("Toxic Serpent", 10, 50, 5, 5)
        {
            //Toxic Serpent..
        }

        public override void Retaliate(Unit unit)
        {
            base.Retaliate(unit);
            if (unit.IsAlive())
            {
                unit.Damage(this, 1);
                GameWorld.Instance.Log("The serpent's poisonous gas damages you for 1hp!");
            }
        }

        public override void Died()
        {
            GameWorld.Instance.Log("Congratulations, you have defeated the Toxic Serpent. " +
                "The serpent has reigned over the garden for decades. " +
                "Many lives have been saved thanks to you." +
                "Take the serpents fang as your reward!");
        }
    }
}
