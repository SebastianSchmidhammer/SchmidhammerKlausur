using LocationTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationTracker
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView view = new MainView();
            MainModel model = new MainModel();
            MainPresenter presenter = new MainPresenter(view, model, new CsvLocationLoader());
            presenter.Start();
        }
    }
}
