namespace Proj_1
{
    partial class ChartDisplayForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrowAnnotation2 = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.Chart_StockData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Button_UpdateStockData = new System.Windows.Forms.Button();
            this.Button_ShowPattern = new System.Windows.Forms.Button();
            this.DropDownMenu_SelectPattern = new System.Windows.Forms.ComboBox();
            this.Label_UpdateStartDate = new System.Windows.Forms.Label();
            this.Label_UpdateEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_StockData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DateTimePicker_StartDate
            // 
            this.DateTimePicker_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_StartDate.Location = new System.Drawing.Point(360, 806);
            this.DateTimePicker_StartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimePicker_StartDate.Name = "DateTimePicker_StartDate";
            this.DateTimePicker_StartDate.Size = new System.Drawing.Size(283, 26);
            this.DateTimePicker_StartDate.TabIndex = 4;
            this.DateTimePicker_StartDate.Value = new System.DateTime(2022, 1, 1, 15, 9, 0, 0);
            // 
            // DateTimePicker_EndDate
            // 
            this.DateTimePicker_EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker_EndDate.Location = new System.Drawing.Point(702, 808);
            this.DateTimePicker_EndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimePicker_EndDate.Name = "DateTimePicker_EndDate";
            this.DateTimePicker_EndDate.Size = new System.Drawing.Size(274, 26);
            this.DateTimePicker_EndDate.TabIndex = 5;
            this.DateTimePicker_EndDate.Value = new System.DateTime(2023, 7, 15, 15, 9, 0, 0);
            // 
            // Chart_StockData
            // 
            this.Chart_StockData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            arrowAnnotation2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            arrowAnnotation2.Height = 2D;
            arrowAnnotation2.Name = "ArrowAnnotation1";
            this.Chart_StockData.Annotations.Add(arrowAnnotation2);
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "area_OHLC";
            chartArea4.Name = "area_Volume";
            this.Chart_StockData.ChartAreas.Add(chartArea3);
            this.Chart_StockData.ChartAreas.Add(chartArea4);
            this.Chart_StockData.DataSource = this.aCandleStickBindingSource;
            legend2.Alignment = System.Drawing.StringAlignment.Far;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsDockedInsideChartArea = false;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend_stock";
            this.Chart_StockData.Legends.Add(legend2);
            this.Chart_StockData.Location = new System.Drawing.Point(30, 11);
            this.Chart_StockData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Chart_StockData.Name = "Chart_StockData";
            series3.ChartArea = "area_OHLC";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.CustomProperties = "PriceDownColor=Red, PriceUpColor=Green";
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend_stock";
            series3.Name = "series_OHLC";
            series3.XValueMember = "date";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series3.YValueMembers = "high, low, open, close";
            series3.YValuesPerPoint = 4;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "area_Volume";
            series4.Legend = "Legend_stock";
            series4.Name = "series_Volume";
            series4.XValueMember = "date";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueMembers = "volume";
            this.Chart_StockData.Series.Add(series3);
            this.Chart_StockData.Series.Add(series4);
            this.Chart_StockData.Size = new System.Drawing.Size(1313, 710);
            this.Chart_StockData.TabIndex = 9;
            this.Chart_StockData.Text = "chart1";
            this.Chart_StockData.Click += new System.EventHandler(this.Chart_StockData_Click);
            // 
            // Button_UpdateStockData
            // 
            this.Button_UpdateStockData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_UpdateStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UpdateStockData.Location = new System.Drawing.Point(1142, 770);
            this.Button_UpdateStockData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_UpdateStockData.Name = "Button_UpdateStockData";
            this.Button_UpdateStockData.Size = new System.Drawing.Size(201, 76);
            this.Button_UpdateStockData.TabIndex = 10;
            this.Button_UpdateStockData.Text = "Update Stock Data";
            this.Button_UpdateStockData.UseVisualStyleBackColor = true;
            this.Button_UpdateStockData.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_ShowPattern
            // 
            this.Button_ShowPattern.Location = new System.Drawing.Point(194, 802);
            this.Button_ShowPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_ShowPattern.Name = "Button_ShowPattern";
            this.Button_ShowPattern.Size = new System.Drawing.Size(111, 34);
            this.Button_ShowPattern.TabIndex = 11;
            this.Button_ShowPattern.Text = "Show Pattern";
            this.Button_ShowPattern.UseVisualStyleBackColor = true;
            this.Button_ShowPattern.Click += new System.EventHandler(this.Button_Pattern_Click);
            // 
            // DropDownMenu_SelectPattern
            // 
            this.DropDownMenu_SelectPattern.FormattingEnabled = true;
            this.DropDownMenu_SelectPattern.Items.AddRange(new object[] {
            "Bullish",
            "Bearish",
            "Neutral",
            "Marubozu",
            "Hammer",
            "Doji",
            "DragonFlyDoji",
            "GravestoneDoji"});
            this.DropDownMenu_SelectPattern.Location = new System.Drawing.Point(12, 808);
            this.DropDownMenu_SelectPattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DropDownMenu_SelectPattern.Name = "DropDownMenu_SelectPattern";
            this.DropDownMenu_SelectPattern.Size = new System.Drawing.Size(163, 28);
            this.DropDownMenu_SelectPattern.TabIndex = 12;
            this.DropDownMenu_SelectPattern.Text = "Select Pattern";
            // 
            // Label_UpdateStartDate
            // 
            this.Label_UpdateStartDate.AutoSize = true;
            this.Label_UpdateStartDate.Location = new System.Drawing.Point(424, 782);
            this.Label_UpdateStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_UpdateStartDate.Name = "Label_UpdateStartDate";
            this.Label_UpdateStartDate.Size = new System.Drawing.Size(140, 20);
            this.Label_UpdateStartDate.TabIndex = 13;
            this.Label_UpdateStartDate.Text = "Update Start Date";
            // 
            // Label_UpdateEndDate
            // 
            this.Label_UpdateEndDate.AutoSize = true;
            this.Label_UpdateEndDate.Location = new System.Drawing.Point(774, 782);
            this.Label_UpdateEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_UpdateEndDate.Name = "Label_UpdateEndDate";
            this.Label_UpdateEndDate.Size = new System.Drawing.Size(134, 20);
            this.Label_UpdateEndDate.TabIndex = 14;
            this.Label_UpdateEndDate.Text = "Update End Date";
            this.Label_UpdateEndDate.Click += new System.EventHandler(this.Label_UpdateEndDate_Click);
            // 
            // ChartDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 849);
            this.Controls.Add(this.Label_UpdateEndDate);
            this.Controls.Add(this.Label_UpdateStartDate);
            this.Controls.Add(this.DropDownMenu_SelectPattern);
            this.Controls.Add(this.Button_ShowPattern);
            this.Controls.Add(this.Button_UpdateStockData);
            this.Controls.Add(this.Chart_StockData);
            this.Controls.Add(this.DateTimePicker_EndDate);
            this.Controls.Add(this.DateTimePicker_StartDate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChartDisplayForm";
            this.Text = "Chart Data";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_StockData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandleStickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker DateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker_EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn openDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_StockData;
        private System.Windows.Forms.Button Button_UpdateStockData;
        private System.Windows.Forms.BindingSource aCandleStickBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button Button_ShowPattern;
        private System.Windows.Forms.ComboBox DropDownMenu_SelectPattern;
        private System.Windows.Forms.Label Label_UpdateStartDate;
        private System.Windows.Forms.Label Label_UpdateEndDate;
    }
}

