namespace TreehouseDefense
{
    class Level
    {
        private readonly IInvader[] _invaders;
        public Tower[] Towers {get; set;}

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns: true if player wins, false if player loses
        public bool Play()
        {
            //Run until invaders all dead, or they reach end
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders >0)
            {
                //Each tower shoots
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //Count remaining active invaders
                remainingInvaders = 0;
                foreach (IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();
                        if (invader.HasScored)
                        {
                            System.Console.WriteLine($"{invader.ToString()} has bypassed your towers!");
                            return false;
                        }

                        remainingInvaders += 1;
                    }
                }
            }
            return true;
        }
    }
}