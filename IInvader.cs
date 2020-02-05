namespace TreehouseDefense
{
    interface IMappable
    {
        MapLocation Location {get;}
    }

    interface IMovable
    {
        void Move();
    }

    interface IInvader : IMappable,IMovable
    {
		int Health {get;}
		bool HasScored {get;}
		bool IsNeutralized {get;}
		bool IsActive {get;}
		void DecreaseHealth(int factor);
    }
}