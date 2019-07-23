﻿using System;
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
        // PRIVATE DATA MEMBERS
        private TextBox m_activeTextBox;

        // CLASS PROPERTIES
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        public AnimationState animationState;

        public TextBox ActiveTextBox
        {
            get
            {
                return m_activeTextBox;
            }
            set
            {
                // Check if m_activeTextBox is already pointing at a textBox
                if(m_activeTextBox != null)
                {
                    m_activeTextBox.BackColor = Color.White;
                }

                m_activeTextBox = value;

                // Check if m_activeTextBox has not been set to null
                if(m_activeTextBox != null)
                {
                    m_activeTextBox.BackColor = Color.LightBlue;
                }
            }
        }

        /// <summary>
        /// This is the constructor for the BMICalculator
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
            this.Size = new Size(320, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// This is the event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            clearNumericKeyboard();
            NumberButtonTableLayoutPanel.Visible = false;
            ActiveTextBox = null;
            animationState = AnimationState.IDLE;
            BMITableLayoutPanel.Visible = false;
        }

        /// <summary>
        /// This is the event handler for the BMICalculator form click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Click(object sender, EventArgs e)
        {
            clearNumericKeyboard();
            //NumberButtonTableLayoutPanel.Visible = false;
            ActiveTextBox = null;
            animationState = AnimationState.DOWN;
            AnimationTimer.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayBMI();
            DisplayBMIScale();
        }

        private void DisplayBMIScale()
        {
            MultilineTextBox.Visible = true;
            float bmi = float.Parse(BMITextBox.Text);
            if (bmi < 18.5)
            {
                MultilineTextBox.Text = "Your BMI Scale is Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                MultilineTextBox.Text = "Your BMI Scale is Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                MultilineTextBox.Text = "Your BMI Scale is Overweight";
            }
            else if (bmi >= 30)
            {
                MultilineTextBox.Text = "Your BMI Scale is Obese";
            }
        }

        private void CalculateAndDisplayBMI()
        {
            BMITableLayoutPanel.Visible = true;
            float bmi = 0.0f;
            float weight = 0.0f;
            float height = 0.0f;
            if (ImperialUnitRadioButton.Checked)
            {
                weight = float.Parse(PoundTextBox.Text);
                height = float.Parse(InchTextBox.Text);
                bmi = weight * 703 / (float)(Math.Pow(height, 2));
                bmi = (float)(Math.Round(bmi, 1));
            }
            else
            {
                weight = float.Parse(KilogramTextBox.Text);
                height = float.Parse(MeterTextBox.Text);
                bmi = weight / (float)(Math.Pow(height, 2));
                bmi = (float)(Math.Round(bmi, 1));
            }
            BMITextBox.Text = bmi.ToString();
        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ImperialUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
            ActiveTextBox = null;
            AnimationTimer.Enabled = true;
            animationState = AnimationState.DOWN;
        }

        private void MetricUnitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
            ActiveTextBox = null;
            AnimationTimer.Enabled = true;
            animationState = AnimationState.DOWN;
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

            ActiveTextBox.Text = outputValue.ToString();
            clearNumericKeyboard();
            //NumberButtonTableLayoutPanel.Visible = false;
            ActiveTextBox.BackColor = Color.White;
            ActiveTextBox = null;
            animationState = AnimationState.DOWN;
            AnimationTimer.Enabled = true;
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
        /// This is the event handler for the ActiveTextBox click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveTextBox_Click(object sender, EventArgs e)
        {
            ActiveTextBox = sender as TextBox;
            ActiveTextBox.BackColor = Color.LightBlue;

            NumberButtonTableLayoutPanel.Visible = true;

            if(ActiveTextBox.Text != "0")
            {
                ResultLabel.Text = ActiveTextBox.Text;
                outputString = ActiveTextBox.Text;  
            }
            
            NumberButtonTableLayoutPanel.BringToFront();

            AnimationTimer.Enabled = true;
            animationState = AnimationState.UP;
        }

        /// <summary>
        /// This is the event handler for the AnimationTimer Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            switch(animationState)
            {
                case AnimationState.IDLE:
                    break;
                case AnimationState.UP:
                    MoveNumberButtonTableUp();
                    break;
                case AnimationState.DOWN:
                    MoveNumberButtonTableDown();
                    break;
            }
        }

        private void MoveNumberButtonTableUp()
        {
            var currentLocation = NumberButtonTableLayoutPanel.Location;

            // Decrement current location of NumberButtonTableLayoutPanel by 20
            NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y - 20);

            // Compare NumberButtonTableLayoutPanel current location with the ActiveLabel
            if (currentLocation.Y <= ActiveTextBox.Location.Y + 130)
            {
                NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, ActiveTextBox.Location.Y + 130);
                AnimationTimer.Enabled = false;
                animationState = AnimationState.IDLE;
            }
        }

        private void MoveNumberButtonTableDown()
        {
            var currentLocation = NumberButtonTableLayoutPanel.Location;

            // Increment current location of NumberButtonTableLayoutPanel by 20
            NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, currentLocation.Y + 20);

            // Compare NumberButtonTableLayoutPanel current location with the ActiveLabel
            if (currentLocation.Y >= 450)
            {
                NumberButtonTableLayoutPanel.Location = new Point(currentLocation.X, 450);
                AnimationTimer.Enabled = false;
                animationState = AnimationState.IDLE;
            }
        }

        /// <summary>
        /// This is the event handler for ResetButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            InchTextBox.Text = "0";
            PoundTextBox.Text = "0";
            MeterTextBox.Text = "0";
            KilogramTextBox.Text = "0";
            BMITextBox.Text = "0";
            MultilineTextBox.Text = " ";
            BMITableLayoutPanel.Visible = false;
            MultilineTextBox.Visible = false;
        }
    }
}
