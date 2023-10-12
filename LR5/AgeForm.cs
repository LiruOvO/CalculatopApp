using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR5
{    
    public partial class AgeForm : Form
    {        
        public AgeForm()
        {
            InitializeComponent();
        }

        //Кнопка виходу
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.SaddleBrown;
            ExitButton.ForeColor = Color.Cornsilk;            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Sienna;
            ExitButton.ForeColor = Color.White;
        }

        private void ExitButton_MouseDown(object sender, MouseEventArgs e)
        {
            ExitButton.BackColor = Color.Peru;
            ExitButton.ForeColor = Color.SaddleBrown;
        }
        //Кнопка повернення
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.Show();
        }
        private void BackBtn_MouseEnter(object sender, EventArgs e)
        {
            BackBtn.BackColor = Color.SaddleBrown;
            BackBtn.ForeColor = Color.Cornsilk;
        }
        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.BackColor = Color.Sienna;
            BackBtn.ForeColor = Color.White;
        }

        private void BackBtn_MouseDown(object sender, MouseEventArgs e)
        {
            BackBtn.BackColor = Color.Peru;
            BackBtn.ForeColor = Color.SaddleBrown;
        }


        //Вивід категорії віку
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            int number;
            int.TryParse(YearsList.Text, out number);
                if (number < 3 && number > 0)
                    YearsOld.Text = "Немовля";
                if (number < 12 && number > 2)
                    YearsOld.Text = "Дитина";
                if (number < 20 && number > 11)
                    YearsOld.Text = "Підліток";
                if (number > 19)
                    YearsOld.Text = "Дорослий";            
        }

    }
}
