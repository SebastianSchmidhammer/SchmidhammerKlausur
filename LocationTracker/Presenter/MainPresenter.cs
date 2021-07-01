using LocationTracker.Interfaces;
using LocationTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocationTracker
{

    public class MainPresenter
    {
        private MainView _mainView;
        private ChartView _chartView;
        private MainModel _model;
        private ILocationLoader _loader;

        /// <summary>
        /// CTor
        /// </summary>
        /// <param name="view">The main view of the application.</param>
        /// <param name="model">The main model of the application.</param>
        /// <param name="loader">Loader to load locations.</param>
        public MainPresenter(MainView view, MainModel model, ILocationLoader loader)
        {
            _mainView = view;
            _model = model;
            _loader = loader;

            // attach eventhandler methods here
        }

        /// <summary>
        /// Starts the application
        /// </summary>
        public void Start()
        {
            _mainView.Start();
        }
    }
}
