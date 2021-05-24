using System;
using System.Collections.Generic;
using Vector.Velocity;

namespace Vector.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> velocities = new List<int> {10, 14, 200, 900, 3000, Constants.EARTH_ESCAPE, Constants.C};

            foreach (var item in velocities)
            {
                System.Console.WriteLine("{0} m/s är {1} km/h", item, Math.Round(Conversation.ConvertFromMsToKm(item), 2));
            }
        }
    }
}
