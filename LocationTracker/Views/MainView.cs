using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationTracker
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the main view
        /// </summary>
        public void Start()
        {
            Application.Run(this);
        }
    }
}
