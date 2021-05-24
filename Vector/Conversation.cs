using System;

namespace Vector.Velocity
{
    public static class Conversation
    {
        public static double ConvertFromMsToKm(double speed)
        {
            return (speed / 1000) / Constants.HOUR_PER_SECOND;
        }
    }   
}