using System;

namespace LocationTracker
{
    /// <summary>
    /// Static class for view generation.
    /// </summary>
    public static class LocationViewFactory
    {
        /// <summary>
        /// Type of available views.
        /// </summary>
        public enum ViewType
        {
            List,
            Chart
        }

        /// <summary>
        /// Generates a new instance of type <see cref="ILocationView"/> with the selected behaviour.
        /// </summary>
        /// <param name="type">The behaviour of the requested view.</param>
        /// <returns>A fully initialized location view</returns>
        /// <exception cref="ArgumentException">Is thrown when an invalid or unknown <paramref name="type"/> is passed.</exception>
        public static ILocationView GenerateView(ViewType type)
        {
            switch (type)
            {
                case ViewType.List:
                    return new ListView();
                case ViewType.Chart:
                    return new ChartView();
                default:
                    throw new ArgumentException("Invalid location view type", nameof(type));
            }
        }
    }
}