namespace lmedeiro_HW2_TSP
{
    partial class mainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.salesmanPathChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.citiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gaSetLabel = new System.Windows.Forms.Label();
            this.expPathLabel = new System.Windows.Forms.Label();
            this.fitness1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fitness2 = new System.Windows.Forms.TextBox();
            this.citiesChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesmanPathChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.meanLabel1 = new System.Windows.Forms.Label();
            this.mean1TextBox = new System.Windows.Forms.TextBox();
            this.variance1Label = new System.Windows.Forms.Label();
            this.variance1TextBox = new System.Windows.Forms.TextBox();
            this.size1Label = new System.Windows.Forms.Label();
            this.size1TextBox = new System.Windows.Forms.TextBox();
            this.mean2Label = new System.Windows.Forms.Label();
            this.variance2Label = new System.Windows.Forms.Label();
            this.size2Label = new System.Windows.Forms.Label();
            this.mean2TextBox = new System.Windows.Forms.TextBox();
            this.variance2TextBox = new System.Windows.Forms.TextBox();
            this.size2TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanPathChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanPathChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // salesmanPathChart
            // 
            chartArea1.Name = "ChartArea1";
            this.salesmanPathChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.salesmanPathChart.Legends.Add(legend1);
            this.salesmanPathChart.Location = new System.Drawing.Point(4, 120);
            this.salesmanPathChart.Name = "salesmanPathChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "tspPath";
            this.salesmanPathChart.Series.Add(series1);
            this.salesmanPathChart.Size = new System.Drawing.Size(393, 210);
            this.salesmanPathChart.TabIndex = 0;
            this.salesmanPathChart.Text = "tspPathText";
            this.salesmanPathChart.Visible = false;
            this.salesmanPathChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // citiesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.citiesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.citiesChart.Legends.Add(legend2);
            this.citiesChart.Location = new System.Drawing.Point(403, 120);
            this.citiesChart.Name = "citiesChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "tspCities";
            this.citiesChart.Series.Add(series2);
            this.citiesChart.Size = new System.Drawing.Size(393, 212);
            this.citiesChart.TabIndex = 0;
            this.citiesChart.Text = "1";
            this.citiesChart.Visible = false;
            this.citiesChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // gaSetLabel
            // 
            this.gaSetLabel.AutoSize = true;
            this.gaSetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gaSetLabel.Location = new System.Drawing.Point(319, 27);
            this.gaSetLabel.Name = "gaSetLabel";
            this.gaSetLabel.Size = new System.Drawing.Size(170, 34);
            this.gaSetLabel.TabIndex = 1;
            this.gaSetLabel.Text = "GA Results";
            // 
            // expPathLabel
            // 
            this.expPathLabel.AutoSize = true;
            this.expPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expPathLabel.Location = new System.Drawing.Point(41, 61);
            this.expPathLabel.Name = "expPathLabel";
            this.expPathLabel.Size = new System.Drawing.Size(74, 20);
            this.expPathLabel.TabIndex = 4;
            this.expPathLabel.Text = "Fitness 1";
            this.expPathLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // fitness1
            // 
            this.fitness1.Location = new System.Drawing.Point(45, 84);
            this.fitness1.Name = "fitness1";
            this.fitness1.Size = new System.Drawing.Size(225, 20);
            this.fitness1.TabIndex = 5;
            this.fitness1.Text = "Fitness 1";
            this.fitness1.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fitness 2";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // fitness2
            // 
            this.fitness2.Location = new System.Drawing.Point(45, 380);
            this.fitness2.Name = "fitness2";
            this.fitness2.Size = new System.Drawing.Size(225, 20);
            this.fitness2.TabIndex = 5;
            this.fitness2.Text = "Fitness 2";
            this.fitness2.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // citiesChart2
            // 
            chartArea3.Name = "ChartArea1";
            this.citiesChart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.citiesChart2.Legends.Add(legend3);
            this.citiesChart2.Location = new System.Drawing.Point(403, 424);
            this.citiesChart2.Name = "citiesChart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "tspCities2";
            this.citiesChart2.Series.Add(series3);
            this.citiesChart2.Size = new System.Drawing.Size(393, 229);
            this.citiesChart2.TabIndex = 6;
            this.citiesChart2.Text = "1";
            this.citiesChart2.Visible = false;
            this.citiesChart2.Click += new System.EventHandler(this.citiesChart2_Click);
            // 
            // salesmanPathChart2
            // 
            chartArea4.Name = "ChartArea1";
            this.salesmanPathChart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.salesmanPathChart2.Legends.Add(legend4);
            this.salesmanPathChart2.Location = new System.Drawing.Point(12, 424);
            this.salesmanPathChart2.Name = "salesmanPathChart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "tspPath2";
            this.salesmanPathChart2.Series.Add(series4);
            this.salesmanPathChart2.Size = new System.Drawing.Size(385, 229);
            this.salesmanPathChart2.TabIndex = 7;
            this.salesmanPathChart2.Text = "tspPathText";
            this.salesmanPathChart2.Visible = false;
            // 
            // meanLabel1
            // 
            this.meanLabel1.AutoSize = true;
            this.meanLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanLabel1.Location = new System.Drawing.Point(289, 61);
            this.meanLabel1.Name = "meanLabel1";
            this.meanLabel1.Size = new System.Drawing.Size(62, 20);
            this.meanLabel1.TabIndex = 4;
            this.meanLabel1.Text = "Mean 1";
            this.meanLabel1.Click += new System.EventHandler(this.label2_Click);
            // 
            // mean1TextBox
            // 
            this.mean1TextBox.Location = new System.Drawing.Point(293, 84);
            this.mean1TextBox.Name = "mean1TextBox";
            this.mean1TextBox.Size = new System.Drawing.Size(91, 20);
            this.mean1TextBox.TabIndex = 5;
            this.mean1TextBox.Text = "Mean 1";
            this.mean1TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // variance1Label
            // 
            this.variance1Label.AutoSize = true;
            this.variance1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variance1Label.Location = new System.Drawing.Point(399, 61);
            this.variance1Label.Name = "variance1Label";
            this.variance1Label.Size = new System.Drawing.Size(85, 20);
            this.variance1Label.TabIndex = 4;
            this.variance1Label.Text = "Variance 1";
            this.variance1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // variance1TextBox
            // 
            this.variance1TextBox.Location = new System.Drawing.Point(403, 84);
            this.variance1TextBox.Name = "variance1TextBox";
            this.variance1TextBox.Size = new System.Drawing.Size(91, 20);
            this.variance1TextBox.TabIndex = 5;
            this.variance1TextBox.Text = "Fitness 1";
            this.variance1TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // size1Label
            // 
            this.size1Label.AutoSize = true;
            this.size1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size1Label.Location = new System.Drawing.Point(504, 61);
            this.size1Label.Name = "size1Label";
            this.size1Label.Size = new System.Drawing.Size(53, 20);
            this.size1Label.TabIndex = 4;
            this.size1Label.Text = "Size 1";
            this.size1Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // size1TextBox
            // 
            this.size1TextBox.Location = new System.Drawing.Point(508, 84);
            this.size1TextBox.Name = "size1TextBox";
            this.size1TextBox.Size = new System.Drawing.Size(91, 20);
            this.size1TextBox.TabIndex = 5;
            this.size1TextBox.Text = "Fitness 1";
            this.size1TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // mean2Label
            // 
            this.mean2Label.AutoSize = true;
            this.mean2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mean2Label.Location = new System.Drawing.Point(289, 357);
            this.mean2Label.Name = "mean2Label";
            this.mean2Label.Size = new System.Drawing.Size(62, 20);
            this.mean2Label.TabIndex = 4;
            this.mean2Label.Text = "Mean 2";
            this.mean2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // variance2Label
            // 
            this.variance2Label.AutoSize = true;
            this.variance2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variance2Label.Location = new System.Drawing.Point(399, 357);
            this.variance2Label.Name = "variance2Label";
            this.variance2Label.Size = new System.Drawing.Size(85, 20);
            this.variance2Label.TabIndex = 4;
            this.variance2Label.Text = "Variance 2";
            this.variance2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // size2Label
            // 
            this.size2Label.AutoSize = true;
            this.size2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size2Label.Location = new System.Drawing.Point(504, 357);
            this.size2Label.Name = "size2Label";
            this.size2Label.Size = new System.Drawing.Size(53, 20);
            this.size2Label.TabIndex = 4;
            this.size2Label.Text = "Size 2";
            this.size2Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // mean2TextBox
            // 
            this.mean2TextBox.Location = new System.Drawing.Point(293, 380);
            this.mean2TextBox.Name = "mean2TextBox";
            this.mean2TextBox.Size = new System.Drawing.Size(91, 20);
            this.mean2TextBox.TabIndex = 5;
            this.mean2TextBox.Text = "Mean 2";
            this.mean2TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // variance2TextBox
            // 
            this.variance2TextBox.Location = new System.Drawing.Point(403, 380);
            this.variance2TextBox.Name = "variance2TextBox";
            this.variance2TextBox.Size = new System.Drawing.Size(91, 20);
            this.variance2TextBox.TabIndex = 5;
            this.variance2TextBox.Text = "Fitness 1";
            this.variance2TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // size2TextBox
            // 
            this.size2TextBox.Location = new System.Drawing.Point(508, 380);
            this.size2TextBox.Name = "size2TextBox";
            this.size2TextBox.Size = new System.Drawing.Size(91, 20);
            this.size2TextBox.TabIndex = 5;
            this.size2TextBox.Text = "Fitness 1";
            this.size2TextBox.TextChanged += new System.EventHandler(this.expPathBox_TextChanged);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(808, 669);
            this.Controls.Add(this.citiesChart2);
            this.Controls.Add(this.salesmanPathChart2);
            this.Controls.Add(this.fitness2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size2TextBox);
            this.Controls.Add(this.size1TextBox);
            this.Controls.Add(this.variance2TextBox);
            this.Controls.Add(this.variance1TextBox);
            this.Controls.Add(this.mean2TextBox);
            this.Controls.Add(this.mean1TextBox);
            this.Controls.Add(this.size2Label);
            this.Controls.Add(this.variance2Label);
            this.Controls.Add(this.size1Label);
            this.Controls.Add(this.mean2Label);
            this.Controls.Add(this.variance1Label);
            this.Controls.Add(this.meanLabel1);
            this.Controls.Add(this.fitness1);
            this.Controls.Add(this.expPathLabel);
            this.Controls.Add(this.gaSetLabel);
            this.Controls.Add(this.citiesChart);
            this.Controls.Add(this.salesmanPathChart);
            this.Name = "mainWindow";
            this.Text = "GA Run Results";
            ((System.ComponentModel.ISupportInitialize)(this.salesmanPathChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanPathChart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart salesmanPathChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart citiesChart;
        private System.Windows.Forms.Label gaSetLabel;
        private System.Windows.Forms.Label expPathLabel;
        private System.Windows.Forms.TextBox fitness1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fitness2;
        private System.Windows.Forms.DataVisualization.Charting.Chart citiesChart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart salesmanPathChart2;
        private System.Windows.Forms.Label meanLabel1;
        private System.Windows.Forms.TextBox mean1TextBox;
        private System.Windows.Forms.Label variance1Label;
        private System.Windows.Forms.TextBox variance1TextBox;
        private System.Windows.Forms.Label size1Label;
        private System.Windows.Forms.TextBox size1TextBox;
        private System.Windows.Forms.Label mean2Label;
        private System.Windows.Forms.Label variance2Label;
        private System.Windows.Forms.Label size2Label;
        private System.Windows.Forms.TextBox mean2TextBox;
        private System.Windows.Forms.TextBox variance2TextBox;
        private System.Windows.Forms.TextBox size2TextBox;
    }
}

