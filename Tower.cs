using System;

namespace TreehouseDefense
{
	class Tower
	{
		protected virtual string Title {get;} = "Basic Tower";
		protected virtual int Range {get;} = 1;
		protected virtual int Power {get;} = 1;
		protected virtual double Accuracy {get;} = .75;
		private static readonly System.Random _random = new System.Random();
		private readonly MapLocation _location;

		public Tower(MapLocation location)
		{
			_location = location;
		}

		public override string ToString()
        {
            return $"{_location.ToString()} {this.Title}";
        }
		private bool IsSuccessfulShot()
		{
			return _random.NextDouble() <= Accuracy;
		}

		public void FireOnInvaders(IInvader[] invaders)
		{
			foreach(IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        Console.Write($"{this.ToString()} shot ");
						invader.DecreaseHealth(Power);
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine($"   ** Neutralized {invader.ToString()} at {invader.Location}! **");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{this.ToString()} fired and missed {invader.ToString()}");
                    }
                    break;
                }
            }
		}
	}
}