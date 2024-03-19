using System;
using System.Windows.Forms;

namespace Maslova_cs_pr21_23
{
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load data from the previous form
        /// </summary>
        private void DiagramForm_Load(object sender, EventArgs e)
        {
            AverageMarkChart.Series[0].Name = VedomostTableForm.groupName;
            for (int i = 0; i < VedomostTableForm.subjectNames.Count; i++)
            {
                AverageMarkChart.Series[0].Points.AddXY(i, VedomostTableForm.averageMarks[i]);
                AverageMarkChart.Series[0].Points[i].Label = VedomostTableForm.subjectNames[i];
                AverageMarkChart.Series[0].Points[i].Name = VedomostTableForm.subjectNames[i];
            }
        }
    }
}
