namespace NewtonMethodForOptimum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Message_label = new System.Windows.Forms.Label();
            this.Derivative_text = new System.Windows.Forms.TextBox();
            this.Derivative_label = new System.Windows.Forms.Label();
            this.DerivativeFunction_TextBox = new System.Windows.Forms.TextBox();
            this.DerivativFunction_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Solve_button = new System.Windows.Forms.Button();
            this.ABS_TextBox = new System.Windows.Forms.TextBox();
            this.ResultIteration_TextBox = new System.Windows.Forms.TextBox();
            this.ResultTime_TextBox = new System.Windows.Forms.TextBox();
            this.ResultFunction_TextBox = new System.Windows.Forms.TextBox();
            this.ResultX_TextBox = new System.Windows.Forms.TextBox();
            this.ABS_label = new System.Windows.Forms.Label();
            this.ResultIteration_label = new System.Windows.Forms.Label();
            this.ResultTime_label = new System.Windows.Forms.Label();
            this.ResultFunction_label = new System.Windows.Forms.Label();
            this.ResultX_label = new System.Windows.Forms.Label();
            this.PB_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Res_label = new System.Windows.Forms.Label();
            this.Function_ComboBox = new System.Windows.Forms.ComboBox();
            this.MAXTime_TextBox = new System.Windows.Forms.TextBox();
            this.MAXIteration_TextBox = new System.Windows.Forms.TextBox();
            this.Tolerance_TextBox = new System.Windows.Forms.TextBox();
            this.A_TextBox = new System.Windows.Forms.TextBox();
            this.MAXTime_label = new System.Windows.Forms.Label();
            this.MAXIteration_label = new System.Windows.Forms.Label();
            this.Tolerance_label = new System.Windows.Forms.Label();
            this.A_label = new System.Windows.Forms.Label();
            this.Function_label = new System.Windows.Forms.Label();
            this.R_text = new System.Windows.Forms.TextBox();
            this.R_label = new System.Windows.Forms.Label();
            this.Derive2_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deriv2_res = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Location = new System.Drawing.Point(129, 390);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(0, 13);
            this.Message_label.TabIndex = 178;
            this.Message_label.Visible = false;
            // 
            // Derivative_text
            // 
            this.Derivative_text.Enabled = false;
            this.Derivative_text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Derivative_text.Location = new System.Drawing.Point(207, 66);
            this.Derivative_text.Name = "Derivative_text";
            this.Derivative_text.Size = new System.Drawing.Size(372, 26);
            this.Derivative_text.TabIndex = 177;
            // 
            // Derivative_label
            // 
            this.Derivative_label.AutoSize = true;
            this.Derivative_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Derivative_label.Location = new System.Drawing.Point(47, 66);
            this.Derivative_label.Name = "Derivative_label";
            this.Derivative_label.Size = new System.Drawing.Size(111, 19);
            this.Derivative_label.TabIndex = 176;
            this.Derivative_label.Text = "Производная:";
            // 
            // DerivativeFunction_TextBox
            // 
            this.DerivativeFunction_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DerivativeFunction_TextBox.Location = new System.Drawing.Point(207, 492);
            this.DerivativeFunction_TextBox.Name = "DerivativeFunction_TextBox";
            this.DerivativeFunction_TextBox.ReadOnly = true;
            this.DerivativeFunction_TextBox.Size = new System.Drawing.Size(217, 26);
            this.DerivativeFunction_TextBox.TabIndex = 175;
            this.DerivativeFunction_TextBox.Text = "f\'(x*)";
            // 
            // DerivativFunction_label
            // 
            this.DerivativFunction_label.AutoSize = true;
            this.DerivativFunction_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DerivativFunction_label.Location = new System.Drawing.Point(46, 494);
            this.DerivativFunction_label.Name = "DerivativFunction_label";
            this.DerivativFunction_label.Size = new System.Drawing.Size(111, 19);
            this.DerivativFunction_label.TabIndex = 174;
            this.DerivativFunction_label.Text = "Производная:";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clear_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear_button.Location = new System.Drawing.Point(323, 595);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(100, 58);
            this.Clear_button.TabIndex = 172;
            this.Clear_button.Text = "Сброс";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Solve_button
            // 
            this.Solve_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Solve_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solve_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Solve_button.Location = new System.Drawing.Point(206, 314);
            this.Solve_button.Name = "Solve_button";
            this.Solve_button.Size = new System.Drawing.Size(217, 39);
            this.Solve_button.TabIndex = 171;
            this.Solve_button.Text = "Поиск";
            this.Solve_button.UseVisualStyleBackColor = false;
            this.Solve_button.Click += new System.EventHandler(this.Solve_button_Click);
            // 
            // ABS_TextBox
            // 
            this.ABS_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_TextBox.Location = new System.Drawing.Point(206, 627);
            this.ABS_TextBox.Name = "ABS_TextBox";
            this.ABS_TextBox.ReadOnly = true;
            this.ABS_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ABS_TextBox.TabIndex = 170;
            this.ABS_TextBox.Text = "Tol";
            // 
            // ResultIteration_TextBox
            // 
            this.ResultIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_TextBox.Location = new System.Drawing.Point(206, 595);
            this.ResultIteration_TextBox.Name = "ResultIteration_TextBox";
            this.ResultIteration_TextBox.ReadOnly = true;
            this.ResultIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultIteration_TextBox.TabIndex = 169;
            this.ResultIteration_TextBox.Text = "iter";
            // 
            // ResultTime_TextBox
            // 
            this.ResultTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_TextBox.Location = new System.Drawing.Point(206, 563);
            this.ResultTime_TextBox.Name = "ResultTime_TextBox";
            this.ResultTime_TextBox.ReadOnly = true;
            this.ResultTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultTime_TextBox.TabIndex = 168;
            this.ResultTime_TextBox.Text = "ElapsedTime";
            // 
            // ResultFunction_TextBox
            // 
            this.ResultFunction_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_TextBox.Location = new System.Drawing.Point(207, 460);
            this.ResultFunction_TextBox.Name = "ResultFunction_TextBox";
            this.ResultFunction_TextBox.ReadOnly = true;
            this.ResultFunction_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultFunction_TextBox.TabIndex = 167;
            this.ResultFunction_TextBox.Text = "f(x*)";
            // 
            // ResultX_TextBox
            // 
            this.ResultX_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_TextBox.Location = new System.Drawing.Point(207, 428);
            this.ResultX_TextBox.Name = "ResultX_TextBox";
            this.ResultX_TextBox.ReadOnly = true;
            this.ResultX_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultX_TextBox.TabIndex = 166;
            this.ResultX_TextBox.Text = "x*";
            // 
            // ABS_label
            // 
            this.ABS_label.AutoSize = true;
            this.ABS_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_label.Location = new System.Drawing.Point(45, 629);
            this.ABS_label.Name = "ABS_label";
            this.ABS_label.Size = new System.Drawing.Size(95, 19);
            this.ABS_label.TabIndex = 165;
            this.ABS_label.Text = "Abs (xn- x):";
            // 
            // ResultIteration_label
            // 
            this.ResultIteration_label.AutoSize = true;
            this.ResultIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_label.Location = new System.Drawing.Point(46, 597);
            this.ResultIteration_label.Name = "ResultIteration_label";
            this.ResultIteration_label.Size = new System.Drawing.Size(145, 19);
            this.ResultIteration_label.TabIndex = 164;
            this.ResultIteration_label.Text = "Количество итер.:";
            // 
            // ResultTime_label
            // 
            this.ResultTime_label.AutoSize = true;
            this.ResultTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_label.Location = new System.Drawing.Point(45, 565);
            this.ResultTime_label.Name = "ResultTime_label";
            this.ResultTime_label.Size = new System.Drawing.Size(109, 19);
            this.ResultTime_label.TabIndex = 163;
            this.ResultTime_label.Text = "Время (мсек):";
            // 
            // ResultFunction_label
            // 
            this.ResultFunction_label.AutoSize = true;
            this.ResultFunction_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_label.Location = new System.Drawing.Point(46, 462);
            this.ResultFunction_label.Name = "ResultFunction_label";
            this.ResultFunction_label.Size = new System.Drawing.Size(153, 19);
            this.ResultFunction_label.TabIndex = 162;
            this.ResultFunction_label.Text = "Значение функции:";
            // 
            // ResultX_label
            // 
            this.ResultX_label.AutoSize = true;
            this.ResultX_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_label.Location = new System.Drawing.Point(47, 430);
            this.ResultX_label.Name = "ResultX_label";
            this.ResultX_label.Size = new System.Drawing.Size(59, 19);
            this.ResultX_label.TabIndex = 161;
            this.ResultX_label.Text = "Ответ:";
            // 
            // PB_ProgressBar
            // 
            this.PB_ProgressBar.Location = new System.Drawing.Point(50, 359);
            this.PB_ProgressBar.Name = "PB_ProgressBar";
            this.PB_ProgressBar.Size = new System.Drawing.Size(373, 17);
            this.PB_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_ProgressBar.TabIndex = 173;
            this.PB_ProgressBar.Visible = false;
            // 
            // Res_label
            // 
            this.Res_label.AutoSize = true;
            this.Res_label.Location = new System.Drawing.Point(47, 390);
            this.Res_label.Name = "Res_label";
            this.Res_label.Size = new System.Drawing.Size(62, 13);
            this.Res_label.TabIndex = 160;
            this.Res_label.Text = "Результат:";
            this.Res_label.Visible = false;
            // 
            // Function_ComboBox
            // 
            this.Function_ComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_ComboBox.FormattingEnabled = true;
            this.Function_ComboBox.Items.AddRange(new object[] {
            "-0,04*x^3+x^2+x-1",
            "x^2-4*sin(x)",
            "x^2-exp(x)",
            "(x-2)^2-ln(x)",
            "(x-2)^2-log(x)",
            "1600*(1-exp(-x/5))-160*x",
            "x*exp(-x)",
            "4*x^3-2*x-6",
            "1500*x^3-0,001*exp(2*x)-0,01*exp(z)^2",
            "x^3-5*x^2+x+5",
            "2,0011633987*x^3+3,5*x^2+2,04*x+0,39634285715",
            "2,001633987*x^3+3,5*x^2+2,04*x-0,603658507835433"});
            this.Function_ComboBox.Location = new System.Drawing.Point(210, 34);
            this.Function_ComboBox.Name = "Function_ComboBox";
            this.Function_ComboBox.Size = new System.Drawing.Size(369, 26);
            this.Function_ComboBox.TabIndex = 159;
            this.Function_ComboBox.Text = "x^2-4*sin(x)";
            // 
            // MAXTime_TextBox
            // 
            this.MAXTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_TextBox.Location = new System.Drawing.Point(206, 267);
            this.MAXTime_TextBox.Name = "MAXTime_TextBox";
            this.MAXTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXTime_TextBox.TabIndex = 158;
            this.MAXTime_TextBox.Text = "50";
            this.MAXTime_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXTime_TextBox_KeyPress);
            // 
            // MAXIteration_TextBox
            // 
            this.MAXIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_TextBox.Location = new System.Drawing.Point(206, 235);
            this.MAXIteration_TextBox.Name = "MAXIteration_TextBox";
            this.MAXIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXIteration_TextBox.TabIndex = 157;
            this.MAXIteration_TextBox.Text = "100";
            this.MAXIteration_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXIteration_TextBox_KeyPress);
            // 
            // Tolerance_TextBox
            // 
            this.Tolerance_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_TextBox.Location = new System.Drawing.Point(206, 168);
            this.Tolerance_TextBox.Name = "Tolerance_TextBox";
            this.Tolerance_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Tolerance_TextBox.TabIndex = 156;
            this.Tolerance_TextBox.Text = "1e-15";
            this.Tolerance_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tolerance_TextBox_KeyPress);
            // 
            // A_TextBox
            // 
            this.A_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_TextBox.Location = new System.Drawing.Point(207, 130);
            this.A_TextBox.Name = "A_TextBox";
            this.A_TextBox.Size = new System.Drawing.Size(100, 26);
            this.A_TextBox.TabIndex = 155;
            this.A_TextBox.Text = "3";
            this.A_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.A_TextBox_KeyPress);
            // 
            // MAXTime_label
            // 
            this.MAXTime_label.AutoSize = true;
            this.MAXTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_label.Location = new System.Drawing.Point(46, 269);
            this.MAXTime_label.Name = "MAXTime_label";
            this.MAXTime_label.Size = new System.Drawing.Size(108, 19);
            this.MAXTime_label.TabIndex = 154;
            this.MAXTime_label.Text = "(MAX) Время:";
            // 
            // MAXIteration_label
            // 
            this.MAXIteration_label.AutoSize = true;
            this.MAXIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_label.Location = new System.Drawing.Point(45, 237);
            this.MAXIteration_label.Name = "MAXIteration_label";
            this.MAXIteration_label.Size = new System.Drawing.Size(135, 19);
            this.MAXIteration_label.TabIndex = 153;
            this.MAXIteration_label.Text = "(MAX) Итераций:";
            // 
            // Tolerance_label
            // 
            this.Tolerance_label.AutoSize = true;
            this.Tolerance_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_label.Location = new System.Drawing.Point(45, 170);
            this.Tolerance_label.Name = "Tolerance_label";
            this.Tolerance_label.Size = new System.Drawing.Size(112, 19);
            this.Tolerance_label.TabIndex = 152;
            this.Tolerance_label.Text = "Погрешность:";
            // 
            // A_label
            // 
            this.A_label.AutoSize = true;
            this.A_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_label.Location = new System.Drawing.Point(47, 130);
            this.A_label.Name = "A_label";
            this.A_label.Size = new System.Drawing.Size(32, 19);
            this.A_label.TabIndex = 151;
            this.A_label.Text = "X°:";
            // 
            // Function_label
            // 
            this.Function_label.AutoSize = true;
            this.Function_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_label.Location = new System.Drawing.Point(46, 36);
            this.Function_label.Name = "Function_label";
            this.Function_label.Size = new System.Drawing.Size(78, 19);
            this.Function_label.TabIndex = 150;
            this.Function_label.Text = "Функция:";
            // 
            // R_text
            // 
            this.R_text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R_text.Location = new System.Drawing.Point(206, 203);
            this.R_text.Name = "R_text";
            this.R_text.Size = new System.Drawing.Size(100, 26);
            this.R_text.TabIndex = 182;
            this.R_text.Text = "10";
            this.R_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.R_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R_text_KeyPress);
            // 
            // R_label
            // 
            this.R_label.AutoSize = true;
            this.R_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R_label.Location = new System.Drawing.Point(45, 205);
            this.R_label.Name = "R_label";
            this.R_label.Size = new System.Drawing.Size(19, 19);
            this.R_label.TabIndex = 180;
            this.R_label.Text = "R";
            this.R_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Derive2_text
            // 
            this.Derive2_text.Enabled = false;
            this.Derive2_text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Derive2_text.Location = new System.Drawing.Point(207, 98);
            this.Derive2_text.Name = "Derive2_text";
            this.Derive2_text.Size = new System.Drawing.Size(372, 26);
            this.Derive2_text.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 183;
            this.label1.Text = "Производная_2:";
            // 
            // Deriv2_res
            // 
            this.Deriv2_res.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deriv2_res.Location = new System.Drawing.Point(206, 524);
            this.Deriv2_res.Name = "Deriv2_res";
            this.Deriv2_res.ReadOnly = true;
            this.Deriv2_res.Size = new System.Drawing.Size(217, 26);
            this.Deriv2_res.TabIndex = 186;
            this.Deriv2_res.Text = "f\'\'(x*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 185;
            this.label2.Text = "Производная_2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 666);
            this.Controls.Add(this.Deriv2_res);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Derive2_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R_text);
            this.Controls.Add(this.R_label);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Derivative_text);
            this.Controls.Add(this.Derivative_label);
            this.Controls.Add(this.DerivativeFunction_TextBox);
            this.Controls.Add(this.DerivativFunction_label);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Solve_button);
            this.Controls.Add(this.ABS_TextBox);
            this.Controls.Add(this.ResultIteration_TextBox);
            this.Controls.Add(this.ResultTime_TextBox);
            this.Controls.Add(this.ResultFunction_TextBox);
            this.Controls.Add(this.ResultX_TextBox);
            this.Controls.Add(this.ABS_label);
            this.Controls.Add(this.ResultIteration_label);
            this.Controls.Add(this.ResultTime_label);
            this.Controls.Add(this.ResultFunction_label);
            this.Controls.Add(this.ResultX_label);
            this.Controls.Add(this.PB_ProgressBar);
            this.Controls.Add(this.Res_label);
            this.Controls.Add(this.Function_ComboBox);
            this.Controls.Add(this.MAXTime_TextBox);
            this.Controls.Add(this.MAXIteration_TextBox);
            this.Controls.Add(this.Tolerance_TextBox);
            this.Controls.Add(this.A_TextBox);
            this.Controls.Add(this.MAXTime_label);
            this.Controls.Add(this.MAXIteration_label);
            this.Controls.Add(this.Tolerance_label);
            this.Controls.Add(this.A_label);
            this.Controls.Add(this.Function_label);
            this.Name = "Form1";
            this.Text = "Метод Ньютона для поиска экстремума";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.TextBox Derivative_text;
        private System.Windows.Forms.Label Derivative_label;
        private System.Windows.Forms.TextBox DerivativeFunction_TextBox;
        private System.Windows.Forms.Label DerivativFunction_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Solve_button;
        private System.Windows.Forms.TextBox ABS_TextBox;
        private System.Windows.Forms.TextBox ResultIteration_TextBox;
        private System.Windows.Forms.TextBox ResultTime_TextBox;
        private System.Windows.Forms.TextBox ResultFunction_TextBox;
        private System.Windows.Forms.TextBox ResultX_TextBox;
        private System.Windows.Forms.Label ABS_label;
        private System.Windows.Forms.Label ResultIteration_label;
        private System.Windows.Forms.Label ResultTime_label;
        private System.Windows.Forms.Label ResultFunction_label;
        private System.Windows.Forms.Label ResultX_label;
        private System.Windows.Forms.ProgressBar PB_ProgressBar;
        private System.Windows.Forms.Label Res_label;
        private System.Windows.Forms.ComboBox Function_ComboBox;
        private System.Windows.Forms.TextBox MAXTime_TextBox;
        private System.Windows.Forms.TextBox MAXIteration_TextBox;
        private System.Windows.Forms.TextBox Tolerance_TextBox;
        private System.Windows.Forms.TextBox A_TextBox;
        private System.Windows.Forms.Label MAXTime_label;
        private System.Windows.Forms.Label MAXIteration_label;
        private System.Windows.Forms.Label Tolerance_label;
        private System.Windows.Forms.Label A_label;
        private System.Windows.Forms.Label Function_label;
        private System.Windows.Forms.TextBox R_text;
        private System.Windows.Forms.Label R_label;
        private System.Windows.Forms.TextBox Derive2_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Deriv2_res;
        private System.Windows.Forms.Label label2;
    }
}

