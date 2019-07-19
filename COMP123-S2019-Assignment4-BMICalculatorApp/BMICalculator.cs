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
        public BMICalculator()
        {
            InitializeComponent();
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
    }
}
