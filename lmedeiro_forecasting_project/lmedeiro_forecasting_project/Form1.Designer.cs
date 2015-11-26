namespace lmedeiro_forecasting_project
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.stdDevTextBox = new System.Windows.Forms.TextBox();
            this.equityNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfGensLabel = new System.Windows.Forms.Label();
            this.numberOfGensTextBox = new System.Windows.Forms.TextBox();
            this.history_days_label = new System.Windows.Forms.Label();
            this.history_days_textBox = new System.Windows.Forms.TextBox();
            this.submitInfoButton = new System.Windows.Forms.Button();
            this.meanlabel = new System.Windows.Forms.Label();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(23, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(237, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Forecasting App";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(107, 160);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "equityName";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(646, 432);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "Equity Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "std Dev";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stdDevTextBox
            // 
            this.stdDevTextBox.Location = new System.Drawing.Point(15, 210);
            this.stdDevTextBox.Name = "stdDevTextBox";
            this.stdDevTextBox.Size = new System.Drawing.Size(67, 20);
            this.stdDevTextBox.TabIndex = 3;
            this.stdDevTextBox.Text = "std Dev";
            // 
            // equityNameTextBox
            // 
            this.equityNameTextBox.Location = new System.Drawing.Point(379, 34);
            this.equityNameTextBox.Name = "equityNameTextBox";
            this.equityNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.equityNameTextBox.TabIndex = 4;
            this.equityNameTextBox.Text = "Insert Equity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "std Dev";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfGensLabel
            // 
            this.numberOfGensLabel.AutoSize = true;
            this.numberOfGensLabel.Location = new System.Drawing.Point(376, 57);
            this.numberOfGensLabel.Name = "numberOfGensLabel";
            this.numberOfGensLabel.Size = new System.Drawing.Size(78, 13);
            this.numberOfGensLabel.TabIndex = 2;
            this.numberOfGensLabel.Text = "numberOfGens";
            this.numberOfGensLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfGensTextBox
            // 
            this.numberOfGensTextBox.Location = new System.Drawing.Point(379, 73);
            this.numberOfGensTextBox.Name = "numberOfGensTextBox";
            this.numberOfGensTextBox.Size = new System.Drawing.Size(104, 20);
            this.numberOfGensTextBox.TabIndex = 4;
            this.numberOfGensTextBox.Text = "Number of Generations";
            // 
            // history_days_label
            // 
            this.history_days_label.AutoSize = true;
            this.history_days_label.Location = new System.Drawing.Point(376, 96);
            this.history_days_label.Name = "history_days_label";
            this.history_days_label.Size = new System.Drawing.Size(93, 13);
            this.history_days_label.TabIndex = 2;
            this.history_days_label.Text = "history_days_label";
            this.history_days_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // history_days_textBox
            // 
            this.history_days_textBox.Location = new System.Drawing.Point(379, 112);
            this.history_days_textBox.Name = "history_days_textBox";
            this.history_days_textBox.Size = new System.Drawing.Size(104, 20);
            this.history_days_textBox.TabIndex = 4;
            this.history_days_textBox.Text = "history_days";
            // 
            // submitInfoButton
            // 
            this.submitInfoButton.Location = new System.Drawing.Point(514, 69);
            this.submitInfoButton.Name = "submitInfoButton";
            this.submitInfoButton.Size = new System.Drawing.Size(93, 26);
            this.submitInfoButton.TabIndex = 5;
            this.submitInfoButton.Text = "Submit Info";
            this.submitInfoButton.UseVisualStyleBackColor = true;
            // 
            // meanlabel
            // 
            this.meanlabel.AutoSize = true;
            this.meanlabel.Location = new System.Drawing.Point(12, 242);
            this.meanlabel.Name = "meanlabel";
            this.meanlabel.Size = new System.Drawing.Size(34, 13);
            this.meanlabel.TabIndex = 2;
            this.meanlabel.Text = "Mean";
            this.meanlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(15, 258);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.Size = new System.Drawing.Size(67, 20);
            this.meanTextBox.TabIndex = 3;
            this.meanTextBox.Text = "Mean";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 604);
            this.Controls.Add(this.submitInfoButton);
            this.Controls.Add(this.numberOfGensTextBox);
            this.Controls.Add(this.history_days_textBox);
            this.Controls.Add(this.equityNameTextBox);
            this.Controls.Add(this.meanTextBox);
            this.Controls.Add(this.stdDevTextBox);
            this.Controls.Add(this.history_days_label);
            this.Controls.Add(this.numberOfGensLabel);
            this.Controls.Add(this.meanlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainWindow";
            this.Text = "Forecasting App";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stdDevTextBox;
        private System.Windows.Forms.TextBox equityNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOfGensLabel;
        private System.Windows.Forms.TextBox numberOfGensTextBox;
        private System.Windows.Forms.Label history_days_label;
        private System.Windows.Forms.TextBox history_days_textBox;
        private System.Windows.Forms.Button submitInfoButton;
        private System.Windows.Forms.Label meanlabel;
        private System.Windows.Forms.TextBox meanTextBox;
    }
}

