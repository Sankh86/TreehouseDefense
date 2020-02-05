namespace TreehouseDefense
{
    class BasicInvader : Invader
    {
        protected override string Title {get;} ="Basic Invader";
        public override int Health {get; protected set;} = 2;
        public BasicInvader(Path path) : base(path)
        {}
    }
}