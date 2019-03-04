namespace Backtester
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openDataSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exitButton = new System.Windows.Forms.Button();
            this.manageDataSourceButton = new System.Windows.Forms.Button();
            this.bactestButton = new System.Windows.Forms.Button();
            this.createStrategyButton = new System.Windows.Forms.Button();
            this.saveDataSource = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.maxDrawDownLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPTextBox = new System.Windows.Forms.TextBox();
            this.SLTextBox = new System.Windows.Forms.TextBox();
            this.startBacktestButton = new System.Windows.Forms.Button();
            this.loadStrategyButton = new System.Windows.Forms.Button();
            this.saveStrategyButton = new System.Windows.Forms.Button();
            this.compileStrategyButton = new System.Windows.Forms.Button();
            this.dataPointsLabel = new System.Windows.Forms.Label();
            this.addIndicatorButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveStrategyDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadStrategyDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlLabel = new System.Windows.Forms.Label();
            this.scintillaPanel = new System.Windows.Forms.Panel();
            this.newDataSourceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDataSourceDialog
            // 
            this.openDataSourceDialog.Filter = "CSV (*.csv) |*.csv";
            this.openDataSourceDialog.Title = "Open Data Source";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.exitButton);
            this.splitContainer1.Panel1.Controls.Add(this.manageDataSourceButton);
            this.splitContainer1.Panel1.Controls.Add(this.bactestButton);
            this.splitContainer1.Panel1.Controls.Add(this.createStrategyButton);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newDataSourceButton);
            this.splitContainer1.Panel2.Controls.Add(this.scintillaPanel);
            this.splitContainer1.Panel2.Controls.Add(this.saveDataSource);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.TPTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SLTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.startBacktestButton);
            this.splitContainer1.Panel2.Controls.Add(this.loadStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.compileStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.dataPointsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addIndicatorButton);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(757, 492);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(0, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 33);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // manageDataSourceButton
            // 
            this.manageDataSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageDataSourceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageDataSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.manageDataSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageDataSourceButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDataSourceButton.ForeColor = System.Drawing.Color.White;
            this.manageDataSourceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageDataSourceButton.Location = new System.Drawing.Point(0, 52);
            this.manageDataSourceButton.Name = "manageDataSourceButton";
            this.manageDataSourceButton.Size = new System.Drawing.Size(250, 36);
            this.manageDataSourceButton.TabIndex = 0;
            this.manageDataSourceButton.Text = "Manage Data Source";
            this.manageDataSourceButton.UseVisualStyleBackColor = true;
            this.manageDataSourceButton.Click += new System.EventHandler(this.manageDataSourceButton_Click);
            // 
            // bactestButton
            // 
            this.bactestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bactestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bactestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.bactestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bactestButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactestButton.ForeColor = System.Drawing.Color.White;
            this.bactestButton.Location = new System.Drawing.Point(0, 135);
            this.bactestButton.Name = "bactestButton";
            this.bactestButton.Size = new System.Drawing.Size(249, 35);
            this.bactestButton.TabIndex = 2;
            this.bactestButton.Text = "Backtest";
            this.bactestButton.UseVisualStyleBackColor = true;
            this.bactestButton.Click += new System.EventHandler(this.bactestButton_Click);
            // 
            // createStrategyButton
            // 
            this.createStrategyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createStrategyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createStrategyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.createStrategyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createStrategyButton.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStrategyButton.ForeColor = System.Drawing.Color.White;
            this.createStrategyButton.Location = new System.Drawing.Point(0, 94);
            this.createStrategyButton.Name = "createStrategyButton";
            this.createStrategyButton.Size = new System.Drawing.Size(249, 35);
            this.createStrategyButton.TabIndex = 1;
            this.createStrategyButton.Text = "Create Strategy";
            this.createStrategyButton.UseVisualStyleBackColor = true;
            this.createStrategyButton.Click += new System.EventHandler(this.createStrategyButton_Click);
            // 
            // saveDataSource
            // 
            this.saveDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveDataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDataSource.ForeColor = System.Drawing.Color.Transparent;
            this.saveDataSource.Image = ((System.Drawing.Image)(resources.GetObject("saveDataSource.Image")));
            this.saveDataSource.Location = new System.Drawing.Point(464, 4);
            this.saveDataSource.Name = "saveDataSource";
            this.saveDataSource.Size = new System.Drawing.Size(34, 23);
            this.saveDataSource.TabIndex = 16;
            this.saveDataSource.UseVisualStyleBackColor = true;
            this.saveDataSource.Click += new System.EventHandler(this.saveDataSource_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.chart2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 409);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // chart2
            // 
            chartArea11.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea11);
            this.tableLayoutPanel1.SetColumnSpan(this.chart2, 3);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series11.ChartArea = "ChartArea1";
            series11.Name = "Series1";
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(495, 375);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea12.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea12);
            legend8.Name = "Legend1";
            this.chart3.Legends.Add(legend8);
            this.chart3.Location = new System.Drawing.Point(3, 384);
            this.chart3.Name = "chart3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(160, 158);
            this.chart3.TabIndex = 15;
            this.chart3.Text = "chart3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.maxDrawDownLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(169, 384);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2807F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7193F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(160, 248);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max Drawdown";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxDrawDownLabel
            // 
            this.maxDrawDownLabel.AutoSize = true;
            this.maxDrawDownLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxDrawDownLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDrawDownLabel.Location = new System.Drawing.Point(3, 30);
            this.maxDrawDownLabel.Name = "maxDrawDownLabel";
            this.maxDrawDownLabel.Size = new System.Drawing.Size(154, 218);
            this.maxDrawDownLabel.TabIndex = 1;
            this.maxDrawDownLabel.Text = "maxDrawdown";
            this.maxDrawDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SL Percentage : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "TP Percentage : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TPTextBox
            // 
            this.TPTextBox.Location = new System.Drawing.Point(97, 38);
            this.TPTextBox.Name = "TPTextBox";
            this.TPTextBox.Size = new System.Drawing.Size(69, 20);
            this.TPTextBox.TabIndex = 10;
            this.TPTextBox.Leave += new System.EventHandler(this.TPTextBox_Leave);
            // 
            // SLTextBox
            // 
            this.SLTextBox.Location = new System.Drawing.Point(280, 38);
            this.SLTextBox.Name = "SLTextBox";
            this.SLTextBox.Size = new System.Drawing.Size(69, 20);
            this.SLTextBox.TabIndex = 9;
            this.SLTextBox.Leave += new System.EventHandler(this.SLTextBox_Leave);
            // 
            // startBacktestButton
            // 
            this.startBacktestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBacktestButton.Location = new System.Drawing.Point(368, 35);
            this.startBacktestButton.Name = "startBacktestButton";
            this.startBacktestButton.Size = new System.Drawing.Size(121, 26);
            this.startBacktestButton.TabIndex = 8;
            this.startBacktestButton.Text = "Start Backtest";
            this.startBacktestButton.UseVisualStyleBackColor = true;
            this.startBacktestButton.Click += new System.EventHandler(this.startBacktestButton_Click);
            this.startBacktestButton.Leave += new System.EventHandler(this.startBacktestButton_Leave);
            // 
            // loadStrategyButton
            // 
            this.loadStrategyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadStrategyButton.Location = new System.Drawing.Point(309, 6);
            this.loadStrategyButton.Name = "loadStrategyButton";
            this.loadStrategyButton.Size = new System.Drawing.Size(87, 23);
            this.loadStrategyButton.TabIndex = 6;
            this.loadStrategyButton.Text = "Load Strategy";
            this.loadStrategyButton.UseVisualStyleBackColor = true;
            this.loadStrategyButton.Click += new System.EventHandler(this.loadStrategyButton_Click);
            // 
            // saveStrategyButton
            // 
            this.saveStrategyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStrategyButton.Location = new System.Drawing.Point(402, 6);
            this.saveStrategyButton.Name = "saveStrategyButton";
            this.saveStrategyButton.Size = new System.Drawing.Size(87, 23);
            this.saveStrategyButton.TabIndex = 5;
            this.saveStrategyButton.Text = "Save Strategy";
            this.saveStrategyButton.UseVisualStyleBackColor = true;
            this.saveStrategyButton.Click += new System.EventHandler(this.saveStrategyButton_Click);
            // 
            // compileStrategyButton
            // 
            this.compileStrategyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compileStrategyButton.Location = new System.Drawing.Point(409, 33);
            this.compileStrategyButton.Name = "compileStrategyButton";
            this.compileStrategyButton.Size = new System.Drawing.Size(80, 23);
            this.compileStrategyButton.TabIndex = 4;
            this.compileStrategyButton.Text = "Compile";
            this.compileStrategyButton.UseVisualStyleBackColor = true;
            this.compileStrategyButton.Visible = false;
            this.compileStrategyButton.Click += new System.EventHandler(this.compileStrategyButton_Click);
            // 
            // dataPointsLabel
            // 
            this.dataPointsLabel.AutoSize = true;
            this.dataPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPointsLabel.Location = new System.Drawing.Point(3, 9);
            this.dataPointsLabel.Name = "dataPointsLabel";
            this.dataPointsLabel.Size = new System.Drawing.Size(106, 16);
            this.dataPointsLabel.TabIndex = 1;
            this.dataPointsLabel.Text = "dataPointsLabel";
            // 
            // addIndicatorButton
            // 
            this.addIndicatorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addIndicatorButton.Location = new System.Drawing.Point(340, 26);
            this.addIndicatorButton.Name = "addIndicatorButton";
            this.addIndicatorButton.Size = new System.Drawing.Size(149, 23);
            this.addIndicatorButton.TabIndex = 2;
            this.addIndicatorButton.Text = "Add technical indicators";
            this.addIndicatorButton.UseVisualStyleBackColor = true;
            this.addIndicatorButton.Click += new System.EventHandler(this.addIndicatorButton_Click);
            // 
            // chart1
            // 
            chartArea10.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea10);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 55);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.YValuesPerPoint = 4;
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(501, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // saveStrategyDialog
            // 
            this.saveStrategyDialog.Filter = "Strategy Files|*.st";
            // 
            // loadStrategyDialog
            // 
            this.loadStrategyDialog.FileName = "openFileDialog1";
            this.loadStrategyDialog.Filter = "Strategy Files|*.st";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pnlLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(335, 384);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48987F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.51013F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(163, 248);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Profit / Loss";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLabel
            // 
            this.pnlLabel.AutoSize = true;
            this.pnlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLabel.Location = new System.Drawing.Point(3, 26);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(157, 222);
            this.pnlLabel.TabIndex = 1;
            this.pnlLabel.Text = "PnL";
            this.pnlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scintillaPanel
            // 
            this.scintillaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintillaPanel.Location = new System.Drawing.Point(0, 57);
            this.scintillaPanel.Name = "scintillaPanel";
            this.scintillaPanel.Size = new System.Drawing.Size(489, 394);
            this.scintillaPanel.TabIndex = 17;
            // 
            // newDataSourceButton
            // 
            this.newDataSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newDataSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newDataSourceButton.ForeColor = System.Drawing.Color.Transparent;
            this.newDataSourceButton.Image = ((System.Drawing.Image)(resources.GetObject("newDataSourceButton.Image")));
            this.newDataSourceButton.Location = new System.Drawing.Point(426, 4);
            this.newDataSourceButton.Name = "newDataSourceButton";
            this.newDataSourceButton.Size = new System.Drawing.Size(32, 23);
            this.newDataSourceButton.TabIndex = 18;
            this.newDataSourceButton.UseVisualStyleBackColor = true;
            this.newDataSourceButton.Click += new System.EventHandler(this.newDataSourceButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 492);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Backtester";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openDataSourceDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button manageDataSourceButton;
        private System.Windows.Forms.Button bactestButton;
        private System.Windows.Forms.Button createStrategyButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label dataPointsLabel;
        private System.Windows.Forms.Button addIndicatorButton;
        private System.Windows.Forms.Button compileStrategyButton;
        private System.Windows.Forms.Button loadStrategyButton;
        private System.Windows.Forms.Button saveStrategyButton;
        private System.Windows.Forms.SaveFileDialog saveStrategyDialog;
        private System.Windows.Forms.OpenFileDialog loadStrategyDialog;
        private System.Windows.Forms.Button startBacktestButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPTextBox;
        private System.Windows.Forms.TextBox SLTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label maxDrawDownLabel;
        private System.Windows.Forms.Button saveDataSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pnlLabel;
        private System.Windows.Forms.Panel scintillaPanel;
        private System.Windows.Forms.Button newDataSourceButton;
    }
}

