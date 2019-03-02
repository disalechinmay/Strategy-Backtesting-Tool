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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openDataSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exitButton = new System.Windows.Forms.Button();
            this.manageDataSourceButton = new System.Windows.Forms.Button();
            this.bactestButton = new System.Windows.Forms.Button();
            this.createStrategyButton = new System.Windows.Forms.Button();
            this.startBacktestButton = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadStrategyButton = new System.Windows.Forms.Button();
            this.saveStrategyButton = new System.Windows.Forms.Button();
            this.compileStrategyButton = new System.Windows.Forms.Button();
            this.codeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataPointsLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addIndicatorButton = new System.Windows.Forms.Button();
            this.saveStrategyDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadStrategyDialog = new System.Windows.Forms.OpenFileDialog();
            this.SLTextBox = new System.Windows.Forms.TextBox();
            this.TPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer1.Panel1.Controls.Add(this.exitButton);
            this.splitContainer1.Panel1.Controls.Add(this.manageDataSourceButton);
            this.splitContainer1.Panel1.Controls.Add(this.bactestButton);
            this.splitContainer1.Panel1.Controls.Add(this.createStrategyButton);
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.TPTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SLTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.startBacktestButton);
            this.splitContainer1.Panel2.Controls.Add(this.chart2);
            this.splitContainer1.Panel2.Controls.Add(this.loadStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.compileStrategyButton);
            this.splitContainer1.Panel2.Controls.Add(this.codeRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.dataPointsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.Controls.Add(this.addIndicatorButton);
            this.splitContainer1.Size = new System.Drawing.Size(757, 492);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(19, 303);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // manageDataSourceButton
            // 
            this.manageDataSourceButton.Location = new System.Drawing.Point(19, 52);
            this.manageDataSourceButton.Name = "manageDataSourceButton";
            this.manageDataSourceButton.Size = new System.Drawing.Size(133, 23);
            this.manageDataSourceButton.TabIndex = 0;
            this.manageDataSourceButton.Text = "Manage Data Source";
            this.manageDataSourceButton.UseVisualStyleBackColor = true;
            this.manageDataSourceButton.Click += new System.EventHandler(this.manageDataSourceButton_Click);
            // 
            // bactestButton
            // 
            this.bactestButton.Location = new System.Drawing.Point(19, 135);
            this.bactestButton.Name = "bactestButton";
            this.bactestButton.Size = new System.Drawing.Size(133, 23);
            this.bactestButton.TabIndex = 2;
            this.bactestButton.Text = "Backtest";
            this.bactestButton.UseVisualStyleBackColor = true;
            this.bactestButton.Click += new System.EventHandler(this.bactestButton_Click);
            // 
            // createStrategyButton
            // 
            this.createStrategyButton.Location = new System.Drawing.Point(19, 95);
            this.createStrategyButton.Name = "createStrategyButton";
            this.createStrategyButton.Size = new System.Drawing.Size(133, 23);
            this.createStrategyButton.TabIndex = 1;
            this.createStrategyButton.Text = "Create Strategy";
            this.createStrategyButton.UseVisualStyleBackColor = true;
            this.createStrategyButton.Click += new System.EventHandler(this.createStrategyButton_Click);
            // 
            // startBacktestButton
            // 
            this.startBacktestButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBacktestButton.Location = new System.Drawing.Point(368, 35);
            this.startBacktestButton.Name = "startBacktestButton";
            this.startBacktestButton.Size = new System.Drawing.Size(121, 23);
            this.startBacktestButton.TabIndex = 8;
            this.startBacktestButton.Text = "Start Backtest";
            this.startBacktestButton.UseVisualStyleBackColor = true;
            this.startBacktestButton.Click += new System.EventHandler(this.startBacktestButton_Click);
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart2.Location = new System.Drawing.Point(0, -375);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(501, 430);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            // 
            // loadStrategyButton
            // 
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
            this.compileStrategyButton.Location = new System.Drawing.Point(409, 33);
            this.compileStrategyButton.Name = "compileStrategyButton";
            this.compileStrategyButton.Size = new System.Drawing.Size(80, 23);
            this.compileStrategyButton.TabIndex = 4;
            this.compileStrategyButton.Text = "Compile";
            this.compileStrategyButton.UseVisualStyleBackColor = true;
            this.compileStrategyButton.Visible = false;
            this.compileStrategyButton.Click += new System.EventHandler(this.compileStrategyButton_Click);
            // 
            // codeRichTextBox
            // 
            this.codeRichTextBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeRichTextBox.Location = new System.Drawing.Point(3, 62);
            this.codeRichTextBox.Name = "codeRichTextBox";
            this.codeRichTextBox.Size = new System.Drawing.Size(495, 409);
            this.codeRichTextBox.TabIndex = 3;
            this.codeRichTextBox.Text = "";
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
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 55);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.YValuesPerPoint = 4;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(501, 437);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
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
            // saveStrategyDialog
            // 
            this.saveStrategyDialog.Filter = "Strategy Files|*.st";
            // 
            // loadStrategyDialog
            // 
            this.loadStrategyDialog.FileName = "openFileDialog1";
            this.loadStrategyDialog.Filter = "Strategy Files|*.st";
            // 
            // SLTextBox
            // 
            this.SLTextBox.Location = new System.Drawing.Point(280, 38);
            this.SLTextBox.Name = "SLTextBox";
            this.SLTextBox.Size = new System.Drawing.Size(69, 20);
            this.SLTextBox.TabIndex = 9;
            // 
            // TPTextBox
            // 
            this.TPTextBox.Location = new System.Drawing.Point(97, 38);
            this.TPTextBox.Name = "TPTextBox";
            this.TPTextBox.Size = new System.Drawing.Size(69, 20);
            this.TPTextBox.TabIndex = 10;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "SL Percentage : ";
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
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.RichTextBox codeRichTextBox;
        private System.Windows.Forms.Button compileStrategyButton;
        private System.Windows.Forms.Button loadStrategyButton;
        private System.Windows.Forms.Button saveStrategyButton;
        private System.Windows.Forms.SaveFileDialog saveStrategyDialog;
        private System.Windows.Forms.OpenFileDialog loadStrategyDialog;
        private System.Windows.Forms.Button startBacktestButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPTextBox;
        private System.Windows.Forms.TextBox SLTextBox;
    }
}

