namespace LemonadeStand
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
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.lAmount = new System.Windows.Forms.Label();
            this.nudSigns = new System.Windows.Forms.NumericUpDown();
            this.lSigns = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lCost = new System.Windows.Forms.Label();
            this.tbWeather = new System.Windows.Forms.TextBox();
            this.tbCosts = new System.Windows.Forms.TextBox();
            this.tbDebrief = new System.Windows.Forms.TextBox();
            this.bAI = new System.Windows.Forms.Button();
            this.bAlone = new System.Windows.Forms.Button();
            this.cbShareSteal = new System.Windows.Forms.CheckBox();
            this.cbBlind = new System.Windows.Forms.CheckBox();
            this.tbSpecial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(106, 91);
            this.nudAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(179, 20);
            this.nudAmount.TabIndex = 0;
            this.nudAmount.ValueChanged += new System.EventHandler(this.anyNud_ValueChanged);
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(12, 93);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(88, 13);
            this.lAmount.TabIndex = 1;
            this.lAmount.Text = "Glasses to make:";
            // 
            // nudSigns
            // 
            this.nudSigns.Location = new System.Drawing.Point(95, 117);
            this.nudSigns.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSigns.Name = "nudSigns";
            this.nudSigns.Size = new System.Drawing.Size(190, 20);
            this.nudSigns.TabIndex = 2;
            this.nudSigns.ValueChanged += new System.EventHandler(this.anyNud_ValueChanged);
            // 
            // lSigns
            // 
            this.lSigns.AutoSize = true;
            this.lSigns.Location = new System.Drawing.Point(12, 119);
            this.lSigns.Name = "lSigns";
            this.lSigns.Size = new System.Drawing.Size(77, 13);
            this.lSigns.TabIndex = 3;
            this.lSigns.Text = "Signs to make:";
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(145, 143);
            this.nudCost.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(140, 20);
            this.nudCost.TabIndex = 4;
            this.nudCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCost.ValueChanged += new System.EventHandler(this.anyNud_ValueChanged);
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(12, 145);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(127, 13);
            this.lCost.TabIndex = 5;
            this.lCost.Text = "Price per Glass (in cents):";
            // 
            // tbWeather
            // 
            this.tbWeather.Location = new System.Drawing.Point(13, 13);
            this.tbWeather.Name = "tbWeather";
            this.tbWeather.ReadOnly = true;
            this.tbWeather.Size = new System.Drawing.Size(272, 20);
            this.tbWeather.TabIndex = 6;
            this.tbWeather.Text = "The weather is undefined. This shouldn\'t happen.";
            // 
            // tbCosts
            // 
            this.tbCosts.Location = new System.Drawing.Point(13, 39);
            this.tbCosts.Name = "tbCosts";
            this.tbCosts.ReadOnly = true;
            this.tbCosts.Size = new System.Drawing.Size(272, 20);
            this.tbCosts.TabIndex = 7;
            // 
            // tbDebrief
            // 
            this.tbDebrief.Location = new System.Drawing.Point(12, 169);
            this.tbDebrief.Name = "tbDebrief";
            this.tbDebrief.ReadOnly = true;
            this.tbDebrief.Size = new System.Drawing.Size(273, 20);
            this.tbDebrief.TabIndex = 8;
            this.tbDebrief.Text = "This will cost you 0 cents. You have 500 cents.";
            // 
            // bAI
            // 
            this.bAI.Location = new System.Drawing.Point(145, 209);
            this.bAI.Name = "bAI";
            this.bAI.Size = new System.Drawing.Size(140, 23);
            this.bAI.TabIndex = 9;
            this.bAI.Text = "Against AI";
            this.bAI.UseVisualStyleBackColor = true;
            this.bAI.Click += new System.EventHandler(this.bAI_Click);
            // 
            // bAlone
            // 
            this.bAlone.Location = new System.Drawing.Point(12, 209);
            this.bAlone.Name = "bAlone";
            this.bAlone.Size = new System.Drawing.Size(127, 23);
            this.bAlone.TabIndex = 10;
            this.bAlone.Text = "Not competetitive";
            this.bAlone.UseVisualStyleBackColor = true;
            this.bAlone.Click += new System.EventHandler(this.bAlone_Click);
            // 
            // cbShareSteal
            // 
            this.cbShareSteal.AutoSize = true;
            this.cbShareSteal.Location = new System.Drawing.Point(12, 238);
            this.cbShareSteal.Name = "cbShareSteal";
            this.cbShareSteal.Size = new System.Drawing.Size(138, 17);
            this.cbShareSteal.TabIndex = 11;
            this.cbShareSteal.Text = "Combined market (hard)";
            this.cbShareSteal.UseVisualStyleBackColor = true;
            this.cbShareSteal.CheckedChanged += new System.EventHandler(this.cbShareSteal_CheckedChanged);
            // 
            // cbBlind
            // 
            this.cbBlind.AutoSize = true;
            this.cbBlind.Location = new System.Drawing.Point(186, 238);
            this.cbBlind.Name = "cbBlind";
            this.cbBlind.Size = new System.Drawing.Size(99, 17);
            this.cbBlind.TabIndex = 12;
            this.cbBlind.Text = "Blind AI (easier)";
            this.cbBlind.UseVisualStyleBackColor = true;
            this.cbBlind.CheckedChanged += new System.EventHandler(this.cbBlind_CheckedChanged);
            // 
            // tbSpecial
            // 
            this.tbSpecial.Location = new System.Drawing.Point(13, 65);
            this.tbSpecial.Name = "tbSpecial";
            this.tbSpecial.ReadOnly = true;
            this.tbSpecial.Size = new System.Drawing.Size(272, 20);
            this.tbSpecial.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 267);
            this.Controls.Add(this.tbSpecial);
            this.Controls.Add(this.cbBlind);
            this.Controls.Add(this.cbShareSteal);
            this.Controls.Add(this.bAlone);
            this.Controls.Add(this.bAI);
            this.Controls.Add(this.tbDebrief);
            this.Controls.Add(this.tbCosts);
            this.Controls.Add(this.tbWeather);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.lSigns);
            this.Controls.Add(this.nudSigns);
            this.Controls.Add(this.lAmount);
            this.Controls.Add(this.nudAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lemonade Stand";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSigns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.NumericUpDown nudSigns;
        private System.Windows.Forms.Label lSigns;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.TextBox tbWeather;
        private System.Windows.Forms.TextBox tbCosts;
        private System.Windows.Forms.TextBox tbDebrief;
        private System.Windows.Forms.Button bAI;
        private System.Windows.Forms.Button bAlone;
        private System.Windows.Forms.CheckBox cbShareSteal;
        private System.Windows.Forms.CheckBox cbBlind;
        private System.Windows.Forms.TextBox tbSpecial;
    }
}

