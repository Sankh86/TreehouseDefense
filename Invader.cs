namespace TreehouseDefense
{
	class Invader
	{
		protected virtual string Title {get;} ="Basic Invader";
		private readonly Path _path;
		private int _pathStep = 0;
		protected virtual int StepSize {get;} =1;
		public MapLocation Location => _path.GetLocationAt(_pathStep);
		public virtual int Health {get; protected set;} = 2;
		public bool HasScored => _pathStep >= _path.Length;
		public bool IsNeutralized => Health <= 0;
		public bool IsActive => !(IsNeutralized || HasScored);

		public Invader(Path path)
		{
			_path = path;
		}

		public override string ToString()
        {
            return $"{this.Title}";
        }
		public void Move() => _pathStep += StepSize;

		public virtual void DecreaseHealth(int factor)
		{
			Health -= factor;
			System.Console.WriteLine($"and hit {this.ToString()}!");
		}
	}
}