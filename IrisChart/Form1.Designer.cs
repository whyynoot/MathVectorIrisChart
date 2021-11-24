
namespace IrisChart
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.euclidDistanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petalWidthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petalLengthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepalWidthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepalLengthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.euclidDistanceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalWidthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalLengthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalWidthChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalLengthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(126, 169);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(104, 33);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Open File...";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // euclidDistanceChart
            // 
            chartArea6.Name = "ChartArea1";
            this.euclidDistanceChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.euclidDistanceChart.Legends.Add(legend6);
            this.euclidDistanceChart.Location = new System.Drawing.Point(422, 69);
            this.euclidDistanceChart.Name = "euclidDistanceChart";
            this.euclidDistanceChart.Size = new System.Drawing.Size(276, 225);
            this.euclidDistanceChart.TabIndex = 2;
            this.euclidDistanceChart.Text = "chart1";
            // 
            // petalWidthChart
            // 
            chartArea7.Name = "ChartArea1";
            this.petalWidthChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.petalWidthChart.Legends.Add(legend7);
            this.petalWidthChart.Location = new System.Drawing.Point(798, 69);
            this.petalWidthChart.Name = "petalWidthChart";
            this.petalWidthChart.Size = new System.Drawing.Size(276, 225);
            this.petalWidthChart.TabIndex = 3;
            this.petalWidthChart.Text = "chart2";
            // 
            // petalLengthChart
            // 
            chartArea8.Name = "ChartArea1";
            this.petalLengthChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.petalLengthChart.Legends.Add(legend8);
            this.petalLengthChart.Location = new System.Drawing.Point(798, 330);
            this.petalLengthChart.Name = "petalLengthChart";
            this.petalLengthChart.Size = new System.Drawing.Size(276, 225);
            this.petalLengthChart.TabIndex = 4;
            this.petalLengthChart.Text = "chart3";
            // 
            // sepalWidthChart
            // 
            chartArea9.Name = "ChartArea1";
            this.sepalWidthChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.sepalWidthChart.Legends.Add(legend9);
            this.sepalWidthChart.Location = new System.Drawing.Point(422, 330);
            this.sepalWidthChart.Name = "sepalWidthChart";
            this.sepalWidthChart.Size = new System.Drawing.Size(276, 225);
            this.sepalWidthChart.TabIndex = 0;
            this.sepalWidthChart.Text = "chart4";
            // 
            // sepalLengthChart
            // 
            chartArea10.Name = "ChartArea1";
            this.sepalLengthChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.sepalLengthChart.Legends.Add(legend10);
            this.sepalLengthChart.Location = new System.Drawing.Point(61, 330);
            this.sepalLengthChart.Name = "sepalLengthChart";
            this.sepalLengthChart.Size = new System.Drawing.Size(276, 225);
            this.sepalLengthChart.TabIndex = 6;
            this.sepalLengthChart.Text = "chart5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 613);
            this.Controls.Add(this.sepalLengthChart);
            this.Controls.Add(this.sepalWidthChart);
            this.Controls.Add(this.petalLengthChart);
            this.Controls.Add(this.petalWidthChart);
            this.Controls.Add(this.euclidDistanceChart);
            this.Controls.Add(this.OpenFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.euclidDistanceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalWidthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petalLengthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalWidthChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepalLengthChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart euclidDistanceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart petalWidthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart petalLengthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepalWidthChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepalLengthChart;
    }
}

