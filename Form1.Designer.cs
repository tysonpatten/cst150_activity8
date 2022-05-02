namespace cast150Activity8
{
    partial class Form1
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
            this.inputFatGrams = new System.Windows.Forms.TextBox();
            this.outputFatCalories = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFatGrams = new System.Windows.Forms.Label();
            this.lblFatCalories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarbGrams = new System.Windows.Forms.Label();
            this.outputCarbCalories = new System.Windows.Forms.TextBox();
            this.inputCarbGrams = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputFatGrams
            // 
            this.inputFatGrams.Location = new System.Drawing.Point(414, 197);
            this.inputFatGrams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFatGrams.Name = "inputFatGrams";
            this.inputFatGrams.Size = new System.Drawing.Size(148, 26);
            this.inputFatGrams.TabIndex = 0;
            // 
            // outputFatCalories
            // 
            this.outputFatCalories.Location = new System.Drawing.Point(414, 259);
            this.outputFatCalories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputFatCalories.Name = "outputFatCalories";
            this.outputFatCalories.Size = new System.Drawing.Size(148, 26);
            this.outputFatCalories.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Location = new System.Drawing.Point(448, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFatGrams
            // 
            this.lblFatGrams.AutoSize = true;
            this.lblFatGrams.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFatGrams.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFatGrams.Location = new System.Drawing.Point(198, 197);
            this.lblFatGrams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFatGrams.Name = "lblFatGrams";
            this.lblFatGrams.Size = new System.Drawing.Size(138, 19);
            this.lblFatGrams.TabIndex = 3;
            this.lblFatGrams.Text = "Enter Fat Grams:";
            // 
            // lblFatCalories
            // 
            this.lblFatCalories.AutoSize = true;
            this.lblFatCalories.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblFatCalories.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFatCalories.Location = new System.Drawing.Point(188, 259);
            this.lblFatCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFatCalories.Name = "lblFatCalories";
            this.lblFatCalories.Size = new System.Drawing.Size(145, 19);
            this.lblFatCalories.TabIndex = 4;
            this.lblFatCalories.Text = "Calories from Fat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(594, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calories from Carbs:";
            // 
            // lblCarbGrams
            // 
            this.lblCarbGrams.AutoSize = true;
            this.lblCarbGrams.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblCarbGrams.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCarbGrams.Location = new System.Drawing.Point(618, 197);
            this.lblCarbGrams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarbGrams.Name = "lblCarbGrams";
            this.lblCarbGrams.Size = new System.Drawing.Size(149, 19);
            this.lblCarbGrams.TabIndex = 7;
            this.lblCarbGrams.Text = "Enter Carb Grams:";
            // 
            // outputCarbCalories
            // 
            this.outputCarbCalories.Location = new System.Drawing.Point(850, 259);
            this.outputCarbCalories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputCarbCalories.Name = "outputCarbCalories";
            this.outputCarbCalories.Size = new System.Drawing.Size(148, 26);
            this.outputCarbCalories.TabIndex = 6;
            // 
            // inputCarbGrams
            // 
            this.inputCarbGrams.Location = new System.Drawing.Point(850, 197);
            this.inputCarbGrams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputCarbGrams.Name = "inputCarbGrams";
            this.inputCarbGrams.Size = new System.Drawing.Size(148, 26);
            this.inputCarbGrams.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1249, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCarbGrams);
            this.Controls.Add(this.outputCarbCalories);
            this.Controls.Add(this.inputCarbGrams);
            this.Controls.Add(this.lblFatCalories);
            this.Controls.Add(this.lblFatGrams);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputFatCalories);
            this.Controls.Add(this.inputFatGrams);
            this.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Grams to Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFatGrams;
        private System.Windows.Forms.TextBox outputFatCalories;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFatGrams;
        private System.Windows.Forms.Label lblFatCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarbGrams;
        private System.Windows.Forms.TextBox outputCarbCalories;
        private System.Windows.Forms.TextBox inputCarbGrams;
    }
}

