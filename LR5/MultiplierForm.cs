using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR5
{
    public partial class MultiplierForm : Form
    {
        public MultiplierForm()
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


        //Побудова таблиці
        private void TableBuildButton_Click(object sender, EventArgs e)
        {
            MultTable.Items.Clear();
            int mult1, mult2;


            if (int.TryParse(Multiplier1.Text, out mult1) &&
            int.TryParse(Multiplier2.Text, out mult2))
            {
                if (mult2 < 0)
                {
                    for (int i = 0; i >= mult2; i--)
                    {
                        ListViewItem item = new ListViewItem(Multiplier1.Text);
                        item.SubItems.Add(i.ToString());
                        int res = mult1 * i;
                        item.SubItems.Add(res.ToString());
                        MultTable.Items.Add(item);
                    }
                }
                if (mult2 >= 0)
                {
                    for (int i = 0; i <= mult2; i++)
                    {
                        ListViewItem item = new ListViewItem(Multiplier1.Text);
                        item.SubItems.Add(i.ToString());
                        int res = mult1 * i;
                        item.SubItems.Add(res.ToString());
                        MultTable.Items.Add(item);
                    }
                }
            }
        }
    }
}
