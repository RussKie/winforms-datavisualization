using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NetFx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void UpdateChartSettings()
        {
            if (radioButtonBar.Checked)
            {
                // Set chart type to Bar
                chart1.Series["Default"].ChartType = SeriesChartType.Bar;
                chart1.Series["Series2"].ChartType = SeriesChartType.Bar;
                chart1.Series["Series3"].ChartType = SeriesChartType.Bar;
            }
            else
            {
                // Set chart type to Column
                chart1.Series["Default"].ChartType = SeriesChartType.Column;
                chart1.Series["Series2"].ChartType = SeriesChartType.Column;
                chart1.Series["Series3"].ChartType = SeriesChartType.Column;
            }

            // Disable/enable X axis margin
            chart1.ChartAreas["Default"].AxisX.IsMarginVisible = checkBoxShowMargin.Checked;

            // Disable/enable right angle axis
            chart1.ChartAreas["Default"].Area3DStyle.IsRightAngleAxes = RightAngleAxis.Checked;

            // Disable/enable clustered series
            chart1.ChartAreas["Default"].Area3DStyle.IsClustered = checkClustered.Checked;

        }

        private void radioButtonBar_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void radioButtonColumn_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMargin_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void checkBoxShowMarkers_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void comboBoxTension_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void RightAngleAxis_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }

        private void Inclination_ValueChanged(object sender, System.EventArgs e)
        {
            if (Inclination.Value > 90)
                Inclination.Value = -90;
            if (Inclination.Value < -90)
                Inclination.Value = 90;

            chart1.ChartAreas["Default"].Area3DStyle.Inclination = (int)Inclination.Value;
        }

        private void Rotation_ValueChanged(object sender, System.EventArgs e)
        {
            if (Rotation.Value > 180)
                Rotation.Value = -180;
            if (Rotation.Value < -180)
                Rotation.Value = 180;

            chart1.ChartAreas["Default"].Area3DStyle.Rotation = (int)Rotation.Value;
        }

        private void checkClustered_CheckedChanged(object sender, System.EventArgs e)
        {
            UpdateChartSettings();
        }
    }
}
