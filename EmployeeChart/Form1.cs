using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues <ObservablePoint>
                    {
                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues <ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(2,5),
                        new ObservablePoint(3,6),
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues <ObservablePoint>
                    {
                        new ObservablePoint(0,4),
                        new ObservablePoint(5,5),
                        new ObservablePoint(7,7),
                        new ObservablePoint(9,10),
                        new ObservablePoint(10,9)
                    },
                    PointGeometrySize = 15
                },
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
