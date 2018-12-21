using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;


namespace Распознование_речи
{
//    Это программа распознает речь с помощю Speech. Для использование данной библиотеки надо установить три библиотеки из след ссылок
//        Microsoft Speech Platform - Runtime
//https://www.microsoft.com/en-us/downl...

//Microsoft Speech Platform - SDK
//https://www.microsoft.com/en-us/downl...

//Microsoft Speech Platform - Runtime Languages
//https://www.microsoft.com/en-us/downl...

//        Видеоурок: https://www.youtube.com/watch?v=-qpVafFnthU&t=67s

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       static Label l;
        static void sre_SpeechRecognized(object sender,SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence > 0.82)
            {
                l.Text = e.Result.Text;
                if(e.Result.Text== "запустить браузер")
                {
                    Process.Start("Chrome.exe");
                }
            }
        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            l = label1;

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
            Choices numbers = new Choices();
            numbers.Add(new string[] { "один", "два", "три", "четыре", "пять","запустить браузер" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(numbers);

            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}
