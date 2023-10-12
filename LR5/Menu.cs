using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR5
{
    public partial class Menu : Form
    {
        //Кнопка виходу
        public Menu()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.SaddleBrown;
            ExitButton.ForeColor = Color.Cornsilk;
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

        //Вік
        private void AgeBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgeForm ageForm = new AgeForm();
            ageForm.Show();
        }

        //Таблиця множення
        private void MultBut_Click(object sender, EventArgs e)
        {

            this.Hide();
            MultiplierForm multForm = new MultiplierForm();
            multForm.Show();
        }

        //Калькулятор
        private void CalcBut_Click(object sender, EventArgs e)
        {

            this.Hide();
            CalculatorForm calcForm = new CalculatorForm();
            calcForm.Show();
        }
    }
}
