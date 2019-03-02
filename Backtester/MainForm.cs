using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Backtester
{
    public partial class MainForm : Form
    {
        public string filePath;
        public List<float[]> dataSource;
        public List<string> dataSourceColumns;
        public int noOfColumns;
        public MethodInfo methodInfo;

        public MainForm()
        {
            InitializeComponent();

            dataSource = new List<float[]>();
            dataSourceColumns = new List<string>();

            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterDistance = 170;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;

            dataPointsLabel.MaximumSize = new Size(splitContainer1.Panel2.Width - addIndicatorButton.Width - 50, splitContainer1.Panel2.Height - chart1.Height);

            // Visibilities
            hideManageDataSourcePage();
            hideCreateStrategyPage();
            hideBacktestPage();
        }

        // Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Manage data source button
        private void manageDataSourceButton_Click(object sender, EventArgs e)
        {
            showManageDataSourcePage();

            if(openDataSourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Open the specified .csv file and load into dataSource and dataSourceColumns
                filePath = openDataSourceDialog.FileName;

                StreamReader reader = new StreamReader(filePath);
                dataSource = new List<float[]>();
                dataSourceColumns = new List<string>();

                // Reading from the selected .csv file
                while (!reader.EndOfStream)
                {
                    try
                    {
                        string line = reader.ReadLine();

                        string[] splitLine = line.Split(',');

                        if (dataSourceColumns.Count == 0)
                        {
                            foreach (string val in splitLine)
                                dataSourceColumns.Add(val);                            
                        }
                        else
                        {
                            float[] currentTuple = new float[splitLine.Length];
                            int currentIndex = 0;

                            foreach (string val in splitLine)
                                currentTuple[currentIndex++] = float.Parse(val);

                            dataSource.Add(currentTuple);
                        }
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show("Invalid csv file format!" + exception.Message);
                    }
                }

                noOfColumns = dataSource[0].Length;

                // Creating series for input to charts
                float[] close = new float[dataSource.Count];
                int index = 0;
                foreach (float[] set in dataSource)
                    close[index++] = set[3];

                Series data = new Series("Stock price");
                data.Points.DataBindY(close);

                chart1.Series.RemoveAt(0);
                chart1.Series.Add(data);

                // Re-scaling the chart to crop right to the data
                chart1.ChartAreas[0].AxisY.Maximum = Math.Ceiling(close.Max());
                chart1.ChartAreas[0].AxisY.Minimum = Math.Floor(close.Min());

                dataPointsLabel.Text = "Data points present in current data : ";
                foreach (string val in dataSourceColumns)
                    dataPointsLabel.Text += val + ", ";
                
                dataPointsLabel.Visible = true;
                chart1.Visible = true;
                addIndicatorButton.Visible = true;
            }

        }

        // Event handler : Reacts to form resize
        private void Form1_Resize(object sender, EventArgs e)
        {
            dataPointsLabel.MaximumSize = new Size(splitContainer1.Panel2.Width - addIndicatorButton.Width - 50, splitContainer1.Panel2.Height - chart1.Height);
        }

        private void addIndicatorButton_Click(object sender, EventArgs e)
        {
            AddIndicatorsForm form = new AddIndicatorsForm(dataSource, dataSourceColumns);
            
            if(form.ShowDialog() == DialogResult.OK)
            {
                this.dataSource = form.dataSource;
                this.dataSourceColumns = form.dataSourceColumns;

                dataPointsLabel.Text = "Data points present in current data : ";
                foreach (string val in dataSourceColumns)
                    dataPointsLabel.Text += val + ", ";                
            }
            
        }

        private void createStrategyButton_Click(object sender, EventArgs e)
        {
            showCreateStrategyPage();
        }

        private void compileStrategyButton_Click(object sender, EventArgs e)
        {
            try
            {
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                CompilerParameters compilerParameters = new CompilerParameters
                {
                    GenerateExecutable = false,
                    GenerateInMemory = true
                };

                compilerParameters.ReferencedAssemblies.Add("system.dll");

                string prepend = "using System;\nusing System.Collections.Generic;\nnamespace Lab{public sealed class Code{public static string Strategy(int pointer, List<float[]> dataSource, List<string> dataSourceColumns){\n";
                string append = "\n}}}";
                string sourceCode = prepend + codeRichTextBox.Text + append;

                CompilerResults compilerResults = codeProvider.CompileAssemblyFromSource(compilerParameters, sourceCode);

                Assembly assembly = compilerResults.CompiledAssembly;
                Type type = assembly.GetType("Lab.Code");
                methodInfo = type.GetMethod("Strategy");

                object[] parameters = new object[] {5, dataSource, dataSourceColumns};

                string result = (string)methodInfo.Invoke(this, parameters);
                MessageBox.Show("Compilation successfull.", "Compilation successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error : Cannot compile entered code!\nDetails : " + exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void saveStrategyButton_Click(object sender, EventArgs e)
        {
            if (saveStrategyDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveStrategyDialog.FileName, codeRichTextBox.Text);
            }
        }

        private void loadStrategyButton_Click(object sender, EventArgs e)
        {
            if (loadStrategyDialog.ShowDialog() == DialogResult.OK)
            {
                codeRichTextBox.Text = File.ReadAllText(loadStrategyDialog.FileName);
            }
        }

        private void startBacktestButton_Click(object sender, EventArgs e)
        {
            if(dataSource == null || dataSource.Count == 0 || dataSourceColumns == null || dataSourceColumns.Count == 0)
            {
                MessageBox.Show("Data source is not set! Please set the data source.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(methodInfo == null)
            {
                MessageBox.Show("Strategy is not set! Please set the strategy.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Start backtesting
                List<float> PnL = new List<float>();
                List<float> capitalCurve = new List<float>();

                // inTrade : States if any trade is open or not
                // tradeDirection : States direction of previous trade, if open
                // tradeInitPrice : States price at which previous trade was opened
                // tradedQty : Specifies how much quantity was bought; 100% capital is pulled as default
                bool inTrade = false;
                string tradeDirection = "LONG";
                float tradeInitPrice = 0.00f;
                int tradedQty = 0;
                float initialCapital = 100000.00f;
                float takeProfit = float.Parse(TPTextBox.Text);
                float stopLoss = float.Parse(SLTextBox.Text);

                for(int i = 100; i < dataSource.Count; i++)
                {
                    object[] parameters = new object[] { i, dataSource, dataSourceColumns };
                    string result;

                    // No trade is open, look for a new trade
                    if (!inTrade && (result = (string)methodInfo.Invoke(this, parameters)) != "NEUTRAL")
                    {
                        // Open a new trade
                        inTrade = true;

                        if (result == "LONG")
                            tradeDirection = "LONG";
                        else
                            tradeDirection = "SHORT";

                        tradeInitPrice = dataSource[i][dataSourceColumns.IndexOf("Close")];
                        
                        tradedQty = (int)Math.Floor( double.Parse(initialCapital.ToString()) / double.Parse(dataSource[i][dataSourceColumns.IndexOf("Close")].ToString()) );
                    }


                    // If a trade is already open, check if stop loss or take profit was hit
                    // Check TP or SL was hit or not in a LONG trade                   
                    if(inTrade && tradeDirection == "LONG" && (dataSource[i][dataSourceColumns.IndexOf("Close")] >= (tradeInitPrice + (tradeInitPrice * (takeProfit / 100.00)))))
                    {
                        inTrade = false;

                        float profit = (float.Parse(tradedQty.ToString()) * (tradeInitPrice + (tradeInitPrice * (takeProfit / 100.00f)))) - (float.Parse(tradedQty.ToString()) * tradeInitPrice);

                        initialCapital = initialCapital + profit;
                        capitalCurve.Add(initialCapital);
                        PnL.Add(profit);
                    }
                    else if(inTrade && tradeDirection == "LONG" && (dataSource[i][dataSourceColumns.IndexOf("Close")] <= (tradeInitPrice - (tradeInitPrice * (stopLoss / 100.00)))))
                    {
                        inTrade = false;

                        float loss = ((float.Parse(tradedQty.ToString()) * (tradeInitPrice - (tradeInitPrice * (stopLoss / 100.00f)))) - ((float.Parse(tradedQty.ToString()) * tradeInitPrice)));

                        initialCapital = initialCapital + loss;
                        capitalCurve.Add(initialCapital);
                        PnL.Add(loss);
                    }

                    // Check TP or SL was hit or not in a SHORT trade
                    if (inTrade && tradeDirection == "SHORT" && (dataSource[i][dataSourceColumns.IndexOf("Close")] <= (tradeInitPrice - (tradeInitPrice * (takeProfit / 100.00)))))
                    {
                        inTrade = false;

                        float profit = ((float.Parse(tradedQty.ToString()) * tradeInitPrice) - ((float.Parse(tradedQty.ToString()) * (tradeInitPrice - (tradeInitPrice * (takeProfit / 100.00f))))));

                        initialCapital = initialCapital + profit;
                        capitalCurve.Add(initialCapital);
                        PnL.Add(profit);
                    }
                    else if (inTrade && tradeDirection == "SHORT" && (dataSource[i][dataSourceColumns.IndexOf("Close")] >= (tradeInitPrice + (tradeInitPrice * (stopLoss / 100.00f)))))
                    {
                        inTrade = false;

                        float loss = ((float.Parse(tradedQty.ToString()) * tradeInitPrice) - ((float.Parse(tradedQty.ToString()) * (tradeInitPrice + (tradeInitPrice * (stopLoss / 100.00f))))));

                        initialCapital = initialCapital + loss;
                        capitalCurve.Add(initialCapital);
                        PnL.Add(loss);
                    }
                }

                // Calculating total number of trades taken, along with their distribution
                int correctTrades = 0, incorrectTrades = 0, totalTrades = 0;
                foreach(float val in PnL)
                {
                    totalTrades++;
                    if (val > 0.0f)
                        correctTrades++;
                    else
                        incorrectTrades++;
                }

                Series series = new Series("Capital curve");
                series.Points.DataBindY(capitalCurve);

                chart2.Series.RemoveAt(0);
                chart2.Series.Add(series);
                chart2.Series[0].ChartType = SeriesChartType.Area;

                // Re-scaling the chart to crop right to the data
                chart2.ChartAreas[0].AxisY.Maximum = Math.Ceiling(capitalCurve.Max());
                chart2.ChartAreas[0].AxisY.Minimum = Math.Floor(capitalCurve.Min());

                // Calculating drawdown
                float highest = capitalCurve[0];
                List<float> drawDowns = new List<float>();

                foreach(float curr in capitalCurve)
                {
                    if (curr >= highest)
                        highest = curr;
                    else if (curr < highest)
                        drawDowns.Add((highest - curr) / highest);
                }

                float maxDrawdown = drawDowns[0];

                foreach (float currDrawdown in drawDowns)
                    if (currDrawdown > maxDrawdown)
                        maxDrawdown = currDrawdown;

            }
        }

        private void bactestButton_Click(object sender, EventArgs e)
        {
            showBacktestPage();
        }


        // Visibility Handlers
        public void showManageDataSourcePage()
        {
            hideCreateStrategyPage();
            hideBacktestPage();

            dataPointsLabel.Visible = true;
            addIndicatorButton.Visible = true;
            chart1.Visible = true;
        }

        public void showCreateStrategyPage()
        {
            hideManageDataSourcePage();
            hideBacktestPage();

            compileStrategyButton.Visible = true;
            codeRichTextBox.Visible = true;
            loadStrategyButton.Visible = true;
            saveStrategyButton.Visible = true;
        }

        public void showBacktestPage()
        {
            hideManageDataSourcePage();
            hideCreateStrategyPage();

            chart2.Visible = true;
            startBacktestButton.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            TPTextBox.Visible = true;
            SLTextBox.Visible = true;
        }

        public void hideManageDataSourcePage()
        {
            dataPointsLabel.Visible = false;
            addIndicatorButton.Visible = false;
            chart1.Visible = false;
        }

        public void hideCreateStrategyPage()
        {
            compileStrategyButton.Visible = false;
            codeRichTextBox.Visible = false;
            saveStrategyButton.Visible = false;
            loadStrategyButton.Visible = false;
        }

        public void hideBacktestPage()
        {
            chart2.Visible = false;
            startBacktestButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            TPTextBox.Visible = false;
            SLTextBox.Visible = false;
        }
    }
}
