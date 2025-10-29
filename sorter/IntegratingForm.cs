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

namespace sorter
{
    public partial class IntegratingForm : Form
    {        
        public IntegratingForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.integralico;
            DrawFunction();
        }

        private void DrawFunction()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Add(new ChartArea());
            Series series = new Series
            {
                Name = "f(x) = x^2",
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = System.Drawing.Color.Blue
            };
            for (double x = -50; x <= 50; x += 0.1)
            {
                double y = x * x;
                series.Points.AddXY(x, y);
            }
            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
            //MenuForm.Instance.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///////2*x^2
            //y=x*x
            double a = 0;
            double b = 0;
            double dx = (b-a)/2;

            //Graphics g .
            ///

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = 
        }
    }
}
