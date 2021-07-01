using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LocationTracker
{
    public partial class ChartView : Form
    {
        public ChartView()
        {
            InitializeComponent();

            chtLocationMap.Series.Clear();
        }

        /// <summary>
        /// Updates the views content with the given locations.
        /// </summary>
        /// <param name="locations">The provided locations.</param>
        public void UpdateView(IList<GPSLocation> locations)
        {
            chtLocationMap.Series.Clear();

            Series series = chtLocationMap.Series.Add("Locations");
            series.ChartType = SeriesChartType.Point;
            chtLocationMap.ChartAreas[0].AxisX.Minimum = locations.Min(x => x.Longitude);
            chtLocationMap.ChartAreas[0].AxisX.Maximum = locations.Max(x => x.Longitude);
            chtLocationMap.ChartAreas[0].AxisY.Minimum = locations.Min(x => x.Latitude);
            chtLocationMap.ChartAreas[0].AxisY.Maximum = locations.Max(x => x.Latitude);
            foreach (var item in locations)
            {
                series.Points.AddXY(item.Longitude, item.Latitude);
            }
        }
    }
}