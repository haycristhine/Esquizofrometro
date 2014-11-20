using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Esquizofrometro
{
    public partial class ResultPage : PhoneApplicationPage
    {
        public ResultPage()
        {
            InitializeComponent();

            Random r = new Random();
            App thisApp = Application.Current as App;
            int i = r.Next(thisApp.randomParam, thisApp.randomParam + 20);
            txtResultado.Text = i + " %";
            txtcomentario.Text = generatecomentario(i);
        }

        public string generatecomentario(int resultado)
        {
            if (resultado < 20)
            {
                return "Você é normal até demais";
            }
            else if (resultado < 40)
            {
                return "Você é aparentemente normal";
            }else if (resultado < 60){
                return "Sua mente parece ser um pouco alterada";
            }
            else if (resultado < 75)
            {
                return "Largue este celular e procure um psicólogo!";
            }else if (resultado <= 100){
                return "Se eu fosse você procuraria o hospício mais próximo para me internar";
            }
            else
            {
                return "ISTO DEVERIA SER IMPOSSÍVEL! COMO CONSEGUIU?";
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            App thisApp = Application.Current as App;
            thisApp.Terminate();
        }
    }
}