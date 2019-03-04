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
using System.Text;
using CsvHelper;
using ScintillaNET;

namespace Backtester
{
    public partial class MainForm : Form
    {
        public string filePath;
        public List<float[]> dataSource;
        public List<string> dataSourceColumns;
        public int noOfColumns;
        public MethodInfo methodInfo;
        ScintillaNET.Scintilla TextArea;

        public MainForm()
        {
            InitializeComponent();

            dataSource = new List<float[]>();
            dataSourceColumns = new List<string>();

            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterDistance = 170;
            splitContainer1.IsSplitterFixed = true;

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;

            dataPointsLabel.MaximumSize = new Size(splitContainer1.Panel2.Width - addIndicatorButton.Width - 50, splitContainer1.Panel2.Height - chart1.Height);
            
            chart3.Legends.RemoveAt(0);

            // Scintilla
            // CREATE CONTROL
            TextArea = new ScintillaNET.Scintilla();
            scintillaPanel.Controls.Add(TextArea);

            // BASIC CONFIG
            TextArea.Dock = System.Windows.Forms.DockStyle.Fill;
            TextArea.TextChanged += (this.OnTextChanged);

            // INITIAL VIEW CONFIG
            TextArea.WrapMode = WrapMode.None;
            TextArea.IndentationGuides = IndentView.LookBoth;

            // STYLING
            InitColors();
            InitSyntaxColoring();
            // NUMBER MARGIN
            InitNumberMargin();
            // BOOKMARK MARGIN
            InitBookmarkMargin();

            // CODE FOLDING MARGIN
            InitCodeFolding();

            // -------------------

            // Visibilities
            hideManageDataSourcePage();
            hideCreateStrategyPage();
            hideBacktestPage();
        }

        // Scintilla inits
        private void InitColors()
        {
            TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
        }

        public static Color IntToColor(int rgb)
        {
            return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
        }

        private void InitSyntaxColoring()
        {

            // Configure the default style
            TextArea.StyleResetDefault();
            TextArea.Styles[Style.Default].Font = "Consolas";
            TextArea.Styles[Style.Default].Size = 10;
            TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
            TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
            TextArea.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
            TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
            TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
            TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
            TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
            TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
            TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
            TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
            TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
            TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
            TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
            TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
            TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
            TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
            TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

            TextArea.Lexer = Lexer.Cpp;

            TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
            TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

        }

        private void OnTextChanged(object sender, EventArgs e)
        {

        }

        private const int BACK_COLOR = 0x2A211C;
        private const int FORE_COLOR = 0xB7B7B7;
        private const int NUMBER_MARGIN = 1;
        private const int BOOKMARK_MARGIN = 2;
        private const int BOOKMARK_MARKER = 2;
        private const int FOLDING_MARGIN = 3;
        private const bool CODEFOLDING_CIRCULAR = true;

        private void InitNumberMargin()
        {

            TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
            TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
            TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

            var nums = TextArea.Margins[NUMBER_MARGIN];
            nums.Width = 30;
            nums.Type = MarginType.Number;
            nums.Sensitive = true;
            nums.Mask = 0;

            TextArea.MarginClick += TextArea_MarginClick;
        }

        private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }

        private void InitBookmarkMargin()
        {

            //TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

            var margin = TextArea.Margins[BOOKMARK_MARGIN];
            margin.Width = 20;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = (1 << BOOKMARK_MARKER);
            //margin.Cursor = MarginCursor.Arrow;

            var marker = TextArea.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Circle;
            marker.SetBackColor(IntToColor(0xFF003B));
            marker.SetForeColor(IntToColor(0x000000));
            marker.SetAlpha(100);

        }

        private void InitCodeFolding()
        {

            TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
            TextArea.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

            // Enable code folding
            TextArea.SetProperty("fold", "1");
            TextArea.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            TextArea.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
            TextArea.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
            TextArea.Margins[FOLDING_MARGIN].Sensitive = true;
            TextArea.Margins[FOLDING_MARGIN].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                TextArea.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
                TextArea.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
            }

            // Configure folding markers with respective symbols
            TextArea.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
            TextArea.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
            TextArea.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
            TextArea.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            TextArea.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
            TextArea.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            TextArea.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            TextArea.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

        }
        //-------------------------------------

        // Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Manage data source button
        private void manageDataSourceButton_Click(object sender, EventArgs e)
        {
            showManageDataSourcePage();

            if (filePath == null)
            {
                if (openDataSourceDialog.ShowDialog() == DialogResult.OK)
                {
                    // Open the specified .csv file and load into dataSource and dataSourceColumns
                    filePath = openDataSourceDialog.FileName;

                    dataSource = new List<float[]>();
                    dataSourceColumns = new List<string>();

                    // Reading from the selected .csv file
                    TextReader tr = File.OpenText(filePath);
                    CsvParser parser = new CsvParser(tr);
                    while(true)
                    {
                        string[] row = parser.Read();
                        if (row == null)
                            break;

                        if (dataSourceColumns.Count == 0)
                        {
                            foreach (string val in row)
                                dataSourceColumns.Add(val);
                        }
                        else
                        {
                            float[] temp = new float[dataSourceColumns.Count];
                            int index1 = 0;

                            foreach (string val in row)
                            {
                                if (val.IndexOf(",") >= 0)
                                    temp[index1++] = float.Parse(val.Replace(',', ' '));
                                else
                                    temp[index1++] = float.Parse(val);
                            }

                            dataSource.Add(temp);
                        }

                    }

                    noOfColumns = dataSource[0].Length;
                    //MessageBox.Show(noOfColumns.ToString());

                    // Creating series for input to charts
                    float[] close = new float[dataSource.Count];
                    int index = 0;
                    foreach (float[] set in dataSource)
                        close[index++] = set[dataSourceColumns.IndexOf("Close")];

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
        }

        // Event handler : Reacts to form resize
        private void Form1_Resize(object sender, EventArgs e)
        {
            dataPointsLabel.MaximumSize = new Size(splitContainer1.Panel2.Width - addIndicatorButton.Width - 50, splitContainer1.Panel2.Height - chart1.Height);
        }

        private void addIndicatorButton_Click(object sender, EventArgs e)
        {
            AddIndicatorsForm form = new AddIndicatorsForm(dataSource, dataSourceColumns);

            if (form.ShowDialog() == DialogResult.OK)
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
                string sourceCode = prepend + TextArea.Text + append;

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
                File.WriteAllText(saveStrategyDialog.FileName, TextArea.Text);
            }
        }

        private void loadStrategyButton_Click(object sender, EventArgs e)
        {
            if (loadStrategyDialog.ShowDialog() == DialogResult.OK)
            {
                TextArea.Text = File.ReadAllText(loadStrategyDialog.FileName);
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
                float initialCapitalCopy = initialCapital;

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

                chart3.Series.RemoveAt(0);
                Series pie = new Series("Pie chart");
                pie.Points.AddXY("Correct trades : " + correctTrades.ToString(), correctTrades);
                pie.Points.AddXY("Incorrect trades : " + incorrectTrades.ToString(), incorrectTrades);

                chart3.Series.Add(pie);
                chart3.Series[0].ChartType = SeriesChartType.Pie;

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

                maxDrawDownLabel.Text = (maxDrawdown*100.0f).ToString().Substring(0, 5) + " %";

                float overallGain = ((initialCapital - initialCapitalCopy) / initialCapitalCopy) * 100.00f;
                if(overallGain < 0.00f)
                {
                    pnlLabel.ForeColor = Color.Red;
                    pnlLabel.Text = overallGain.ToString().Substring(0, 5) + "%";
                }
                else
                {
                    pnlLabel.ForeColor = Color.Green;
                    pnlLabel.Text = overallGain.ToString().Substring(0, 5) + "%";
                }
            }
        }

        private void bactestButton_Click(object sender, EventArgs e)
        {
            showBacktestPage();
        }

        private void newDataSourceButton_Click(object sender, EventArgs e)
        {
            if (openDataSourceDialog.ShowDialog() == DialogResult.OK)
            {
                // Open the specified .csv file and load into dataSource and dataSourceColumns
                filePath = openDataSourceDialog.FileName;

                dataSource = new List<float[]>();
                dataSourceColumns = new List<string>();

                // Reading from the selected .csv file
                TextReader tr = File.OpenText(filePath);
                CsvParser parser = new CsvParser(tr);
                while (true)
                {
                    string[] row = parser.Read();
                    if (row == null)
                        break;

                    if (dataSourceColumns.Count == 0)
                    {
                        foreach (string val in row)
                            dataSourceColumns.Add(val);
                    }
                    else
                    {
                        float[] temp = new float[dataSourceColumns.Count];
                        int index1 = 0;

                        foreach (string val in row)
                        {
                            if (val.IndexOf(",") >= 0)
                                temp[index1++] = float.Parse(val.Replace(',', ' '));
                            else
                                temp[index1++] = float.Parse(val);
                        }

                        dataSource.Add(temp);
                    }

                }

                noOfColumns = dataSource[0].Length;
                //MessageBox.Show(noOfColumns.ToString());

                // Creating series for input to charts
                float[] close = new float[dataSource.Count];
                int index = 0;
                foreach (float[] set in dataSource)
                    close[index++] = set[dataSourceColumns.IndexOf("Close")];

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


        // Visibility Handlers
        public void showManageDataSourcePage()
        {
            hideCreateStrategyPage();
            hideBacktestPage();

            dataPointsLabel.Visible = true;
            addIndicatorButton.Visible = true;
            chart1.Visible = true;
            saveDataSource.Visible = true;
            newDataSourceButton.Visible = true;


            dataPointsLabel.BringToFront();
            addIndicatorButton.BringToFront();
            chart1.BringToFront();
            saveDataSource.BringToFront();
            newDataSourceButton.BringToFront();
        }

        public void showCreateStrategyPage()
        {
            hideManageDataSourcePage();
            hideBacktestPage();

            compileStrategyButton.Visible = true;
            loadStrategyButton.Visible = true;
            saveStrategyButton.Visible = true;
            scintillaPanel.Visible = true;

            compileStrategyButton.BringToFront();
            loadStrategyButton.BringToFront();
            saveStrategyButton.BringToFront();
            scintillaPanel.BringToFront();
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
            chart3.Visible = true;
            label3.Visible = true;
            maxDrawDownLabel.Visible = true;
            label4.Visible = true;
            pnlLabel.Visible = true;

            chart2.BringToFront();
            startBacktestButton.BringToFront();
            label1.BringToFront();
            label2.BringToFront();
            TPTextBox.BringToFront();
            SLTextBox.BringToFront();
            chart3.BringToFront();
            label3.BringToFront();
            maxDrawDownLabel.BringToFront();
            label4.BringToFront();
            pnlLabel.BringToFront();

            TPTextBox.Focus();
        }

        public void hideManageDataSourcePage()
        {
            dataPointsLabel.Visible = false;
            addIndicatorButton.Visible = false;
            chart1.Visible = false;
            saveDataSource.Visible = false;
            newDataSourceButton.Visible = false;
        }

        public void hideCreateStrategyPage()
        {
            compileStrategyButton.Visible = false;
            saveStrategyButton.Visible = false;
            loadStrategyButton.Visible = false;
            scintillaPanel.Visible = false;
        }

        public void hideBacktestPage()
        {
            chart2.Visible = false;
            startBacktestButton.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            TPTextBox.Visible = false;
            SLTextBox.Visible = false;
            chart3.Visible = false;
            label3.Visible = false;
            maxDrawDownLabel.Visible = false;
            label4.Visible = false;
            pnlLabel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveDataSource_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();

            for(int i = 0; i < dataSourceColumns.Count; i++)
            {
                if (i != dataSourceColumns.Count - 1)
                    str.Append("\"" + dataSourceColumns[i] + "\",");
                else
                    str.Append("\"" + dataSourceColumns[i] + "\"\n");

            }
            //MessageBox.Show(stringToWrite.ToString());

            for (int i = 0; i < dataSource.Count; i++)
            {
                for (int j = 0; j < dataSource[i].Length; j++)
                {
                    if (j != dataSource[i].Length - 1)
                        str.Append("\"" + dataSource[i][j].ToString() + "\",");
                    else
                        str.Append("\"" + dataSource[i][j].ToString() + "\"\n");

                }
            }
            File.WriteAllText(filePath, str.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TPTextBox_Leave(object sender, EventArgs e)
        {
            SLTextBox.Focus();
        }

        private void SLTextBox_Leave(object sender, EventArgs e)
        {
            startBacktestButton.Focus();
        }

        private void startBacktestButton_Leave(object sender, EventArgs e)
        {
            TPTextBox.Focus();
        }
    }
}
