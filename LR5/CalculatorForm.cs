using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR5
{
    public partial class CalculatorForm : Form
    {
        public double firstNumInfo;
        public double numInfo;
        public CalculatorForm()
        {
            InitializeComponent();            
        }
        //Кнопка виходу
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
        //Кнопка повернення в меню
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


        //Введення цифри
        private void Btn1_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            NumInfo.Text += "0";
        }

        //Виконання дій
        private void PlusBtn_Click(object sender, EventArgs e)
        {                        
            Double.TryParse(NumInfo.Text, out numInfo);
            if (Sign.Text == "" || Sign.Text == "+")
            {                   
                firstNumInfo += numInfo;                
            }else if(Sign.Text == "-")
            {
                firstNumInfo -= numInfo;                
            }
            else if (Sign.Text == "/")
            {
                firstNumInfo /= numInfo;
            }
            else if (Sign.Text == "*")
            {
                firstNumInfo *= numInfo;
            }
            FirstNumInfo.Text = Convert.ToString(firstNumInfo);
            NumInfo.Text = "";
            Sign.Text = "+";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {

            Double.TryParse(NumInfo.Text, out numInfo);
            if (Sign.Text == "" || Sign.Text == "+")
            {
                firstNumInfo += numInfo;
            }
            else if (Sign.Text == "-")
            {
                firstNumInfo -= numInfo;
            }
            else if (Sign.Text == "/")
            {
                firstNumInfo /= numInfo;
            }
            else if (Sign.Text == "*")
            {
                firstNumInfo *= numInfo;
            }
            FirstNumInfo.Text = Convert.ToString(firstNumInfo);
            NumInfo.Text = "";
            Sign.Text = "-";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            Double.TryParse(NumInfo.Text, out numInfo);
            if (Sign.Text == "" || Sign.Text == "+")
            {
                firstNumInfo += numInfo;
            }
            else if (Sign.Text == "-")
            {
                firstNumInfo -= numInfo;
            }
            else if (Sign.Text == "/")
            {
                firstNumInfo /= numInfo;
            }
            else if (Sign.Text == "*")
            {
                firstNumInfo *= numInfo;
            }
            FirstNumInfo.Text = Convert.ToString(firstNumInfo);
            NumInfo.Text = "";
            Sign.Text = "/";
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            Double.TryParse(NumInfo.Text, out numInfo);
            if (Sign.Text == "" || Sign.Text == "+")
            {
                firstNumInfo += numInfo;
            }
            else if (Sign.Text == "-")
            {
                firstNumInfo -= numInfo;
            }
            else if (Sign.Text == "/")
            {
                firstNumInfo /= numInfo;
            }
            else if (Sign.Text == "*")
            {
                firstNumInfo *= numInfo;
            }
            FirstNumInfo.Text = Convert.ToString(firstNumInfo);
            NumInfo.Text = "";
            Sign.Text = "*";
        }

        //Вивід результату
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Double.TryParse(NumInfo.Text, out numInfo);
            if (Sign.Text == "" || Sign.Text == "+")
            {
                NumInfo.Text = Convert.ToString(firstNumInfo += numInfo);
            }
            else if (Sign.Text == "-")
            {
                NumInfo.Text = Convert.ToString(firstNumInfo -= numInfo);
            }
            else if (Sign.Text == "/")
            {
                NumInfo.Text = Convert.ToString(firstNumInfo /= numInfo);
            }
            else if (Sign.Text == "*")
            {
                NumInfo.Text = Convert.ToString(firstNumInfo *= numInfo);
            }
            FirstNumInfo.Text = "";            
            Sign.Text = "";
            firstNumInfo = 0;

        }

        //Кнопка очищення екрану
        private void button1_Click(object sender, EventArgs e)
        {
            FirstNumInfo.Text = "";
            NumInfo.Text = "";
            firstNumInfo = 0;
            numInfo = 0;
            Sign.Text = "";
        }

        //Кнопка видалення введеної цифри
        private void button2_Click(object sender, EventArgs e)
        {
            NumInfo.Text = NumInfo.Text.Substring(0, NumInfo.Text.Length - 1);            
        }
    }
}
