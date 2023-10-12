namespace LR5
{
    partial class Menu
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
            this.text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgeBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MultBut = new System.Windows.Forms.Button();
            this.CalcBut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseDown);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Linen;
            this.text.Font = new System.Drawing.Font("Palatino Linotype", 40F, System.Drawing.FontStyle.Bold);
            this.text.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.text.Location = new System.Drawing.Point(81, 22);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(437, 73);
            this.text.TabIndex = 3;
            this.text.Text = "Оберіть опцію";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.text);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 137);
            this.panel1.TabIndex = 4;
            // 
            // AgeBut
            // 
            this.AgeBut.BackColor = System.Drawing.Color.Linen;
            this.AgeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AgeBut.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AgeBut.FlatAppearance.BorderSize = 3;
            this.AgeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgeBut.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold);
            this.AgeBut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AgeBut.Location = new System.Drawing.Point(62, 50);
            this.AgeBut.Name = "AgeBut";
            this.AgeBut.Size = new System.Drawing.Size(456, 80);
            this.AgeBut.TabIndex = 11;
            this.AgeBut.Text = "Ваш вік";
            this.AgeBut.UseVisualStyleBackColor = false;
            this.AgeBut.Click += new System.EventHandler(this.AgeBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.MultBut);
            this.panel2.Controls.Add(this.CalcBut);
            this.panel2.Controls.Add(this.AgeBut);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 539);
            this.panel2.TabIndex = 14;
            // 
            // MultBut
            // 
            this.MultBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultBut.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.MultBut.FlatAppearance.BorderSize = 3;
            this.MultBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultBut.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold);
            this.MultBut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MultBut.Location = new System.Drawing.Point(62, 209);
            this.MultBut.Name = "MultBut";
            this.MultBut.Size = new System.Drawing.Size(456, 80);
            this.MultBut.TabIndex = 15;
            this.MultBut.Text = "Таблиця множення";
            this.MultBut.UseVisualStyleBackColor = false;
            this.MultBut.Click += new System.EventHandler(this.MultBut_Click);
            // 
            // CalcBut
            // 
            this.CalcBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcBut.FlatAppearance.BorderSize = 3;
            this.CalcBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcBut.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold);
            this.CalcBut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.CalcBut.Location = new System.Drawing.Point(62, 368);
            this.CalcBut.Name = "CalcBut";
            this.CalcBut.Size = new System.Drawing.Size(456, 80);
            this.CalcBut.TabIndex = 16;
            this.CalcBut.Text = "Калькулятор";
            this.CalcBut.UseVisualStyleBackColor = false;
            this.CalcBut.Click += new System.EventHandler(this.CalcBut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AgeBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MultBut;
        private System.Windows.Forms.Button CalcBut;
    }
}