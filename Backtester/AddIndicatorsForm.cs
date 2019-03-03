using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backtester
{
    public partial class AddIndicatorsForm : Form
    {
        public List<float[]> dataSource;
        public List<string> dataSourceColumns;

        public AddIndicatorsForm(List<float[]> dataSource, List<string> dataSourceColumns)
        {
            InitializeComponent();

            this.dataSource = dataSource;
            this.dataSourceColumns = dataSourceColumns;

            MovingAveragePanel.Visible = false;
        }

        private void AddIndicators_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();

            setAllPanelsToInvisible();

            if(selectedItem == "Simple Moving Average" || selectedItem == "Exponential Moving Average")
            {
                MovingAveragePanel.Visible = true;

                foreach(string val in dataSourceColumns)
                    comboBox1.Items.Add(val);
            }
            
            
        }

        private void setAllPanelsToInvisible()
        {
            MovingAveragePanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            int period;
            string targetAttribute;

            if (selectedItem == "Simple Moving Average" || selectedItem == "Exponential Moving Average")
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Target attribute is NOT selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    targetAttribute = comboBox1.SelectedItem.ToString();

                try
                {
                    period = int.Parse(textBox1.Text.ToString());
                    if(period < 1)
                    {
                        MessageBox.Show("Invalid value specified for period!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (selectedItem == "Simple Moving Average")
                    {
                        generateSimpleMovingAverage(period, targetAttribute);
                        //MessageBox.Show("REACHED");
                        this.DialogResult = DialogResult.OK;
                        //this.Close();                       
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Invalid value specified for period!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void generateSimpleMovingAverage(int period, string targetAttribute)
        {
            try
            {
                float[] avg = new float[dataSource.Count];
                int targetAttributeIndex = 0;

                for (int i = 0; i < dataSourceColumns.Count; i++)
                    if (dataSourceColumns[i] == targetAttribute)
                        targetAttributeIndex = i;


                for (int i = 0; i < period - 1; i++)
                    avg[i] = 0.00f;

                float sum = 0.00f;

                for (int i = 0; i < period; i++)
                    sum += dataSource[i][targetAttributeIndex];
                
                for (int i = period - 1; i < dataSource.Count; i++)
                {
                    avg[i] = (sum / float.Parse(period.ToString()));

                    if (i != (dataSource.Count - 1))
                    {
                        sum -= dataSource[i - period + 1][targetAttributeIndex];
                        sum += dataSource[i + 1][targetAttributeIndex];
                    }
                }
                
                dataSourceColumns.Add("SMA" + period.ToString());
                
                int totalAttributes = dataSourceColumns.Count;
                for (int i = 0; i < dataSource.Count; i++)
                {
                    float[] temp = new float[totalAttributes + 1];
                    int index = 0;

                    foreach(float val in dataSource[i])
                        temp[index++] = val;

                    temp[index] = avg[i];

                    dataSource[i] = temp;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
