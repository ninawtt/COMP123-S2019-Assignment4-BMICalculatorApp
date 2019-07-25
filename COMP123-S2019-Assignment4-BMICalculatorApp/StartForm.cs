using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project Name : COMP123-S2019-Assignment4-BMICalculatorApp
// Program Name : Program.cs
// Author : Tzu-Ting Wu (Nina)
// Author's Student Number : 301040475
// Created On : 7/18/2019 9:11:00 PM
// Last Modified On : 7/25/2019 16:54:00 PM
// Description : Create a BMI calculator application
// Revision History  :
// *
// * Date             Author Ref         Revision(Date in YYYYMMDD format)
// * 20190721         Tzu-Ting Wu        1  Added the numeric keyboard for the textboxes      
// * 20190722         Tzu-Ting Wu        2  Added numeric keyboard animation and completed BMI calculation functionality
// * 20190725         Tzu-Ting Wu        3  Fixed the calculate button's enable functionality
// * 
// * 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace COMP123_S2019_Assignment4_BMICalculatorApp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.bMICalculator.Show();
            Program.startForm.Hide();
        }
    }
}
