using parserDecimal.Parser;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace NewtonMethodForOptimum
{
    class NewtonMethod
    {
        public decimal x_result { get; set; }
        public decimal f_result { get; set; }
        public decimal df_result { get; set; }
        public decimal df2_result { get; set; }
        public int iter_result { get; set; }
        public int time_result { get; set; }
        public decimal tol_result { get; set; }
        public int cond_result { get; set; }
        public int minmax { get; set; }
        
        Computer f_parser;
        Derivative df_parser;
        public decimal f(string func,decimal v)
        {
            f_parser = new Computer();
            return f_parser.Compute(func, v);
        }
        public string fd(string func)
        {
            df_parser = new Derivative();
            return df_parser.ReturnDerivative(func);
        }

        public decimal Calculate(ComboBox func_text, TextBox x_text, TextBox tol_text, TextBox r_text, TextBox maxiter_text, TextBox maxtime_text, ProgressBar pb,TextBox der,int ln,TextBox der2)
        {
            Stopwatch stopwatch = new Stopwatch();
            int iter=0;
            pb.Value = 0;
            decimal Tol = Decimal.Parse(tol_text.Text, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
            int max_iter = Convert.ToInt16(maxiter_text.Text);
            int max_iter2 = max_iter;
            int max_time = Convert.ToInt16(maxtime_text.Text);
            int max_time2 = max_time;
            decimal x0=0, x1=0;
           
            x0 = Convert.ToDecimal(x_text.Text);
            string func = func_text.Text;
            decimal R = Convert.ToDecimal(r_text.Text);
            decimal Delta;
            stopwatch.Start();
            int cond = 0;                   //cond=1: Остановка по времени, cond=2; Остановка по итерации, cond=3: Решения найдена с заданной точностью, cond=4: деление на ноль
            decimal FX0 = f(func,x0);       /* Objective function at given point */
            string deriv1 = fd(func);
            string deriv2 = fd(deriv1);
            decimal DFX0  = f(deriv1, x0);  /* First derivative of the objective function at given point */
            decimal DDFX0 = f(deriv2,x0);   /* Second derivative of the objective function at given point */
            decimal DFX1 = 0;
            decimal DP=0,DP0=0;
            decimal RelError = 0;
            decimal FX1=0;
            Delta = Tol;
            while (cond == 0)
            {
                iter++;
                pb.Value = iter;
                
                if (ln == 1)
                {
                    if (x1 <= 0 || x0 <= 0)
                    {
                        MessageBox.Show("аргумент при функции ln(x), log(x) или sqrt(x) меньше 0");
                        //cond = 5;
                        return 0;
                    }
                }
                
                    DDFX0 = f(deriv2, x0);       /* Second derivative of the objective function at given point */

                    if (Math.Abs(DDFX0) <= Tol)
                    {
                        cond = 1;
                    }
                    else
                    {
                        DP = DFX0 / DDFX0;
                        if (iter == 1)
                            DP0 = DP;
                        if (Math.Sign(DP0) == Math.Sign(DP))
                            x1 = x0 - DP;
                        else
                            x1 = x0 - DP / R;

                        DP0 = DP;
                        FX1 = f(func, x1);        /* New objective function value */
                        DFX1 = f(deriv1, x1);     /* First derivative of objective function value */
                        RelError = 2 * Math.Abs(DP) / (Math.Abs(x1) + Tol); /* Relative error */

                    
                    if (RelError <= Delta)
                        {
                            if (cond != 1)
                                cond = 2;
                        }
                        else
                        {
                            x0 = x1;
                            DFX0 = DFX1;
                            if (cond == 0)
                            {
                                if (iter >= max_iter) //проверка на итерацию
                                {
                                    stopwatch.Stop();
                                    pb.Value = pb.Maximum;
                                    DialogResult dr = MessageBox.Show("Указанная точность за " + iter + " итераций не достигнута.Продолжить вычисление ? Будет добавлено " + max_iter + " итераций.", "Продолжить вычисления ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr == DialogResult.No)
                                    {
                                        cond = 4;
                                    }
                                    else if (dr == DialogResult.Yes)
                                    {
                                        max_iter = max_iter + max_iter2;
                                        pb.Maximum = max_iter;
                                        maxiter_text.Text = (max_iter).ToString();
                                        stopwatch.Start();
                                    }
                                }

                            if (max_time <= Convert.ToInt16(stopwatch.ElapsedMilliseconds)) //Проверка на время
                            {
                                stopwatch.Stop();
                                pb.Value = pb.Maximum;

                                DialogResult dr = MessageBox.Show("Время вышло. Продолжить вычисление? Будет добавлено " + max_time2 + " миллисекунд", "Продолжить вычисления?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.No)
                                {
                                    cond = 3;
                                }
                                else if (dr == DialogResult.Yes)
                                {
                                    pb.Maximum = max_iter + 1;
                                    max_time += max_time2;
                                    maxtime_text.Text = max_time.ToString();
                                    stopwatch.Start();
                                }
                            }
                        }
                        }
                    }
                }
            
            stopwatch.Stop();
            cond_result = cond;
            der.Text = deriv1;
            der2.Text = deriv2;
            f_result = FX1;
            df_result = DFX1;
            df2_result = DDFX0;
            tol_result = Math.Abs(RelError);
            iter_result = iter;
            time_result = Convert.ToInt16(stopwatch.ElapsedMilliseconds);
            pb.Value = pb.Maximum;
            
            if(cond==2)
            {
                if (f(func, x1 + 1) > FX1)
                    minmax = 0;
                else
                    minmax = 1;                
            }
            //if (f(func, x1 + 2) > f(func, x1) && f(func, x1 - 2) < f(func, x1) || f(func, x1 + 2) < f(func, x1) && f(func, x1 - 2) > f(func, x1))
            //    peregib = 1;

            if (Math.Sign(f(func, x1) - f(func, x1 - Tol)) != Math.Sign(f(func, x1) - f(func, x1 + Tol)))
            {
                MessageBox.Show("Программа наткнулся на точку перегиба, проверьте функцию!");
                //return 0;
                
            }
            pb.Visible = false;
            return x1;
            
        }
    }
}
