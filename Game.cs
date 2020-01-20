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

                MapLocation location = path.GetLocationAt(8);
                Console.WriteLine($"{location.X},{location.Y}");
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

            // bool isOnMap = map.OnMap(x);
            // Console.WriteLine(isOnMap);

            // Console.WriteLine(x.DistanceTo(5, 5));
        }
    }
}