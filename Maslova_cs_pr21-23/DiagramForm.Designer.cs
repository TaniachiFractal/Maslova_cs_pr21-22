namespace Maslova_cs_pr21_23
{
    partial class DiagramForm
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
            this.AverageMarkChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.AverageMarkChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AverageMarkChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AverageMarkChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AverageMarkChart.Legends.Add(legend1);
            this.AverageMarkChart.Location = new System.Drawing.Point(12, 12);
            this.AverageMarkChart.Name = "AverageMarkChart";
            this.AverageMarkChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.Name = "Группа AA-00-00";
            series1.ShadowColor = System.Drawing.Color.MidnightBlue;
            series1.ShadowOffset = 2;
            this.AverageMarkChart.Series.Add(series1);
            this.AverageMarkChart.Size = new System.Drawing.Size(745, 507);
            this.AverageMarkChart.TabIndex = 0;
            this.AverageMarkChart.Text = "chart1";
            // 
            // DiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 531);
            this.Controls.Add(this.AverageMarkChart);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DiagramForm";
            this.Text = "Диаграмма";
            this.Load += new System.EventHandler(this.DiagramForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AverageMarkChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart AverageMarkChart;
    }
}