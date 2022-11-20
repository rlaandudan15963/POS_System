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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SaleStuff = new System.Windows.Forms.Button();
            this.DayChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TodaySale = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DaySales = new System.Windows.Forms.Button();
            this.WeekSale = new System.Windows.Forms.Button();
            this.MonthSale = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).BeginInit();
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
            chartArea4.Name = "ChartArea1";
            this.DayChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.DayChart.Legends.Add(legend4);
            this.DayChart.Location = new System.Drawing.Point(302, 12);
            this.DayChart.Name = "DayChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.DayChart.Series.Add(series4);
            this.DayChart.Size = new System.Drawing.Size(486, 377);
            this.DayChart.TabIndex = 111;
            this.DayChart.Text = "chart1";
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
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("굴림", 16F);
            this.textBox1.Location = new System.Drawing.Point(16, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(230, 32);
            this.textBox1.TabIndex = 115;
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Font = new System.Drawing.Font("굴림", 16F);
            this.textBox2.Location = new System.Drawing.Point(16, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(230, 32);
            this.textBox2.TabIndex = 117;
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
            this.DaySales.Location = new System.Drawing.Point(52, 301);
            this.DaySales.Name = "DaySales";
            this.DaySales.Size = new System.Drawing.Size(157, 28);
            this.DaySales.TabIndex = 118;
            this.DaySales.Text = "일 매출 현황";
            this.DaySales.UseVisualStyleBackColor = true;
            this.DaySales.Click += new System.EventHandler(this.DaySales_Click);
            // 
            // WeekSale
            // 
            this.WeekSale.Location = new System.Drawing.Point(52, 339);
            this.WeekSale.Name = "WeekSale";
            this.WeekSale.Size = new System.Drawing.Size(157, 28);
            this.WeekSale.TabIndex = 119;
            this.WeekSale.Text = "주 매출 현황";
            this.WeekSale.UseVisualStyleBackColor = true;
            this.WeekSale.Click += new System.EventHandler(this.WeekSale_Click);
            // 
            // MonthSale
            // 
            this.MonthSale.Location = new System.Drawing.Point(52, 373);
            this.MonthSale.Name = "MonthSale";
            this.MonthSale.Size = new System.Drawing.Size(157, 28);
            this.MonthSale.TabIndex = 120;
            this.MonthSale.Text = "월 매출 현황";
            this.MonthSale.UseVisualStyleBackColor = true;
            this.MonthSale.Click += new System.EventHandler(this.MonthSale_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Font = new System.Drawing.Font("굴림", 16F);
            this.textBox3.Location = new System.Drawing.Point(16, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(230, 32);
            this.textBox3.TabIndex = 122;
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
            // WeekChart
            // 
            chartArea5.Name = "ChartArea1";
            this.WeekChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.WeekChart.Legends.Add(legend5);
            this.WeekChart.Location = new System.Drawing.Point(302, 12);
            this.WeekChart.Name = "WeekChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.WeekChart.Series.Add(series5);
            this.WeekChart.Size = new System.Drawing.Size(486, 377);
            this.WeekChart.TabIndex = 123;
            this.WeekChart.Text = "chart1";
            // 
            // MonthChart
            // 
            chartArea6.Name = "ChartArea1";
            this.MonthChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.MonthChart.Legends.Add(legend6);
            this.MonthChart.Location = new System.Drawing.Point(302, 12);
            this.MonthChart.Name = "MonthChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.MonthChart.Series.Add(series6);
            this.MonthChart.Size = new System.Drawing.Size(486, 377);
            this.MonthChart.TabIndex = 124;
            this.MonthChart.Text = "chart1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MonthChart);
            this.Controls.Add(this.WeekChart);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MonthSale);
            this.Controls.Add(this.WeekSale);
            this.Controls.Add(this.DaySales);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TodaySale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DayChart);
            this.Controls.Add(this.SaleStuff);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Shown += new System.EventHandler(this.Form3_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DayChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaleStuff;
        private System.Windows.Forms.DataVisualization.Charting.Chart DayChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TodaySale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DaySales;
        private System.Windows.Forms.Button WeekSale;
        private System.Windows.Forms.Button MonthSale;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeekChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MonthChart;
    }
}