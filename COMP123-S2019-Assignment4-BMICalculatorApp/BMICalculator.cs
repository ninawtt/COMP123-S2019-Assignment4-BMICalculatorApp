using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace COMP123_S2019_Assignment4_BMICalculatorApp
{
    public partial class BMICalculator : Form
    {
        // CLASS PROPERTIES
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }

        /// <summary>
        /// This is the constructor for the BMICalculator
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
            this.Height = 480;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Program.resultForm.Show();
            Program.bMICalculator.Hide();
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
        }

        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
        }

        /// <summary>
        /// This is a shared event handler for the NumericButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericButton_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;

            bool numericResult = int.TryParse(tag, out numericValue);
            
            if(numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;
                if(outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if(outputString.Length < maxSize)
                    {
                        outputString += tag;
                    }
                }
                ResultLabel.Text = outputString;
            }
            else
            {
                switch(tag)
                {
                    case "back":
                        removeLastCharacterFromResultLabel ();
                        break;
                    case "clear":
                        clearNumericKeyboard();
                        break;
                    case "done":
                        finalizeOutput ();
                        break;
                    case "decimal":
                        addDecimalToResultLabel();
                        break;
                }
            }
        }

        /// <summary>
        /// This method adds a decimal point to the ResultLabel
        /// </summary>
        private void addDecimalToResultLabel()
        {
            if (decimalExists == false)
            {
                outputString += ".";
                decimalExists = true;
            }
        }

        /// <summary>
        /// This method finalizes and converts the outputString to a floating point values
        /// </summary>
        private void finalizeOutput()
        {
            outputValue = float.Parse(outputString);
            outputValue = (float)(Math.Round(outputValue, 1));
            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            //if (ImperialUnitRadioButton.Checked)
            //{
            //    if (InchesTextBox.Focused)
            //    {
            //        InchesTextBox.Text = outputValue.ToString();
            //    }
            //    if (PoundTextBox.Focused)
            //    {
            //        PoundTextBox.Text = outputValue.ToString();
            //    }
            //}
            //else
            //{
            //    MeterTextBox.Text = outputValue.ToString();
            //}
            clearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
        }

        /// <summary>
        /// This method removes the last character from the ResultLabel  
        /// </summary>
        private void removeLastCharacterFromResultLabel()
        {
            var lastChar = outputString.Substring(outputString.Length - 1);
            if (lastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }

            ResultLabel.Text = outputString;
        }

        /// <summary>
        /// This method resets the numeric keyboard and related variables
        /// </summary>
        private void clearNumericKeyboard()
        {
            outputString = "0";
            outputValue = 0.0f;
            ResultLabel.Text = "0";
            decimalExists = false;
        }

        /// <summary>
        /// This is the event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            clearNumericKeyboard(); 
        }
    }
}
