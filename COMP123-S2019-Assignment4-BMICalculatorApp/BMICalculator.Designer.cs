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
            this.InchesTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MeterLabel = new System.Windows.Forms.Label();
            this.KilogramLabel = new System.Windows.Forms.Label();
            this.KilogramTextBox = new System.Windows.Forms.TextBox();
            this.MeterTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UnitSelectionGroupBox.SuspendLayout();
            this.ImperialTableLayoutPanel.SuspendLayout();
            this.MetricTableLayoutPanel.SuspendLayout();
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
            this.UnitSelectionGroupBox.Location = new System.Drawing.Point(6, 2);
            this.UnitSelectionGroupBox.Name = "UnitSelectionGroupBox";
            this.UnitSelectionGroupBox.Size = new System.Drawing.Size(280, 80);
            this.UnitSelectionGroupBox.TabIndex = 3;
            this.UnitSelectionGroupBox.TabStop = false;
            // 
            // ImperialTableLayoutPanel
            // 
            this.ImperialTableLayoutPanel.ColumnCount = 2;
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.ImperialTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.ImperialTableLayoutPanel.Controls.Add(this.InchLabel, 0, 0);
            this.ImperialTableLayoutPanel.Controls.Add(this.PoundLabel, 0, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 1);
            this.ImperialTableLayoutPanel.Controls.Add(this.InchesTextBox, 1, 0);
            this.ImperialTableLayoutPanel.Location = new System.Drawing.Point(-5, 87);
            this.ImperialTableLayoutPanel.Name = "ImperialTableLayoutPanel";
            this.ImperialTableLayoutPanel.RowCount = 2;
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ImperialTableLayoutPanel.Size = new System.Drawing.Size(280, 120);
            this.ImperialTableLayoutPanel.TabIndex = 4;
            // 
            // InchLabel
            // 
            this.InchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InchLabel.AutoSize = true;
            this.InchLabel.Location = new System.Drawing.Point(3, 0);
            this.InchLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.InchLabel.Name = "InchLabel";
            this.InchLabel.Size = new System.Drawing.Size(162, 60);
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
            this.PoundLabel.Location = new System.Drawing.Point(3, 60);
            this.PoundLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PoundLabel.Name = "PoundLabel";
            this.PoundLabel.Size = new System.Drawing.Size(162, 60);
            this.PoundLabel.TabIndex = 1;
            this.PoundLabel.Text = "Pounds";
            this.PoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InchesTextBox
            // 
            this.InchesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InchesTextBox.Location = new System.Drawing.Point(171, 3);
            this.InchesTextBox.Name = "InchesTextBox";
            this.InchesTextBox.Size = new System.Drawing.Size(106, 68);
            this.InchesTextBox.TabIndex = 2;
            this.InchesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.Location = new System.Drawing.Point(171, 63);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(106, 68);
            this.WeightTextBox.TabIndex = 3;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MetricTableLayoutPanel
            // 
            this.MetricTableLayoutPanel.ColumnCount = 2;
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MetricTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MetricTableLayoutPanel.Controls.Add(this.MeterLabel, 0, 0);
            this.MetricTableLayoutPanel.Controls.Add(this.KilogramLabel, 0, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.KilogramTextBox, 1, 1);
            this.MetricTableLayoutPanel.Controls.Add(this.MeterTextBox, 1, 0);
            this.MetricTableLayoutPanel.Location = new System.Drawing.Point(-5, 87);
            this.MetricTableLayoutPanel.Name = "MetricTableLayoutPanel";
            this.MetricTableLayoutPanel.RowCount = 2;
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MetricTableLayoutPanel.Size = new System.Drawing.Size(280, 120);
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
            this.MeterLabel.Size = new System.Drawing.Size(196, 40);
            this.MeterLabel.TabIndex = 0;
            this.MeterLabel.Text = "Meters";
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
            this.KilogramLabel.Size = new System.Drawing.Size(196, 40);
            this.KilogramLabel.TabIndex = 1;
            this.KilogramLabel.Text = "Kilograms";
            this.KilogramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KilogramTextBox
            // 
            this.KilogramTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KilogramTextBox.Location = new System.Drawing.Point(199, 63);
            this.KilogramTextBox.Name = "KilogramTextBox";
            this.KilogramTextBox.Size = new System.Drawing.Size(78, 68);
            this.KilogramTextBox.TabIndex = 3;
            this.KilogramTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeterTextBox
            // 
            this.MeterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeterTextBox.Location = new System.Drawing.Point(199, 3);
            this.MeterTextBox.Name = "MeterTextBox";
            this.MeterTextBox.Size = new System.Drawing.Size(78, 68);
            this.MeterTextBox.TabIndex = 2;
            this.MeterTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 230);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(148, 45);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(187, 230);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(95, 45);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 411);
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
            this.UnitSelectionGroupBox.ResumeLayout(false);
            this.UnitSelectionGroupBox.PerformLayout();
            this.ImperialTableLayoutPanel.ResumeLayout(false);
            this.ImperialTableLayoutPanel.PerformLayout();
            this.MetricTableLayoutPanel.ResumeLayout(false);
            this.MetricTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialUnitRadioButton;
        private System.Windows.Forms.RadioButton MetricUnitRadioButton;
        private System.Windows.Forms.GroupBox UnitSelectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ImperialTableLayoutPanel;
        private System.Windows.Forms.Label InchLabel;
        private System.Windows.Forms.Label PoundLabel;
        private System.Windows.Forms.TextBox InchesTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TableLayoutPanel MetricTableLayoutPanel;
        private System.Windows.Forms.Label MeterLabel;
        private System.Windows.Forms.Label KilogramLabel;
        private System.Windows.Forms.TextBox KilogramTextBox;
        private System.Windows.Forms.TextBox MeterTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

