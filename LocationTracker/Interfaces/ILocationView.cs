using System;
using System.Collections.Generic;

namespace LocationTracker
{
    /// <summary>
    /// Provides standardized access to views capable of displaying location data.
    /// </summary>
    public interface ILocationView
    {
        /// <summary>
        /// Occurs when refreshing of the displayed data is requested.
        /// </summary>
        event EventHandler OnRefreshRequested;

        /// <summary>
        /// Occurs when the view should be closed.
        /// </summary>
        event EventHandler OnCloseRequested;

        /// <summary>
        /// Overwrites the content of the view with the provided data.
        /// </summary>
        void UpdateView(IList<ILocation> locations);

        /// <summary>
        /// Shows the view.
        /// </summary>
        void ShowView();

        /// <summary>
        /// Closes the view.
        /// </summary>
        void CloseView();
    }
}