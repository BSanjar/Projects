using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NewtonMethod
{
    class NewtonMethod
    {
        public decimal x_result { get; set; }
        public decimal f_result { get; set; }
        public decimal df_result { get; set; }
        public decimal iter_result { get; set; }
        public int time_result { get; set; }
        public decimal tol_result { get; set; }
        public int cond_result { get; set; }  

        Computer f_parser;
        Derivative df_parser;
        public decimal Fx(string F, decimal v)
        {
            f_parser = new Computer();
            return f_parser.Compute(F, v);      
        }
        public string Fd(string F)
        {
            df_parser = new Derivative();
            return df_parser.ReturnDerivative(F);
        }

        public decimal Calculate(ComboBox func_text, TextBox x_text, TextBox tol_text, TextBox maxiter_text, TextBox maxtime_text, ProgressBar pb,TextBox Der)
        {
            Stopwatch stopwatch = new Stopwatch();
            int iter;
            string FD_text;
            decimal x, xn;
            decimal f, fd;

            int cond=0; //cond=1: Остановка по времени, cond=2; Остановка по итерации, cond=3: Решения найдена с заданной точностью, cond=4: деление на ноль

            x = Convert.ToDecimal(x_text.Text);
            string F_text = func_text.Text;
            
            decimal Tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            int max_iter = Convert.ToInt16(maxiter_text.Text);
            int max_iter2 = max_iter;
            int max_time = Convert.ToInt16(maxtime_text.Text);
            int max_time2 = max_time;           
            decimal tol2 = 0;
            pb.Value = 0;
            FD_text = Fd(F_text);           
            decimal h;
            xn = x;
            f = Fx(F_text, xn);
            fd = Fx(FD_text, xn);
            h = (f / fd);
            x = xn - h;
            decimal g=0;            
            iter = 0;
            stopwatch.Start();
            bool t28 = true;
            string str2 = Tol.ToString();
            if(str2.Length>29)
            if (str2[29] == '0')
                t28 = false;
            while (cond==0)
            {   
                xn = Convert.ToDecimal(x);
                f = Convert.ToDecimal(Fx(F_text, xn));
                fd = Convert.ToDecimal(Fx(FD_text, xn));

                if (Math.Abs(fd) <= Tol)
                { 
                    stopwatch.Stop();
                    cond = 4;
                    //break;
                }
                else
                {
                    h = Convert.ToDecimal((f / fd));
                    x = Convert.ToDecimal(xn - h);
                    iter++;
                    pb.Maximum = iter + 1;
                    pb.Value = iter;
                    
                    if (max_time <= Convert.ToInt16(stopwatch.ElapsedMilliseconds)) //Проверка на время
                    {
                        stopwatch.Stop();
                        pb.Value = pb.Maximum;

                        DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            tol2 = Math.Abs(xn - x);
                            cond = 1;
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            max_time += max_time2;
                            maxtime_text.Text = max_time.ToString();
                            stopwatch.Start();
                        }
                    }

                    if (iter >= max_iter) //проверка на итерацию
                    {
                        stopwatch.Stop();
                        DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            tol2 = Math.Abs(xn - x);
                            cond = 2;
                        }
                        else if (dr == DialogResult.Yes)
                        {
                            max_iter = max_iter + max_iter2;
                            pb.Value = pb.Maximum;
                            maxiter_text.Text = (max_iter).ToString();
                            stopwatch.Start();
                        }
                    }
                }

                if (Convert.ToDecimal(Math.Abs(xn - x)) <= Tol && t28)
                {
                    cond = 3;
                    tol2 = Math.Abs(xn - x);
                }              
            }
             
            
            stopwatch.Stop();
            cond_result = cond;
            Der.Text = FD_text;
            f_result = Fx(F_text, x);
            df_result = Fx(FD_text, x);           
            tol_result = tol2;           
            iter_result = iter;
            time_result = Convert.ToInt16(stopwatch.ElapsedMilliseconds);            
            pb.Value = pb.Maximum;
            pb.Visible = false;
            return x;
        }
    }
}
