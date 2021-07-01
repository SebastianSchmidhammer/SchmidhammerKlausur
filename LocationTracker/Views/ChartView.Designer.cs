
namespace LocationTracker
{
    partial class ChartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chtLocationMap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtLocationMap)).BeginInit();
            this.SuspendLayout();
            // 
            // chtLocationMap
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLocationMap.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtLocationMap.Legends.Add(legend1);
            this.chtLocationMap.Location = new System.Drawing.Point(13, 13);
            this.chtLocationMap.Name = "chtLocationMap";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Locations";
            this.chtLocationMap.Series.Add(series1);
            this.chtLocationMap.Size = new System.Drawing.Size(560, 425);
            this.chtLocationMap.TabIndex = 0;
            this.chtLocationMap.Text = "chart1";
            title1.Name = "Locations";
            this.chtLocationMap.Titles.Add(title1);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.chtLocationMap);
            this.Name = "ChartView";
            this.Text = "ChartView";
            ((System.ComponentModel.ISupportInitialize)(this.chtLocationMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtLocationMap;
    }
}