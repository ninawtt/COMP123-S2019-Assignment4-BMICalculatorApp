using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Project Name : COMP123-S2019-Assignment4-BMICalculatorApp
// Program Name : Program.cs
// Author : Tzu-Ting Wu (Nina)
// Author's Student Number : 301040475
// Created On : 7/18/2019 9:11:00 PM
// Last Modified On : 7/25/2019 17:27:00 PM
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
    static class Program
    {
        public static StartForm startForm;
        public static BMICalculator bMICalculator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            bMICalculator = new BMICalculator();

            Application.Run(startForm);
        }
    }
}
