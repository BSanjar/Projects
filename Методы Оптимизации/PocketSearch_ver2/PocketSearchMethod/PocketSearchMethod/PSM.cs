using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace PocketSearchMethod
{
    class PSM
    {
        public decimal tol_res { get; set; }
        public decimal x_res { get; set; }
        public decimal f_res { get; set; }
        public int iter_res { get; set; }
        public long time_res { get; set; }
        public int cond_res { get; set; }
        private string func;

        Computer parser = new Computer();
        private decimal f(decimal x)
        {
            return parser.Compute(func, x);
        }

        public decimal FindOptimum(ComboBox func_text, TextBox x_text, TextBox h_text, TextBox r_text, TextBox tol_text, TextBox maxiter_text, TextBox maxtime_text, ProgressBar pb)
        {
            decimal x0, h0, R, tol;
            decimal YF0, YF1;
            decimal x1, h1;
            int max_iter, max_iter2;
            int max_time, max_time2;
            int iter = 0;
            int cond = 0;

            Stopwatch stopwatch = new Stopwatch();
            func = func_text.Text;
            x0 = Convert.ToDecimal(x_text.Text);
            h0 = Convert.ToDecimal(h_text.Text);
            R = Convert.ToDecimal(r_text.Text);
            tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            max_iter = Convert.ToInt32(maxiter_text.Text);
            max_time = Convert.ToInt32(maxtime_text.Text);
            max_iter2 = max_iter;
            max_time2 = max_time;
            stopwatch.Start();
            pb.Value = 0;
            YF0 = f(x0);
            h1 = h0;
            x1 = x0 + h1;
            YF1 = f(x1);
            string str = "";

            //В первой версии здесь была ошибка
            while (cond == 0)
            {
                iter++;
                pb.Value = iter;  
                
                if (Math.Abs(h0) <= tol / R)
                {
                    h1 = h0; x1 = x0; YF1 = YF0;                   
                }
                else
                {
                    x1 = x0 + h1;
                    YF1 = f(x1);
                    if (YF1 >= YF0)
                    {
                        h1 = -(h0) / R;                        
                    }
                    else
                    {
                        h1 = h0;
                    }
                    x0 = x1;
                    YF0 = YF1;
                    h0 = h1;                    
                }

                if (Math.Abs(h0) <= tol)
                    cond = 3;
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
                        maxtime_text.Text = max_time.ToString();
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
                        maxiter_text.Text = (max_iter).ToString();
                        stopwatch.Start();
                    }
                }                           
            }
            stopwatch.Stop();
           
            tol_res = Math.Abs(h1);
           
           
          
            cond_res = cond;
            iter_res = iter;
            time_res = stopwatch.ElapsedMilliseconds;
            f_res = YF1;
            pb.Visible = false;
            stopwatch.Reset();
            return x1;
        }
    }
}
