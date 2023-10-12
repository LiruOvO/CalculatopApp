namespace LR5
{
    partial class MultiplierForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TableBuildButton = new System.Windows.Forms.Button();
            this.Multiplier2 = new System.Windows.Forms.TextBox();
            this.Multiplier1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MultTable = new System.Windows.Forms.ListView();
            this.Mult1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mult2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Res = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackBtn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.TableBuildButton);
            this.groupBox1.Controls.Add(this.Multiplier2);
            this.groupBox1.Controls.Add(this.Multiplier1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MultTable);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(25, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 720);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Табличка множення ";
            // 
            // TableBuildButton
            // 
            this.TableBuildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TableBuildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableBuildButton.Location = new System.Drawing.Point(198, 160);
            this.TableBuildButton.Name = "TableBuildButton";
            this.TableBuildButton.Size = new System.Drawing.Size(143, 44);
            this.TableBuildButton.TabIndex = 10;
            this.TableBuildButton.Text = "Побудувати";
            this.TableBuildButton.UseVisualStyleBackColor = true;
            this.TableBuildButton.Click += new System.EventHandler(this.TableBuildButton_Click);
            // 
            // Multiplier2
            // 
            this.Multiplier2.Location = new System.Drawing.Point(273, 82);
            this.Multiplier2.Name = "Multiplier2";
            this.Multiplier2.Size = new System.Drawing.Size(100, 31);
            this.Multiplier2.TabIndex = 9;
            // 
            // Multiplier1
            // 
            this.Multiplier1.Location = new System.Drawing.Point(273, 35);
            this.Multiplier1.Name = "Multiplier1";
            this.Multiplier1.Size = new System.Drawing.Size(100, 31);
            this.Multiplier1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Множити від 0 до:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Множник:";
            // 
            // MultTable
            // 
            this.MultTable.BackColor = System.Drawing.Color.Linen;
            this.MultTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mult1,
            this.Mult2,
            this.Res});
            this.MultTable.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MultTable.HideSelection = false;
            this.MultTable.Location = new System.Drawing.Point(6, 233);
            this.MultTable.Name = "MultTable";
            this.MultTable.Size = new System.Drawing.Size(534, 481);
            this.MultTable.TabIndex = 0;
            this.MultTable.UseCompatibleStateImageBehavior = false;
            this.MultTable.View = System.Windows.Forms.View.Details;
            // 
            // Mult1
            // 
            this.Mult1.Text = "Множник 1";
            this.Mult1.Width = 178;
            // 
            // Mult2
            // 
            this.Mult2.Text = "Множник 2";
            this.Mult2.Width = 178;
            // 
            // Res
            // 
            this.Res.Text = "Добуток";
            this.Res.Width = 178;
            // 
            // BackBtn
            // 
            this.BackBtn.AutoSize = true;
            this.BackBtn.BackColor = System.Drawing.Color.Sienna;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(21, 9);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(46, 21);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            this.BackBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackBtn_MouseDown);
            this.BackBtn.MouseEnter += new System.EventHandler(this.BackBtn_MouseEnter);
            this.BackBtn.MouseLeave += new System.EventHandler(this.BackBtn_MouseLeave);
            // 
            // MultiplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 800);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TableBuildButton;
        private System.Windows.Forms.TextBox Multiplier2;
        private System.Windows.Forms.TextBox Multiplier1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView MultTable;
        private System.Windows.Forms.ColumnHeader Mult1;
        private System.Windows.Forms.ColumnHeader Mult2;
        private System.Windows.Forms.ColumnHeader Res;
        private System.Windows.Forms.Label BackBtn;
    }
}