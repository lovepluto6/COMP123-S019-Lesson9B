namespace COMP123_S019_Lesson9B
{
    partial class Calculator
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
            this.CalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Donebutton = new System.Windows.Forms.Button();
            this.Zerobutton = new System.Windows.Forms.Button();
            this.Threebutton = new System.Windows.Forms.Button();
            this.Twobutton = new System.Windows.Forms.Button();
            this.Onebutton = new System.Windows.Forms.Button();
            this.Sixbutton = new System.Windows.Forms.Button();
            this.Fivebutton = new System.Windows.Forms.Button();
            this.Fourbutton = new System.Windows.Forms.Button();
            this.Ninebutton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.pointbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.CalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorTableLayoutPanel
            // 
            this.CalculatorTableLayoutPanel.ColumnCount = 4;
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.Controls.Add(this.ResultLabel, 0, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Threebutton, 2, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Twobutton, 1, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Onebutton, 0, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Sixbutton, 2, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Fivebutton, 1, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Fourbutton, 0, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Ninebutton, 2, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Clearbutton, 3, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.pointbutton, 2, 4);
            this.CalculatorTableLayoutPanel.Controls.Add(this.backbutton, 3, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Donebutton, 3, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.Zerobutton, 0, 4);
            this.CalculatorTableLayoutPanel.Location = new System.Drawing.Point(0, 195);
            this.CalculatorTableLayoutPanel.Name = "CalculatorTableLayoutPanel";
            this.CalculatorTableLayoutPanel.RowCount = 5;
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorTableLayoutPanel.Size = new System.Drawing.Size(302, 246);
            this.CalculatorTableLayoutPanel.TabIndex = 0;
            // 
            // Donebutton
            // 
            this.Donebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Donebutton.BackColor = System.Drawing.Color.LightGreen;
            this.Donebutton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Donebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Donebutton.Location = new System.Drawing.Point(228, 150);
            this.Donebutton.Name = "Donebutton";
            this.CalculatorTableLayoutPanel.SetRowSpan(this.Donebutton, 2);
            this.Donebutton.Size = new System.Drawing.Size(71, 93);
            this.Donebutton.TabIndex = 11;
            this.Donebutton.Tag = "done";
            this.Donebutton.Text = "Done";
            this.Donebutton.UseVisualStyleBackColor = false;
            this.Donebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Zerobutton
            // 
            this.Zerobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Zerobutton.BackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorTableLayoutPanel.SetColumnSpan(this.Zerobutton, 2);
            this.Zerobutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zerobutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Zerobutton.Location = new System.Drawing.Point(3, 199);
            this.Zerobutton.Name = "Zerobutton";
            this.Zerobutton.Size = new System.Drawing.Size(144, 44);
            this.Zerobutton.TabIndex = 10;
            this.Zerobutton.Tag = "0";
            this.Zerobutton.Text = "0";
            this.Zerobutton.UseVisualStyleBackColor = false;
            this.Zerobutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Threebutton
            // 
            this.Threebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Threebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Threebutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Threebutton.Location = new System.Drawing.Point(153, 150);
            this.Threebutton.Name = "Threebutton";
            this.Threebutton.Size = new System.Drawing.Size(69, 43);
            this.Threebutton.TabIndex = 8;
            this.Threebutton.Tag = "3";
            this.Threebutton.Text = "3";
            this.Threebutton.UseVisualStyleBackColor = false;
            this.Threebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Twobutton
            // 
            this.Twobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Twobutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Twobutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twobutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Twobutton.Location = new System.Drawing.Point(78, 150);
            this.Twobutton.Name = "Twobutton";
            this.Twobutton.Size = new System.Drawing.Size(69, 43);
            this.Twobutton.TabIndex = 7;
            this.Twobutton.Tag = "2";
            this.Twobutton.Text = "2";
            this.Twobutton.UseVisualStyleBackColor = false;
            this.Twobutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Onebutton
            // 
            this.Onebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Onebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Onebutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Onebutton.Location = new System.Drawing.Point(3, 150);
            this.Onebutton.Name = "Onebutton";
            this.Onebutton.Size = new System.Drawing.Size(69, 43);
            this.Onebutton.TabIndex = 6;
            this.Onebutton.Tag = "1";
            this.Onebutton.Text = "1";
            this.Onebutton.UseVisualStyleBackColor = false;
            this.Onebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Sixbutton
            // 
            this.Sixbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sixbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Sixbutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sixbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sixbutton.Location = new System.Drawing.Point(153, 101);
            this.Sixbutton.Name = "Sixbutton";
            this.Sixbutton.Size = new System.Drawing.Size(69, 43);
            this.Sixbutton.TabIndex = 5;
            this.Sixbutton.Tag = "6";
            this.Sixbutton.Text = "6";
            this.Sixbutton.UseVisualStyleBackColor = false;
            this.Sixbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Fivebutton
            // 
            this.Fivebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fivebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Fivebutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fivebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fivebutton.Location = new System.Drawing.Point(78, 101);
            this.Fivebutton.Name = "Fivebutton";
            this.Fivebutton.Size = new System.Drawing.Size(69, 43);
            this.Fivebutton.TabIndex = 4;
            this.Fivebutton.Tag = "5";
            this.Fivebutton.Text = "5";
            this.Fivebutton.UseVisualStyleBackColor = false;
            this.Fivebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Fourbutton
            // 
            this.Fourbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fourbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Fourbutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fourbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fourbutton.Location = new System.Drawing.Point(3, 101);
            this.Fourbutton.Name = "Fourbutton";
            this.Fourbutton.Size = new System.Drawing.Size(69, 43);
            this.Fourbutton.TabIndex = 3;
            this.Fourbutton.Tag = "4";
            this.Fourbutton.Text = "4";
            this.Fourbutton.UseVisualStyleBackColor = false;
            this.Fourbutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // Ninebutton
            // 
            this.Ninebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ninebutton.BackColor = System.Drawing.Color.SteelBlue;
            this.Ninebutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ninebutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ninebutton.Location = new System.Drawing.Point(153, 52);
            this.Ninebutton.Name = "Ninebutton";
            this.Ninebutton.Size = new System.Drawing.Size(69, 43);
            this.Ninebutton.TabIndex = 2;
            this.Ninebutton.Tag = "9";
            this.Ninebutton.Text = "9";
            this.Ninebutton.UseVisualStyleBackColor = false;
            this.Ninebutton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EightButton.Location = new System.Drawing.Point(78, 52);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(69, 43);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SevenButton.Location = new System.Drawing.Point(3, 52);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(69, 43);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculatorTableLayoutPanel.SetColumnSpan(this.ResultLabel, 4);
            this.ResultLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(3, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(296, 49);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Clearbutton
            // 
            this.Clearbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clearbutton.BackColor = System.Drawing.Color.Gold;
            this.Clearbutton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clearbutton.Location = new System.Drawing.Point(228, 101);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(71, 43);
            this.Clearbutton.TabIndex = 13;
            this.Clearbutton.Tag = "clear";
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            // 
            // pointbutton
            // 
            this.pointbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pointbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.pointbutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointbutton.Location = new System.Drawing.Point(153, 199);
            this.pointbutton.Name = "pointbutton";
            this.pointbutton.Size = new System.Drawing.Size(69, 44);
            this.pointbutton.TabIndex = 14;
            this.pointbutton.Tag = ".";
            this.pointbutton.Text = ".";
            this.pointbutton.UseVisualStyleBackColor = false;
            // 
            // backbutton
            // 
            this.backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.backbutton.BackgroundImage = global::COMP123_S019_Lesson9B.Properties.Resources.backbutton;
            this.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbutton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbutton.Location = new System.Drawing.Point(228, 52);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(71, 43);
            this.backbutton.TabIndex = 15;
            this.backbutton.Tag = "back";
            this.backbutton.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatorTableLayoutPanel);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.CalculatorTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPanel;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Button Zerobutton;
        private System.Windows.Forms.Button Threebutton;
        private System.Windows.Forms.Button Twobutton;
        private System.Windows.Forms.Button Onebutton;
        private System.Windows.Forms.Button Sixbutton;
        private System.Windows.Forms.Button Fivebutton;
        private System.Windows.Forms.Button Fourbutton;
        private System.Windows.Forms.Button Ninebutton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button pointbutton;
        private System.Windows.Forms.Button backbutton;
    }
}

