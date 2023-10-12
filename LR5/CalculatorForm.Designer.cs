namespace LR5
{
    partial class CalculatorForm
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
            this.ExitButton = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn0 = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FirstNumInfo = new System.Windows.Forms.Label();
            this.NumInfo = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.Sienna;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(568, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 21);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.BackColor = System.Drawing.Color.Sienna;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(12, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(46, 21);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseDown);
            this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
            this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.DelBtn);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 743);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Btn0);
            this.panel3.Controls.Add(this.MultiplicationBtn);
            this.panel3.Controls.Add(this.Btn1);
            this.panel3.Controls.Add(this.DivisionBtn);
            this.panel3.Controls.Add(this.Btn9);
            this.panel3.Controls.Add(this.Btn8);
            this.panel3.Controls.Add(this.Btn7);
            this.panel3.Controls.Add(this.MinusBtn);
            this.panel3.Controls.Add(this.Btn6);
            this.panel3.Controls.Add(this.Btn5);
            this.panel3.Controls.Add(this.Btn4);
            this.panel3.Controls.Add(this.PlusBtn);
            this.panel3.Controls.Add(this.Btn3);
            this.panel3.Controls.Add(this.Btn2);
            this.panel3.Controls.Add(this.EnterBtn);
            this.panel3.Location = new System.Drawing.Point(57, 184);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 454);
            this.panel3.TabIndex = 13;
            // 
            // Btn0
            // 
            this.Btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn0.FlatAppearance.BorderSize = 3;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn0.Location = new System.Drawing.Point(30, 348);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(76, 76);
            this.Btn0.TabIndex = 16;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiplicationBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.MultiplicationBtn.FlatAppearance.BorderSize = 3;
            this.MultiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplicationBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.MultiplicationBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MultiplicationBtn.Location = new System.Drawing.Point(348, 348);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(76, 76);
            this.MultiplicationBtn.TabIndex = 15;
            this.MultiplicationBtn.Text = "*";
            this.MultiplicationBtn.UseVisualStyleBackColor = true;
            this.MultiplicationBtn.Click += new System.EventHandler(this.MultiplicationBtn_Click);
            // 
            // Btn1
            // 
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn1.FlatAppearance.BorderSize = 3;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn1.Location = new System.Drawing.Point(30, 30);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(76, 76);
            this.Btn1.TabIndex = 12;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivisionBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DivisionBtn.FlatAppearance.BorderSize = 3;
            this.DivisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivisionBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.DivisionBtn.Location = new System.Drawing.Point(348, 242);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(76, 76);
            this.DivisionBtn.TabIndex = 11;
            this.DivisionBtn.Text = "/";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // Btn9
            // 
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn9.FlatAppearance.BorderSize = 3;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn9.Location = new System.Drawing.Point(240, 242);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(76, 76);
            this.Btn9.TabIndex = 10;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn8.FlatAppearance.BorderSize = 3;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn8.Location = new System.Drawing.Point(135, 242);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(76, 76);
            this.Btn8.TabIndex = 9;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn7.FlatAppearance.BorderSize = 3;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn7.Location = new System.Drawing.Point(30, 242);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(76, 76);
            this.Btn7.TabIndex = 8;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.MinusBtn.FlatAppearance.BorderSize = 3;
            this.MinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.MinusBtn.Location = new System.Drawing.Point(348, 136);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(76, 76);
            this.MinusBtn.TabIndex = 7;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // Btn6
            // 
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn6.FlatAppearance.BorderSize = 3;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn6.Location = new System.Drawing.Point(240, 136);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(76, 76);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn5.FlatAppearance.BorderSize = 3;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn5.Location = new System.Drawing.Point(135, 136);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(76, 76);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn4.FlatAppearance.BorderSize = 3;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn4.Location = new System.Drawing.Point(30, 136);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(76, 76);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.PlusBtn.FlatAppearance.BorderSize = 3;
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.PlusBtn.Location = new System.Drawing.Point(348, 30);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(76, 76);
            this.PlusBtn.TabIndex = 3;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // Btn3
            // 
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn3.FlatAppearance.BorderSize = 3;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn3.Location = new System.Drawing.Point(240, 30);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(76, 76);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn2.FlatAppearance.BorderSize = 3;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Btn2.Location = new System.Drawing.Point(135, 30);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(76, 76);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.EnterBtn.FlatAppearance.BorderSize = 3;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.EnterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EnterBtn.Location = new System.Drawing.Point(135, 348);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(181, 76);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Equal";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Sign);
            this.panel2.Controls.Add(this.FirstNumInfo);
            this.panel2.Controls.Add(this.NumInfo);
            this.panel2.Location = new System.Drawing.Point(23, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 115);
            this.panel2.TabIndex = 0;
            // 
            // FirstNumInfo
            // 
            this.FirstNumInfo.AutoSize = true;
            this.FirstNumInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold);
            this.FirstNumInfo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FirstNumInfo.Location = new System.Drawing.Point(4, 44);
            this.FirstNumInfo.Name = "FirstNumInfo";
            this.FirstNumInfo.Size = new System.Drawing.Size(0, 25);
            this.FirstNumInfo.TabIndex = 1;
            // 
            // NumInfo
            // 
            this.NumInfo.AutoSize = true;
            this.NumInfo.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.NumInfo.Location = new System.Drawing.Point(3, 78);
            this.NumInfo.Name = "NumInfo";
            this.NumInfo.Size = new System.Drawing.Size(0, 36);
            this.NumInfo.TabIndex = 0;
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.Sign.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Sign.Location = new System.Drawing.Point(487, 32);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(0, 36);
            this.Sign.TabIndex = 2;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ClearBtn.FlatAppearance.BorderSize = 3;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.Location = new System.Drawing.Point(483, 145);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(28, 26);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "C";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.DelBtn.FlatAppearance.BorderSize = 3;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 6F, System.Drawing.FontStyle.Bold);
            this.DelBtn.Location = new System.Drawing.Point(517, 146);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(28, 26);
            this.DelBtn.TabIndex = 17;
            this.DelBtn.Text = "<-";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(227, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calculator";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label BackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Label NumInfo;
        private System.Windows.Forms.Label FirstNumInfo;
        private System.Windows.Forms.Label Sign;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label label1;
    }
}