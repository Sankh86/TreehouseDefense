namespace TreehouseDefense
{
    class ShotgunTower : Tower
    {
        protected override string Title {get;} = "Shotgun Tower";
        protected override int Power {get;} = 2;
		protected override double Accuracy {get;} = .55;
        public ShotgunTower(MapLocation location) : base(location)
        {}
    }
}