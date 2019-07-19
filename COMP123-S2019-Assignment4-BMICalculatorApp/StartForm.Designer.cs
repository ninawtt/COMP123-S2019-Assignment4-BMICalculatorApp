namespace COMP123_S2019_Assignment4_BMICalculatorApp
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeTextLabel = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.WelcomeTextLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeTextLabel
            // 
            this.WelcomeTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeTextLabel.AutoSize = true;
            this.WelcomeTextLabel.Font = new System.Drawing.Font("Mistral", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTextLabel.Location = new System.Drawing.Point(100, 124);
            this.WelcomeTextLabel.Name = "WelcomeTextLabel";
            this.WelcomeTextLabel.Size = new System.Drawing.Size(150, 101);
            this.WelcomeTextLabel.TabIndex = 0;
            this.WelcomeTextLabel.Text = "BMI";
            this.WelcomeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // WelcomeTextLabel1
            // 
            this.WelcomeTextLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeTextLabel1.AutoSize = true;
            this.WelcomeTextLabel1.Font = new System.Drawing.Font("Mistral", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTextLabel1.Location = new System.Drawing.Point(60, 187);
            this.WelcomeTextLabel1.Name = "WelcomeTextLabel1";
            this.WelcomeTextLabel1.Size = new System.Drawing.Size(335, 101);
            this.WelcomeTextLabel1.TabIndex = 1;
            this.WelcomeTextLabel1.Text = "Calculator";
            this.WelcomeTextLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.WelcomeTextLabel1);
            this.Controls.Add(this.WelcomeTextLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeTextLabel;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label WelcomeTextLabel1;
    }
}