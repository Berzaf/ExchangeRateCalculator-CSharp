namespace ExchangeRateCalculator
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.fromGroupBox = new System.Windows.Forms.GroupBox();
            this.fromGbpRadioButton = new System.Windows.Forms.RadioButton();
            this.fromEurRadioButton = new System.Windows.Forms.RadioButton();
            this.fromUsdRadioButton = new System.Windows.Forms.RadioButton();
            this.exchangeTextBox = new System.Windows.Forms.TextBox();
            this.exchangeLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toGroupBox = new System.Windows.Forms.GroupBox();
            this.toGbpRadioButton = new System.Windows.Forms.RadioButton();
            this.toEurRadioButton = new System.Windows.Forms.RadioButton();
            this.toUsdRadioButton = new System.Windows.Forms.RadioButton();
            this.fromGroupBox.SuspendLayout();
            this.toGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(200, 69);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(103, 16);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Enter Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(343, 66);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 1;
            // 
            // fromGroupBox
            // 
            this.fromGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fromGroupBox.Controls.Add(this.fromGbpRadioButton);
            this.fromGroupBox.Controls.Add(this.fromEurRadioButton);
            this.fromGroupBox.Controls.Add(this.fromUsdRadioButton);
            this.fromGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromGroupBox.Location = new System.Drawing.Point(62, 149);
            this.fromGroupBox.Name = "fromGroupBox";
            this.fromGroupBox.Size = new System.Drawing.Size(134, 118);
            this.fromGroupBox.TabIndex = 2;
            this.fromGroupBox.TabStop = false;
            this.fromGroupBox.Text = "From";
            // 
            // fromGbpRadioButton
            // 
            this.fromGbpRadioButton.AutoSize = true;
            this.fromGbpRadioButton.Location = new System.Drawing.Point(43, 95);
            this.fromGbpRadioButton.Name = "fromGbpRadioButton";
            this.fromGbpRadioButton.Size = new System.Drawing.Size(57, 20);
            this.fromGbpRadioButton.TabIndex = 2;
            this.fromGbpRadioButton.TabStop = true;
            this.fromGbpRadioButton.Text = "GBP";
            this.fromGbpRadioButton.UseVisualStyleBackColor = true;
            // 
            // fromEurRadioButton
            // 
            this.fromEurRadioButton.AutoSize = true;
            this.fromEurRadioButton.Location = new System.Drawing.Point(43, 59);
            this.fromEurRadioButton.Name = "fromEurRadioButton";
            this.fromEurRadioButton.Size = new System.Drawing.Size(58, 20);
            this.fromEurRadioButton.TabIndex = 1;
            this.fromEurRadioButton.TabStop = true;
            this.fromEurRadioButton.Text = "EUR";
            this.fromEurRadioButton.UseVisualStyleBackColor = true;
            // 
            // fromUsdRadioButton
            // 
            this.fromUsdRadioButton.AutoSize = true;
            this.fromUsdRadioButton.Location = new System.Drawing.Point(42, 19);
            this.fromUsdRadioButton.Name = "fromUsdRadioButton";
            this.fromUsdRadioButton.Size = new System.Drawing.Size(58, 20);
            this.fromUsdRadioButton.TabIndex = 0;
            this.fromUsdRadioButton.TabStop = true;
            this.fromUsdRadioButton.Text = "USD";
            this.fromUsdRadioButton.UseVisualStyleBackColor = true;
            // 
            // exchangeTextBox
            // 
            this.exchangeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.exchangeTextBox.Location = new System.Drawing.Point(575, 191);
            this.exchangeTextBox.Name = "exchangeTextBox";
            this.exchangeTextBox.Size = new System.Drawing.Size(121, 20);
            this.exchangeTextBox.TabIndex = 4;
            // 
            // exchangeLabel
            // 
            this.exchangeLabel.AutoSize = true;
            this.exchangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangeLabel.Location = new System.Drawing.Point(438, 191);
            this.exchangeLabel.Name = "exchangeLabel";
            this.exchangeLabel.Size = new System.Drawing.Size(116, 16);
            this.exchangeLabel.TabIndex = 3;
            this.exchangeLabel.Text = "Your Exchange:";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(62, 337);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 50);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(273, 337);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 50);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(456, 337);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // toGroupBox
            // 
            this.toGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toGroupBox.Controls.Add(this.toGbpRadioButton);
            this.toGroupBox.Controls.Add(this.toEurRadioButton);
            this.toGroupBox.Controls.Add(this.toUsdRadioButton);
            this.toGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toGroupBox.Location = new System.Drawing.Point(298, 149);
            this.toGroupBox.Name = "toGroupBox";
            this.toGroupBox.Size = new System.Drawing.Size(134, 118);
            this.toGroupBox.TabIndex = 8;
            this.toGroupBox.TabStop = false;
            this.toGroupBox.Text = "To";
            // 
            // toGbpRadioButton
            // 
            this.toGbpRadioButton.AutoSize = true;
            this.toGbpRadioButton.Location = new System.Drawing.Point(43, 95);
            this.toGbpRadioButton.Name = "toGbpRadioButton";
            this.toGbpRadioButton.Size = new System.Drawing.Size(57, 20);
            this.toGbpRadioButton.TabIndex = 2;
            this.toGbpRadioButton.TabStop = true;
            this.toGbpRadioButton.Text = "GBP";
            this.toGbpRadioButton.UseVisualStyleBackColor = true;
            // 
            // toEurRadioButton
            // 
            this.toEurRadioButton.AutoSize = true;
            this.toEurRadioButton.Location = new System.Drawing.Point(43, 59);
            this.toEurRadioButton.Name = "toEurRadioButton";
            this.toEurRadioButton.Size = new System.Drawing.Size(58, 20);
            this.toEurRadioButton.TabIndex = 1;
            this.toEurRadioButton.TabStop = true;
            this.toEurRadioButton.Text = "EUR";
            this.toEurRadioButton.UseVisualStyleBackColor = true;
            // 
            // toUsdRadioButton
            // 
            this.toUsdRadioButton.AutoSize = true;
            this.toUsdRadioButton.Location = new System.Drawing.Point(42, 19);
            this.toUsdRadioButton.Name = "toUsdRadioButton";
            this.toUsdRadioButton.Size = new System.Drawing.Size(58, 20);
            this.toUsdRadioButton.TabIndex = 0;
            this.toUsdRadioButton.TabStop = true;
            this.toUsdRadioButton.Text = "USD";
            this.toUsdRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.exchangeTextBox);
            this.Controls.Add(this.exchangeLabel);
            this.Controls.Add(this.fromGroupBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Name = "Form1";
            this.Text = "Exchange Rate Calculator";
            this.fromGroupBox.ResumeLayout(false);
            this.fromGroupBox.PerformLayout();
            this.toGroupBox.ResumeLayout(false);
            this.toGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox fromGroupBox;
        private System.Windows.Forms.RadioButton fromGbpRadioButton;
        private System.Windows.Forms.RadioButton fromEurRadioButton;
        private System.Windows.Forms.RadioButton fromUsdRadioButton;
        private System.Windows.Forms.TextBox exchangeTextBox;
        private System.Windows.Forms.Label exchangeLabel;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox toGroupBox;
        private System.Windows.Forms.RadioButton toGbpRadioButton;
        private System.Windows.Forms.RadioButton toEurRadioButton;
        private System.Windows.Forms.RadioButton toUsdRadioButton;
    }
}

