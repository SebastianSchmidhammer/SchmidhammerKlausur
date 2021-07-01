using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationTracker.Interfaces
{
    /// <summary>
    /// Interface for a location loader
    /// </summary>
    public interface ILocationLoader
    {
        /// <summary>
        /// Loads locations from a file path
        /// </summary>
        /// <param name="filePath">The path of the file, where the locations are stored.</param>
        /// <returns>A list of <see cref="ILocation"/> elements.</returns>
        IList<GPSLocation> Load(string filePath);
    }
}
