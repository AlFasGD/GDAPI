﻿using System;
using GDAPI.Enumerations.GeometryDash;

namespace GDAPI.Information.GeometryDash
{
    /// <summary>Provides information about the speeds of the player in the game.</summary>
    public static class Speeds
    {
        /// <summary>The units the player moves per second with a 1.0 speed multiplier.</summary>
        public const double UnitsPerSecond = 360;

        // These are no longer valid by a standard UnitsPerSecond * *SpeedMultiplier calculation; please verify.
        /// <summary>The speed multiplier for the slow speed (&lt;).</summary>
        public const double SlowSpeedMultiplier = 0.7;
        /// <summary>The speed multiplier for the normal speed (&gt;).</summary>
        public const double NormalSpeedMultiplier = 0.9;
        /// <summary>The speed multiplier for the fast speed (&gt;&gt;).</summary>
        public const double FastSpeedMultiplier = 1.1;
        /// <summary>The speed multiplier for the faster speed (&gt;&gt;&gt;).</summary>
        public const double FasterSpeedMultiplier = 1.3;
        /// <summary>The speed multiplier for the very faster speed (&gt;&gt;&gt;&gt;).</summary>
        public const double VeryFasterSpeedMultiplier = 1.6;

        /// <summary>The ACTUAL speed multiplier for the slow speed (&lt;) (concluded by dividing the actual speeds in units per second with UnitsPerSecond).</summary>
        public const double ActualSlowSpeedMultiplier = 0.697 + 0.001 * 2 / 3; // To avoid doing 666666666666666
        /// <summary>The ACTUAL speed multiplier for the normal speed (&gt;) (concluded by dividing the actual speeds in units per second with UnitsPerSecond).</summary>
        public const double ActualNormalSpeedMultiplier = 0.8655;
        /// <summary>The ACTUAL speed multiplier for the fast speed (&gt;&gt;) (concluded by dividing the actual speeds in units per second with UnitsPerSecond).</summary>
        public const double ActualFastSpeedMultiplier = 1.0761 + 0.0001 * 2 / 3;
        /// <summary>The ACTUAL speed multiplier for the faster speed (&gt;&gt;&gt;) (concluded by dividing the actual speeds in units per second with UnitsPerSecond).</summary>
        public const double ActualFasterSpeedMultiplier = 1.3;
        /// <summary>The ACTUAL speed multiplier for the very faster speed (&gt;&gt;&gt;&gt;) (concluded by dividing the actual speeds in units per second with UnitsPerSecond).</summary>
        public const double ActualVeryFasterSpeedMultiplier = 1.6;

        /// <summary>The speed in units per second of the slow speed (&lt;).</summary>
        public const double SlowSpeed = 251.16;
        /// <summary>The speed in units per second of the normal speed (&gt;).</summary>
        public const double NormalSpeed = 311.58;
        /// <summary>The speed in units per second of the fast speed (&gt;&gt;).</summary>
        public const double FastSpeed = 387.42;
        /// <summary>The speed in units per second of the faster speed (&gt;&gt;&gt;).</summary>
        public const double FasterSpeed = 468;
        /// <summary>The speed in units per second of the very faster speed (&gt;&gt;&gt;&gt;).</summary>
        public const double VeryFasterSpeed = 576;

        /// <summary>Gets the speed in units per second of the provided speed.</summary>
        /// <param name="speed">The speed to get the units per second of.</param>
        public static double GetSpeed(Speed speed)
        {
            switch (speed)
            {
                case Speed.Slow:
                    return SlowSpeed;
                case Speed.Default:
                case Speed.Normal:
                    return NormalSpeed;
                case Speed.Fast:
                    return FastSpeed;
                case Speed.Faster:
                    return FasterSpeed;
                case Speed.Fastest:
                    return VeryFasterSpeed;
            }
            throw new Exception("Invalid speed.");
        }
    }
}
