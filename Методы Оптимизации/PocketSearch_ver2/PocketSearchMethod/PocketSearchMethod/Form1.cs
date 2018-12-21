using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PocketSearchMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Solve_button_Click(object sender, EventArgs e)
        {
            Message_label.Text = "";
            if (Function_ComboBox.Text == "" || x_TextBox.Text == "" || h_textbox.Text == "" || r_text.Text == "" || Tolerance_TextBox.Text == "" || MAXIteration_TextBox.Text == "" || MAXTime_TextBox.Text == "")
            {
                MessageBox.Show("Не все данные введены!");
            }
            else
            {
                try
                {
                    decimal x = 0;
                    int cond;
                    PB_ProgressBar.Visible = true;
                    PB_ProgressBar.Maximum = Convert.ToInt32(MAXIteration_TextBox.Text) + 1;

                    PSM method = new PSM();
                    x = method.FindOptimum(Function_ComboBox, x_TextBox, h_textbox, r_text, Tolerance_TextBox, MAXIteration_TextBox, MAXTime_TextBox, PB_ProgressBar);

                    cond = method.cond_res;
                    ResultX_TextBox.Text = x.ToString();
                    ResultFunction_TextBox.Text = method.f_res.ToString();
                    ResultIteration_TextBox.Text = method.iter_res.ToString();
                    ABS_TextBox.Text = method.tol_res.ToString("0E0");
                    //if (ABS_TextBox.Text == "0E0")
                    //    ABS_TextBox.Text = "1E-28";    //Здесь была ошибка, в первой версии
                    ResultTime_TextBox.Text = method.time_res.ToString();

                    switch (cond)
                    {
                        case 1:
                            Message_label.Visible = true;
                            Message_label.ForeColor = Color.Red;
                            Message_label.Text = "Результат с заданной точностью не достигнут \n из за лимита времени!";
                            break;
                        case 2:
                            Message_label.Visible = true;
                            Message_label.ForeColor = Color.Red;
                            Message_label.Text = "Результат с заданной точностью не достигнут \n из за лимита итерации!";
                            break;
                        case 3:
                            Message_label.Visible = true;
                            Message_label.ForeColor = Color.Green;
                            Message_label.Text = "Результат с заданной точностью достигнут !";
                            break;
                        default:
                            Message_label.Visible = true;
                            Message_label.ForeColor = Color.Red;
                            Message_label.Text = "Ошибка!";
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Неверно введены начальные значения!");
                    PB_ProgressBar.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Заданная Функция не имеет корня либо введенная функция не корректная!");
                    PB_ProgressBar.Visible = false;
                }
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Message_label.Text = "";
            ResultX_TextBox.Text = "";
            ResultFunction_TextBox.Text = "";
            ResultTime_TextBox.Text = "";
            ResultIteration_TextBox.Text = "";
            ABS_TextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("graf.xlsx");
        }

        private void r_text_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void x_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (x_TextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == '-')
            {
                if (x_TextBox.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
        }

        private void h_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == 'e')
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (h_textbox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void Tolerance_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == 'e')
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            if (e.KeyChar == ',')
            {
                if (h_textbox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void MAXIteration_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void MAXTime_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

