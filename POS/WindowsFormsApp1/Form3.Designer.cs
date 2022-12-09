namespace WindowsFormsApp1
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.SaleStuff = new System.Windows.Forms.Button();
            this.DayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TodaySale = new System.Windows.Forms.TextBox();
            this.WeekMean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthMean = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DaySales = new System.Windows.Forms.Button();
            this.MonthSale = new System.Windows.Forms.Button();
            this.YearMean = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleStuff
            // 
            this.SaleStuff.Location = new System.Drawing.Point(631, 410);
            this.SaleStuff.Name = "SaleStuff";
            this.SaleStuff.Size = new System.Drawing.Size(157, 28);
            this.SaleStuff.TabIndex = 110;
            this.SaleStuff.Text = "뒤로가기";
            this.SaleStuff.UseVisualStyleBackColor = true;
            this.SaleStuff.Click += new System.EventHandler(this.SaleStuff_Click);
            // 
            // DayChart
            // 
            chartArea1.Name = "ChartArea1";
            this.DayChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DayChart.Legends.Add(legend1);
            this.DayChart.Location = new System.Drawing.Point(302, 12);
            this.DayChart.Name = "DayChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "일매출";
            this.DayChart.Series.Add(series1);
            this.DayChart.Size = new System.Drawing.Size(486, 377);
            this.DayChart.TabIndex = 111;
            this.DayChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "월 일 매출";
            this.DayChart.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 112;
            this.label1.Text = "금일 매출";
            // 
            // TodaySale
            // 
            this.TodaySale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TodaySale.Font = new System.Drawing.Font("굴림", 16F);
            this.TodaySale.Location = new System.Drawing.Point(16, 34);
            this.TodaySale.Name = "TodaySale";
            this.TodaySale.ReadOnly = true;
            this.TodaySale.Size = new System.Drawing.Size(230, 32);
            this.TodaySale.TabIndex = 113;
            this.TodaySale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeekMean
            // 
            this.WeekMean.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.WeekMean.Font = new System.Drawing.Font("굴림", 16F);
            this.WeekMean.Location = new System.Drawing.Point(16, 104);
            this.WeekMean.Name = "WeekMean";
            this.WeekMean.ReadOnly = true;
            this.WeekMean.Size = new System.Drawing.Size(230, 32);
            this.WeekMean.TabIndex = 115;
            this.WeekMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 114;
            this.label2.Text = "주 평균 매출";
            // 
            // MonthMean
            // 
            this.MonthMean.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MonthMean.Font = new System.Drawing.Font("굴림", 16F);
            this.MonthMean.Location = new System.Drawing.Point(16, 180);
            this.MonthMean.Name = "MonthMean";
            this.MonthMean.ReadOnly = true;
            this.MonthMean.Size = new System.Drawing.Size(230, 32);
            this.MonthMean.TabIndex = 117;
            this.MonthMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 116;
            this.label3.Text = "월 평균 매출";
            // 
            // DaySales
            // 
            this.DaySales.Location = new System.Drawing.Point(52, 314);
            this.DaySales.Name = "DaySales";
            this.DaySales.Size = new System.Drawing.Size(157, 28);
            this.DaySales.TabIndex = 118;
            this.DaySales.Text = "일 매출 현황";
            this.DaySales.UseVisualStyleBackColor = true;
            this.DaySales.Click += new System.EventHandler(this.DaySales_Click);
            // 
            // MonthSale
            // 
            this.MonthSale.Location = new System.Drawing.Point(52, 361);
            this.MonthSale.Name = "MonthSale";
            this.MonthSale.Size = new System.Drawing.Size(157, 28);
            this.MonthSale.TabIndex = 120;
            this.MonthSale.Text = "월 매출 현황";
            this.MonthSale.UseVisualStyleBackColor = true;
            this.MonthSale.Click += new System.EventHandler(this.MonthSale_Click);
            // 
            // YearMean
            // 
            this.YearMean.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.YearMean.Font = new System.Drawing.Font("굴림", 16F);
            this.YearMean.Location = new System.Drawing.Point(16, 251);
            this.YearMean.Name = "YearMean";
            this.YearMean.ReadOnly = true;
            this.YearMean.Size = new System.Drawing.Size(230, 32);
            this.YearMean.TabIndex = 122;
            this.YearMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 121;
            this.label4.Text = "년 총 매출";
            // 
            // MonthChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MonthChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MonthChart.Legends.Add(legend2);
            this.MonthChart.Location = new System.Drawing.Point(302, 12);
            this.MonthChart.Name = "MonthChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "월매출";
            this.MonthChart.Series.Add(series2);
            this.MonthChart.Size = new System.Drawing.Size(486, 377);
            this.MonthChart.TabIndex = 124;
            this.MonthChart.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "년도 월 매출";
            this.MonthChart.Titles.Add(title2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16F);
            this.label5.Location = new System.Drawing.Point(252, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 125;
            this.label5.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 16F);
            this.label6.Location = new System.Drawing.Point(252, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 22);
            this.label6.TabIndex = 126;
            this.label6.Text = "원";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16F);
            this.label7.Location = new System.Drawing.Point(252, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 127;
            this.label7.Text = "원";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 16F);
            this.label8.Location = new System.Drawing.Point(252, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 128;
            this.label8.Text = "원";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MonthChart);
            this.Controls.Add(this.YearMean);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MonthSale);
            this.Controls.Add(this.DaySales);
            this.Controls.Add(this.MonthMean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeekMean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TodaySale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayChart);
            this.Controls.Add(this.SaleStuff);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Shown += new System.EventHandler(this.Form3_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaleStuff;
        private System.Windows.Forms.DataVisualization.Charting.Chart DayChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TodaySale;
        private System.Windows.Forms.TextBox WeekMean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonthMean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DaySales;
        private System.Windows.Forms.Button MonthSale;
        private System.Windows.Forms.TextBox YearMean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}