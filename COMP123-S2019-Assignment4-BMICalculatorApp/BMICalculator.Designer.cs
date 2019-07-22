namespace COMP123_S2019_Assignment4_BMICalculatorApp
{
    partial class BMICalculator
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
            this.ImperialUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricUnitRadioButton = new System.Windows.Forms.RadioButton();
            this.UnitSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ImperialTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InchLabel = new System.Windows.Forms.Label();
            this.PoundLabel = new System.Windows.Forms.Label();
            this.PoundTextBox = new System.Windows.Forms.TextBox();
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MeterLabel = new System.Windows.Forms.Label();
            this.KilogramLabel = new System.Windows.Forms.Label();
            this.KilogramTextBox = new System.Windows.Forms.TextBox();
            this.MeterTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.MultilineTextBox = new System.Windows.Forms.TextBox();
            this.NumberButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UnitSelectionGroupBox.SuspendLayout();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
            this.BMITableLayoutPanel.SuspendLayout();
            this.NumberButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialUnitRadioButton
            // 
            this.ImperialUnitRadioButton.AutoSize = true;
            this.ImperialUnitRadioButton.Checked = true;
            this.ImperialUnitRadioButton.Location = new System.Drawing.Point(6, 27);
            this.ImperialUnitRadioButton.Name = "ImperialUnitRadioButton";
            this.ImperialUnitRadioButton.Size = new System.Drawing.Size(246, 67);
            this.ImperialUnitRadioButton.TabIndex = 0;
            this.ImperialUnitRadioButton.TabStop = true;
            this.ImperialUnitRadioButton.Text = "Imperial";
            this.ImperialUnitRadioButton.UseVisualStyleBackColor = true;
            this.ImperialUnitRadioButton.CheckedChanged += new System.EventHandler(this.ImperialUnitRadioButton_CheckedChanged);
            // 
            // MetricUnitRadioButton
            // 
            this.MetricUnitRadioButton.AutoSize = true;
            this.MetricUnitRadioButton.Location = new System.Drawing.Point(156, 27);
            this.MetricUnitRadioButton.Name = "MetricUnitRadioButton";
            this.MetricUnitRadioButton.Size = new System.Drawing.Size(200, 67);
            this.MetricUnitRadioButton.TabIndex = 1;
            this.MetricUnitRadioButton.Text = "Metric";
            this.MetricUnitRadioButton.UseVisualStyleBackColor = true;
            this.MetricUnitRadioButton.CheckedChanged += new System.EventHandler(this.MetricUnitRadioButton_CheckedChanged);
            // 
            // UnitSelectionGroupBox
            // 
            this.UnitSelectionGroupBox.Controls.Add(this.ImperialUnitRadioButton);
            this.UnitSelectionGroupBox.Controls.Add(this.MetricUnitRadioButton);
            this.UnitSelectionGroupBox.Location = new System.Drawing.Point(6, -1);
            this.UnitSelectionGroupBox.Name = "UnitSelectionGroupBox";
            this.UnitSelectionGroupBox.Size = new System.Drawing.Size(280, 80);
            this.UnitSelectionGroupBox.TabIndex = 3;
            this.UnitSelectionGroupBox.TabStop = false;
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ImperialTableLayoutPanel.Controls.Add(this.InchLabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.PoundLabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.PoundTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.InchesTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(50, 85);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(200, 120);
            this.ImperialTableLayoutPanel.TabIndex = 4;
            // 
            // InchLabel
            // 
            this.InchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InchLabel.AutoSize = true;
            this.InchLabel.Location = new System.Drawing.Point(0, 0);
            this.InchLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(120, 40);
            this.InchLabel.TabIndex = 0;
            this.InchLabel.Text = "Inches";
            this.InchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoundLabel
            // 
            this.PoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoundLabel.AutoSize = true;
            this.PoundLabel.Location = new System.Drawing.Point(0, 60);
            this.PoundLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PoundLabel.Name = "PoundLabel";
            this.PoundLabel.Size = new System.Drawing.Size(120, 40);
            this.PoundLabel.TabIndex = 1;
            this.PoundLabel.Text = "Pounds";
            this.PoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PoundTextBox
            // 
            this.PoundTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoundTextBox.Location = new System.Drawing.Point(123, 63);
            this.PoundTextBox.Name = "PoundTextBox";
            this.PoundTextBox.Size = new System.Drawing.Size(74, 68);
            this.PoundTextBox.TabIndex = 3;
            this.PoundTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InchesTextBox.Location = new System.Drawing.Point(123, 3);
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(74, 68);
            this.InchesTextBox.TabIndex = 2;
            this.InchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MetricTableLayoutPanel.Controls.Add(this.MeterLabel, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.KilogramLabel, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.KilogramTextBox, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MeterTextBox, 1, 0);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(50, 85);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(200, 120);
            this.MetricTableLayoutPanel.TabIndex = 5;
            this.MetricTableLayoutPanel.Visible = false;
            // 
            // MeterLabel
            // 
            this.MeterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeterLabel.AutoSize = true;
            this.MeterLabel.Location = new System.Drawing.Point(0, 0);
            this.MeterLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.MeterLabel.Name = "MeterLabel";
            this.MeterLabel.Size = new System.Drawing.Size(120, 40);
            this.MeterLabel.TabIndex = 0;
            this.MeterLabel.Text = " Meters";
            this.MeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KilogramLabel
            // 
            this.KilogramLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KilogramLabel.AutoSize = true;
            this.KilogramLabel.Location = new System.Drawing.Point(0, 60);
            this.KilogramLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.KilogramLabel.Name = "KilogramLabel";
            this.KilogramLabel.Size = new System.Drawing.Size(120, 40);
            this.KilogramLabel.TabIndex = 1;
            this.KilogramLabel.Text = "Kilograms";
            this.KilogramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KilogramTextBox
            // 
            this.KilogramTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KilogramTextBox.Location = new System.Drawing.Point(123, 63);
            this.KilogramTextBox.Name = "KilogramTextBox";
            this.KilogramTextBox.Size = new System.Drawing.Size(74, 68);
            this.KilogramTextBox.TabIndex = 3;
            this.KilogramTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeterTextBox
            // 
            this.MeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeterTextBox.Location = new System.Drawing.Point(123, 3);
            this.MeterTextBox.Name = "MeterTextBox";
            this.MeterTextBox.Size = new System.Drawing.Size(74, 68);
            this.MeterTextBox.TabIndex = 2;
            this.MeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 205);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(148, 45);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(187, 205);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(95, 45);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.BMITableLayoutPanel.Controls.Add(this.BMITextBox, 1, 0);
            this.BMITableLayoutPanel.Controls.Add(this.BMILabel, 0, 0);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(32, 260);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 1;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(239, 60);
            this.BMITableLayoutPanel.TabIndex = 10;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITextBox.Location = new System.Drawing.Point(143, 0);
            this.BMITextBox.Margin = new System.Windows.Forms.Padding(0);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(96, 68);
            this.BMITextBox.TabIndex = 1;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMILabel
            // 
            this.BMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMILabel.AutoSize = true;
            this.BMILabel.Location = new System.Drawing.Point(0, 0);
            this.BMILabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(143, 40);
            this.BMILabel.TabIndex = 0;
            this.BMILabel.Text = "BMI";
            this.BMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultilineTextBox
            // 
            this.MultilineTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultilineTextBox.Location = new System.Drawing.Point(21, 315);
            this.MultilineTextBox.Multiline = true;
            this.MultilineTextBox.Name = "MultilineTextBox";
            this.MultilineTextBox.Size = new System.Drawing.Size(261, 88);
            this.MultilineTextBox.TabIndex = 13;
            // 
            // NumberButtonTableLayoutPanel
            // 
            this.NumberButtonTableLayoutPanel.ColumnCount = 4;
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.BackButton, 3, 1);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ClearButton, 3, 2);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.NumberButtonTableLayoutPanel.Controls.Add(this.DoneButton, 3, 3);
            this.NumberButtonTableLayoutPanel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberButtonTableLayoutPanel.Location = new System.Drawing.Point(6, 446);
            this.NumberButtonTableLayoutPanel.Name = "NumberButtonTableLayoutPanel";
            this.NumberButtonTableLayoutPanel.RowCount = 5;
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.NumberButtonTableLayoutPanel.Size = new System.Drawing.Size(284, 318);
            this.NumberButtonTableLayoutPanel.TabIndex = 14;
            // 
            // ResultLabel
            // 
            this.ResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberButtonTableLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(278, 63);
            this.ResultLabel.TabIndex = 15;
            this.ResultLabel.Tag = "Result";
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(145, 192);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(65, 57);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(74, 192);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(65, 57);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(3, 192);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(65, 57);
            this.OneButton.TabIndex = 6;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(145, 129);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(65, 57);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(74, 129);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(65, 57);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 129);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(65, 57);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(145, 66);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(65, 57);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(74, 66);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(65, 57);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 66);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(65, 57);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(145, 255);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(65, 60);
            this.DecimalButton.TabIndex = 16;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackButton.BackgroundImage = global::COMP123_S2019_Assignment4_BMICalculatorApp.Properties.Resources.backbutton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(216, 66);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(65, 57);
            this.BackButton.TabIndex = 17;
            this.BackButton.Tag = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(216, 129);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(65, 57);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NumberButtonTableLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 255);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(136, 60);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.BackColor = System.Drawing.Color.SeaGreen;
            this.DoneButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(216, 192);
            this.DoneButton.Name = "DoneButton";
            this.NumberButtonTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(65, 123);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 860);
            this.Controls.Add(this.NumberButtonTableLayoutPanel);
            this.Controls.Add(this.MultilineTextBox);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.MetricTableLayoutPanel);
            this.Controls.Add(this.ImperialTableLayoutPanel);
            this.Controls.Add(this.UnitSelectionGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.UnitSelectionGroupBox.ResumeLayout(false);
            this.UnitSelectionGroupBox.PerformLayout();
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.NumberButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.GroupBox UnitSelectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Label PoundLabel;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.TextBox PoundTextBox;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.Label MeterLabel;
        private System.Windows.Forms.Label KilogramLabel;
        private System.Windows.Forms.TextBox KilogramTextBox;
        private System.Windows.Forms.TextBox MeterTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox MultilineTextBox;
        private System.Windows.Forms.TableLayoutPanel NumberButtonTableLayoutPanel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

