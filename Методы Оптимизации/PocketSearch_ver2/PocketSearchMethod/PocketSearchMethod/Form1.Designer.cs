namespace PocketSearchMethod
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
            this.button1 = new System.Windows.Forms.Button();
            this.h_textbox = new System.Windows.Forms.TextBox();
            this.h_label = new System.Windows.Forms.Label();
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
            this.Function_ComboBox = new System.Windows.Forms.ComboBox();
            this.MAXTime_TextBox = new System.Windows.Forms.TextBox();
            this.MAXIteration_TextBox = new System.Windows.Forms.TextBox();
            this.Tolerance_TextBox = new System.Windows.Forms.TextBox();
            this.x_TextBox = new System.Windows.Forms.TextBox();
            this.MAXTime_label = new System.Windows.Forms.Label();
            this.MAXIteration_label = new System.Windows.Forms.Label();
            this.Tolerance_label = new System.Windows.Forms.Label();
            this.x_label = new System.Windows.Forms.Label();
            this.Function_label = new System.Windows.Forms.Label();
            this.r_text = new System.Windows.Forms.TextBox();
            this.r_label = new System.Windows.Forms.Label();
            this.Res_label = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(390, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 58);
            this.button1.TabIndex = 209;
            this.button1.Text = "Посмотреть график";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // h_textbox
            // 
            this.h_textbox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_textbox.Location = new System.Drawing.Point(273, 111);
            this.h_textbox.Name = "h_textbox";
            this.h_textbox.Size = new System.Drawing.Size(100, 26);
            this.h_textbox.TabIndex = 208;
            this.h_textbox.Text = "0,001";
            this.h_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.h_textbox_KeyPress);
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h_label.Location = new System.Drawing.Point(113, 111);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(29, 19);
            this.h_label.TabIndex = 207;
            this.h_label.Text = "H0";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Clear_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Clear_button.Location = new System.Drawing.Point(390, 496);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(100, 58);
            this.Clear_button.TabIndex = 204;
            this.Clear_button.Text = "Сброс";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Solve_button
            // 
            this.Solve_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Solve_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Solve_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Solve_button.Location = new System.Drawing.Point(273, 270);
            this.Solve_button.Name = "Solve_button";
            this.Solve_button.Size = new System.Drawing.Size(217, 39);
            this.Solve_button.TabIndex = 203;
            this.Solve_button.Text = "Поиск";
            this.Solve_button.UseVisualStyleBackColor = false;
            this.Solve_button.Click += new System.EventHandler(this.Solve_button_Click);
            // 
            // ABS_TextBox
            // 
            this.ABS_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_TextBox.Location = new System.Drawing.Point(273, 528);
            this.ABS_TextBox.Name = "ABS_TextBox";
            this.ABS_TextBox.ReadOnly = true;
            this.ABS_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ABS_TextBox.TabIndex = 202;
            this.ABS_TextBox.Text = "Tol";
            // 
            // ResultIteration_TextBox
            // 
            this.ResultIteration_TextBox.Enabled = false;
            this.ResultIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_TextBox.Location = new System.Drawing.Point(273, 496);
            this.ResultIteration_TextBox.Name = "ResultIteration_TextBox";
            this.ResultIteration_TextBox.ReadOnly = true;
            this.ResultIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultIteration_TextBox.TabIndex = 201;
            this.ResultIteration_TextBox.Text = "iter";
            // 
            // ResultTime_TextBox
            // 
            this.ResultTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_TextBox.Location = new System.Drawing.Point(273, 464);
            this.ResultTime_TextBox.Name = "ResultTime_TextBox";
            this.ResultTime_TextBox.ReadOnly = true;
            this.ResultTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.ResultTime_TextBox.TabIndex = 200;
            this.ResultTime_TextBox.Text = "ElapsedTime";
            // 
            // ResultFunction_TextBox
            // 
            this.ResultFunction_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_TextBox.Location = new System.Drawing.Point(273, 432);
            this.ResultFunction_TextBox.Name = "ResultFunction_TextBox";
            this.ResultFunction_TextBox.ReadOnly = true;
            this.ResultFunction_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultFunction_TextBox.TabIndex = 199;
            this.ResultFunction_TextBox.Text = "f(x*)";
            // 
            // ResultX_TextBox
            // 
            this.ResultX_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_TextBox.Location = new System.Drawing.Point(273, 400);
            this.ResultX_TextBox.Name = "ResultX_TextBox";
            this.ResultX_TextBox.ReadOnly = true;
            this.ResultX_TextBox.Size = new System.Drawing.Size(217, 26);
            this.ResultX_TextBox.TabIndex = 198;
            this.ResultX_TextBox.Text = "x*";
            // 
            // ABS_label
            // 
            this.ABS_label.AutoSize = true;
            this.ABS_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABS_label.Location = new System.Drawing.Point(112, 530);
            this.ABS_label.Name = "ABS_label";
            this.ABS_label.Size = new System.Drawing.Size(84, 19);
            this.ABS_label.TabIndex = 197;
            this.ABS_label.Text = "Точность:";
            // 
            // ResultIteration_label
            // 
            this.ResultIteration_label.AutoSize = true;
            this.ResultIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultIteration_label.Location = new System.Drawing.Point(113, 498);
            this.ResultIteration_label.Name = "ResultIteration_label";
            this.ResultIteration_label.Size = new System.Drawing.Size(140, 19);
            this.ResultIteration_label.TabIndex = 196;
            this.ResultIteration_label.Text = "Количество итер:";
            // 
            // ResultTime_label
            // 
            this.ResultTime_label.AutoSize = true;
            this.ResultTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTime_label.Location = new System.Drawing.Point(112, 466);
            this.ResultTime_label.Name = "ResultTime_label";
            this.ResultTime_label.Size = new System.Drawing.Size(109, 19);
            this.ResultTime_label.TabIndex = 195;
            this.ResultTime_label.Text = "Время (мсек):";
            // 
            // ResultFunction_label
            // 
            this.ResultFunction_label.AutoSize = true;
            this.ResultFunction_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFunction_label.Location = new System.Drawing.Point(112, 434);
            this.ResultFunction_label.Name = "ResultFunction_label";
            this.ResultFunction_label.Size = new System.Drawing.Size(153, 19);
            this.ResultFunction_label.TabIndex = 194;
            this.ResultFunction_label.Text = "Значение функции:";
            // 
            // ResultX_label
            // 
            this.ResultX_label.AutoSize = true;
            this.ResultX_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultX_label.Location = new System.Drawing.Point(113, 402);
            this.ResultX_label.Name = "ResultX_label";
            this.ResultX_label.Size = new System.Drawing.Size(59, 19);
            this.ResultX_label.TabIndex = 193;
            this.ResultX_label.Text = "Ответ:";
            // 
            // PB_ProgressBar
            // 
            this.PB_ProgressBar.Location = new System.Drawing.Point(117, 315);
            this.PB_ProgressBar.Name = "PB_ProgressBar";
            this.PB_ProgressBar.Size = new System.Drawing.Size(373, 17);
            this.PB_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_ProgressBar.TabIndex = 205;
            this.PB_ProgressBar.Visible = false;
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
            "1500*x^3-0,001*exp(2*x)-0,01*exp(z)^2"});
            this.Function_ComboBox.Location = new System.Drawing.Point(273, 47);
            this.Function_ComboBox.Name = "Function_ComboBox";
            this.Function_ComboBox.Size = new System.Drawing.Size(237, 26);
            this.Function_ComboBox.TabIndex = 191;
            this.Function_ComboBox.Text = "x^2-4*sin(x)";
            // 
            // MAXTime_TextBox
            // 
            this.MAXTime_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_TextBox.Location = new System.Drawing.Point(273, 238);
            this.MAXTime_TextBox.Name = "MAXTime_TextBox";
            this.MAXTime_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXTime_TextBox.TabIndex = 190;
            this.MAXTime_TextBox.Text = "50";
            this.MAXTime_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXTime_TextBox_KeyPress);
            // 
            // MAXIteration_TextBox
            // 
            this.MAXIteration_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_TextBox.Location = new System.Drawing.Point(273, 206);
            this.MAXIteration_TextBox.Name = "MAXIteration_TextBox";
            this.MAXIteration_TextBox.Size = new System.Drawing.Size(100, 26);
            this.MAXIteration_TextBox.TabIndex = 189;
            this.MAXIteration_TextBox.Text = "100";
            this.MAXIteration_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MAXIteration_TextBox_KeyPress);
            // 
            // Tolerance_TextBox
            // 
            this.Tolerance_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_TextBox.Location = new System.Drawing.Point(273, 174);
            this.Tolerance_TextBox.Name = "Tolerance_TextBox";
            this.Tolerance_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Tolerance_TextBox.TabIndex = 188;
            this.Tolerance_TextBox.Text = "1e-15";
            this.Tolerance_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tolerance_TextBox_KeyPress);
            // 
            // x_TextBox
            // 
            this.x_TextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_TextBox.Location = new System.Drawing.Point(273, 79);
            this.x_TextBox.Name = "x_TextBox";
            this.x_TextBox.Size = new System.Drawing.Size(100, 26);
            this.x_TextBox.TabIndex = 187;
            this.x_TextBox.Text = "1";
            this.x_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_TextBox_KeyPress);
            // 
            // MAXTime_label
            // 
            this.MAXTime_label.AutoSize = true;
            this.MAXTime_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXTime_label.Location = new System.Drawing.Point(113, 240);
            this.MAXTime_label.Name = "MAXTime_label";
            this.MAXTime_label.Size = new System.Drawing.Size(108, 19);
            this.MAXTime_label.TabIndex = 186;
            this.MAXTime_label.Text = "(MAX) Время:";
            // 
            // MAXIteration_label
            // 
            this.MAXIteration_label.AutoSize = true;
            this.MAXIteration_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MAXIteration_label.Location = new System.Drawing.Point(112, 208);
            this.MAXIteration_label.Name = "MAXIteration_label";
            this.MAXIteration_label.Size = new System.Drawing.Size(135, 19);
            this.MAXIteration_label.TabIndex = 185;
            this.MAXIteration_label.Text = "(MAX) Итераций:";
            // 
            // Tolerance_label
            // 
            this.Tolerance_label.AutoSize = true;
            this.Tolerance_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tolerance_label.Location = new System.Drawing.Point(112, 176);
            this.Tolerance_label.Name = "Tolerance_label";
            this.Tolerance_label.Size = new System.Drawing.Size(112, 19);
            this.Tolerance_label.TabIndex = 184;
            this.Tolerance_label.Text = "Погрешность:";
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_label.Location = new System.Drawing.Point(113, 79);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(26, 19);
            this.x_label.TabIndex = 183;
            this.x_label.Text = "x0";
            // 
            // Function_label
            // 
            this.Function_label.AutoSize = true;
            this.Function_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Function_label.Location = new System.Drawing.Point(109, 49);
            this.Function_label.Name = "Function_label";
            this.Function_label.Size = new System.Drawing.Size(78, 19);
            this.Function_label.TabIndex = 182;
            this.Function_label.Text = "Функция:";
            // 
            // r_text
            // 
            this.r_text.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_text.Location = new System.Drawing.Point(273, 142);
            this.r_text.Name = "r_text";
            this.r_text.Size = new System.Drawing.Size(100, 26);
            this.r_text.TabIndex = 211;
            this.r_text.Text = "10";
            this.r_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.r_text_KeyPress);
            // 
            // r_label
            // 
            this.r_label.AutoSize = true;
            this.r_label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_label.Location = new System.Drawing.Point(113, 142);
            this.r_label.Name = "r_label";
            this.r_label.Size = new System.Drawing.Size(19, 19);
            this.r_label.TabIndex = 210;
            this.r_label.Text = "R";
            // 
            // Res_label
            // 
            this.Res_label.AutoSize = true;
            this.Res_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Res_label.Location = new System.Drawing.Point(111, 356);
            this.Res_label.Name = "Res_label";
            this.Res_label.Size = new System.Drawing.Size(75, 17);
            this.Res_label.TabIndex = 212;
            this.Res_label.Text = "Результат";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Message_label.Location = new System.Drawing.Point(207, 356);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(0, 17);
            this.Message_label.TabIndex = 213;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 602);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Res_label);
            this.Controls.Add(this.r_text);
            this.Controls.Add(this.r_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.h_textbox);
            this.Controls.Add(this.h_label);
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
            this.Controls.Add(this.Function_ComboBox);
            this.Controls.Add(this.MAXTime_TextBox);
            this.Controls.Add(this.MAXIteration_TextBox);
            this.Controls.Add(this.Tolerance_TextBox);
            this.Controls.Add(this.x_TextBox);
            this.Controls.Add(this.MAXTime_label);
            this.Controls.Add(this.MAXIteration_label);
            this.Controls.Add(this.Tolerance_label);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.Function_label);
            this.Name = "Form1";
            this.Text = "\"POCKET SEARCH METHOD\" для поиска экстремума";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox h_textbox;
        private System.Windows.Forms.Label h_label;
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
        private System.Windows.Forms.ComboBox Function_ComboBox;
        private System.Windows.Forms.TextBox MAXTime_TextBox;
        private System.Windows.Forms.TextBox MAXIteration_TextBox;
        private System.Windows.Forms.TextBox Tolerance_TextBox;
        private System.Windows.Forms.TextBox x_TextBox;
        private System.Windows.Forms.Label MAXTime_label;
        private System.Windows.Forms.Label MAXIteration_label;
        private System.Windows.Forms.Label Tolerance_label;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.Label Function_label;
        private System.Windows.Forms.TextBox r_text;
        private System.Windows.Forms.Label r_label;
        private System.Windows.Forms.Label Res_label;
        private System.Windows.Forms.Label Message_label;
    }
}

