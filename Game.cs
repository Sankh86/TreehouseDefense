using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                Invader[] invaders =
                {
                    new ShieldedInvader(path),
                    new ShieldedInvader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(2, 3, map)),
                    new Tower(new MapLocation(4, 1, map)),
                    new Tower(new MapLocation(6, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "Won!" : "Lost!"));

            }
            catch (OutOfBoundsException ex)
            {
                Console.Write(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.Write("Unhandled TreehouseDefenseException");
            }
            catch (Exception ex)
            {
                Console.Write($"Unhandled Exception: {ex}");
            }
        }
    }
}