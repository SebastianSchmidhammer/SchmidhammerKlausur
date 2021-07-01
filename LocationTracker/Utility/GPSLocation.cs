using System;

namespace LocationTracker
{
    /// <summary>
    /// Represents a location at a specific time.
    /// </summary>
    public class GPSLocation
    {
        /// <summary>
        /// The exact time, the location was reported.
        /// </summary>
        public DateTime TimeStamp { get; }

        /// <summary>
        /// Longitude of the location
        /// </summary>
        public double Longitude { get; }

        /// <summary>
        /// Latitude of the location
        /// </summary>
        public double Latitude { get; }

        public GPSLocation(double longitude, double latitude, DateTime timeStamp)
        {
            Longitude = longitude;
            Latitude = latitude;
            TimeStamp = timeStamp;
        }
    }
}
