using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace GSSM
{
    class GoldenSearch
    {
        public decimal tol_res { get; set; }
        public decimal x_res { get; set; }
        public decimal f_res { get; set; }
        public decimal iter_res { get; set; }
        public decimal time_res { get; set; }
        public int cond_res { get; set; }
        private string func;
        
        Computer parser = new Computer();
        private decimal f(decimal x)
        {
            return parser.Compute(func, x);
        }
               
        public decimal FindOptimum(ComboBox func_text, TextBox a_text, TextBox b_text,TextBox tol_text,TextBox max_iter_text,TextBox max_time_text, ProgressBar pb)
        {
            decimal a=0,b=0,r = 0;
            decimal x1 = 0, x2 = 0;
            decimal F1 = 0, F2 = 0;
            int max_iter, max_iter2;
            int max_time, max_time2;
            int iter = 0;
            int cond = 0;

            decimal tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            a = Convert.ToDecimal(a_text.Text);
            b = Convert.ToDecimal(b_text.Text);
            func = func_text.Text;
            Stopwatch stopwatch = new Stopwatch();
            max_iter2 = max_iter = Convert.ToInt32(max_iter_text.Text);
            max_time2 = max_time = Convert.ToInt32(max_time_text.Text);

            pb.Value = 0;
            stopwatch.Start();
            r = (decimal)((Math.Sqrt(5)-1) / 2);
            x1 = a + (1 - r) * (b - a);
            F1 = f(x1);
            x2 = a + r * (b - a);
            F2 = f(x2);

                while (cond == 0)
                {
                    iter++;
                    if (Math.Abs(b - a) <= tol)
                    {
                        stopwatch.Stop();
                        cond = 3;
                        pb.Value = pb.Maximum;
                    }
                    else
                    {
                        if (F1 > F2)
                        {
                            a = x1;
                            x1 = x2;
                            F1 = F2;
                            x2 = a + r * (b - a);
                            F2 = f(x2);
                            pb.Value = iter;
                        }
                        else
                        {
                            b = x2;
                            x2 = x1;
                            F2 = F1;
                            x1 = a + (1 - r) * (b - a);
                            F1 = f(x1);
                            pb.Value = iter;
                        }
                        if (max_time <= Convert.ToInt16(stopwatch.ElapsedMilliseconds)) //Проверка на время
                        {
                            stopwatch.Stop();
                            pb.Value = pb.Maximum;

                            DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {

                                cond = 1;
                            }
                            else if (dr == DialogResult.Yes)
                            {
                                max_time += max_time2;
                                max_time_text.Text = max_time.ToString();
                                pb.Maximum = max_iter + 1;
                                stopwatch.Start();
                            }
                        }

                        if (iter >= max_iter) //проверка на итерацию
                        {
                            stopwatch.Stop();
                            pb.Value = pb.Maximum;
                            DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                cond = 2;
                            }
                            else if (dr == DialogResult.Yes)
                            {
                                max_iter = max_iter + max_iter2;
                                pb.Maximum = max_iter + 1;
                                max_iter_text.Text = (max_iter).ToString();
                                stopwatch.Start();
                            }
                        }
                    }
                }
            
            stopwatch.Stop();
            tol_res = Math.Abs(b - a);
            cond_res = cond;
            iter_res = iter;
            time_res = stopwatch.ElapsedMilliseconds;
            f_res = F2;
            pb.Visible = false;
            stopwatch.Reset();
            return x1;   
        }
    }
}
