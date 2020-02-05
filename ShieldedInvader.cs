namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();
        public ShieldedInvader(Path path) : base(path)
        {}

        protected override string Title {get;} ="Shielded Invader";
        public override int Health {get; protected set;} = 2;
        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() > .5)
            {
            base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine($"and hit {this.ToString()} but it was deflected!");
            }
        }
    }
}