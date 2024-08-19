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

namespace 测试温湿度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Title time = new Title("时间", Docking.Bottom);
            Title wsy = new Title("温度/湿度/氧气", Docking.Left);
            Title fs = new Title("风速", Docking.Right);
            chart1.Titles.Add(time);
            chart1.Titles.Add(wsy);
            chart1.Titles.Add(fs);
            chart1.Series.Add("温度");
            chart1.Series.Add("湿度");
            chart1.Series.Add("氧气");
            chart1.Series.Add("风速");
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            chart1.Series[3].ChartType = SeriesChartType.Line;
        }
    }
}
