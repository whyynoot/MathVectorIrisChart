using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrisChart;
using System.Windows.Forms.DataVisualization.Charting;

namespace IrisChart
{
    public partial class Form1 : Form
    {
        private IrisChart irisChart;
        private readonly string DefaultXName = "Irises";
        private readonly string DefaultYName = "Values";

        public Form1()
        {
            InitializeComponent();
            irisChart = new IrisChart();
            sepalWidthChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            sepalLengthChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            sepalWidthChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            petalLengthChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            petalWidthChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            sepalLengthChart.Titles.Add("Sepal Length");
            sepalWidthChart.Titles.Add("Sepal Width");
            petalLengthChart.Titles.Add("Petal Length");
            petalWidthChart.Titles.Add("Petal Width");
            euclidDistanceChart.Titles.Add("Distance");
            /*
                      Axis ax1 = new Axis();
                        ax1.Title = DefaultXName;
                        //sepalLengthChart.ChartAreas[0].AxisX = ax1;
                        sepalLengthChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                        Axis ay1 = new Axis();
                        ay1.Title = DefaultYName;
                        sepalLengthChart.ChartAreas[0].AxisY = ay1;

                        Axis ax2 = new Axis();
                        ax2.Title = DefaultXName;
                        sepalWidthChart.ChartAreas[0].AxisX = ax2;
                        Axis ay2 = new Axis();
                        ay2.Title = DefaultYName;
                        sepalWidthChart.ChartAreas[0].AxisY = ay2;
                        Axis ax3 = new Axis();
                        ax3.Title = DefaultXName;
                        petalLengthChart.ChartAreas[0].AxisX = ax3;
                        Axis ay3 = new Axis();
                        ay3.Title = DefaultYName;
                        petalLengthChart.ChartAreas[0].AxisY = ay3;
                        Axis ax4 = new Axis();
                        ax4.Title = DefaultXName;
                        petalWidthChart.ChartAreas[0].AxisX = ax4;
                        Axis ay4 = new Axis();
                        ay4.Title = DefaultYName;
                        petalWidthChart.ChartAreas[0].AxisY = ay4;
            */
        }

        /// <summary>
        /// Действия при нажатии на кнопку Open File
        /// </summary>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClearCharts();
                var fileDialog = new OpenFileDialog();
                fileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (fileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string filepath = fileDialog.FileName;
                    FileDialog fd = new FileDialog();
                    fd.OpenFile(filepath);
                    fd.FormatCsv();
                    irisChart.SetIrisArrays(fd.Csv);
                    irisChart.SetIrisAverages();
                    irisChart.SetDistances();
                    DrawCharts();
                }
                else
                {
                    throw new Exception(message: "File Dialog was closed!");
                }

           
            }
            catch (Exception ex)
            {
                string message = "Произошла ошибка: " + ex.Message.ToString();
                MessageBox.Show(message, message);
            }
        }

        /// <summary>
        /// Очистка полей для рисования
        /// </summary>
        private void ClearCharts() {
            sepalLengthChart.Series.Clear();
            sepalWidthChart.Series.Clear();
            petalLengthChart.Series.Clear();
            petalWidthChart.Series.Clear();
            euclidDistanceChart.Series.Clear();
        }

        /// <summary>
        /// Рисование всех метрик.
        /// </summary>
        private void DrawCharts() {
            sepalLengthChart.Series.Add("Setosa").Points.Add(irisChart.SetosaAverage[0]);
            sepalLengthChart.Series.Add("Versicolor").Points.Add(irisChart.VersicolorAverage[0]);
            sepalLengthChart.Series.Add("Virginica").Points.Add(irisChart.VirginicaAverage[0]);

            sepalWidthChart.Series.Add("Setosa").Points.Add(irisChart.SetosaAverage[1]);
            sepalWidthChart.Series.Add("Versicolor").Points.Add(irisChart.VersicolorAverage[1]);
            sepalWidthChart.Series.Add("Virginica").Points.Add(irisChart.VirginicaAverage[1]);


            petalLengthChart.Series.Add("Setosa").Points.Add(irisChart.SetosaAverage[2]);
            petalLengthChart.Series.Add("Versicolor").Points.Add(irisChart.VersicolorAverage[2]);
            petalLengthChart.Series.Add("Virginica").Points.Add(irisChart.VirginicaAverage[2]);

            petalWidthChart.Series.Add("Setosa").Points.Add(irisChart.SetosaAverage[3]);
            petalWidthChart.Series.Add("Versicolor").Points.Add(irisChart.VersicolorAverage[3]);
            petalWidthChart.Series.Add("Virginica").Points.Add(irisChart.VirginicaAverage[3]);

            Series series = euclidDistanceChart.Series.Add("");
            series.ChartType = SeriesChartType.Pie;
            series.Points.AddXY("S-Ver", irisChart.DistanceFromSetosaToVersicolor);
            series.Points.AddXY("S-Vir", irisChart.DistanceFromSetosaToVirginica);
            series.Points.AddXY("Ver-Vir", irisChart.DistanceFromVersicolorToVirginica);
            this.Refresh();
        }
    }
}
