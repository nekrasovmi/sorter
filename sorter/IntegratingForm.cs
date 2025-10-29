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
            //DrawFunction();
            
            double scale = 40;
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(OnPaint);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            DrawAxes(g);
            //DrawFunction(g, x => Math.Sin(x));
        }

        private void DrawAxes(Graphics g)
        {
            int Width = pictureBox2.Width;
            int Higth = pictureBox2.Height;
            double scale = 40;
            Pen axisPen = new Pen(Color.Black, 2);
            g.DrawLine(axisPen, 0, Higth/2, Width, Higth/2);
            g.DrawLine(axisPen, Width/2, 0, Width /2, Higth);
            Pen gridPen = new Pen(Color.LightGray,1);
            Font font = new Font("Arial",8);
            for (int i=-10;i<=10;i++)
            {
                int x = Width / 2 + (int)(i * scale);
                int y = Higth / 2 + (int)(i * scale);
                g.DrawLine(gridPen, x, 0, x, Higth);
                g.DrawLine(gridPen, 0, y, Width, y);
            }
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
