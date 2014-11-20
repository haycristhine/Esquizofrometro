using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Esquizofrometro.Resources;
using Esquizofrometro.valueObjects;

namespace Esquizofrometro
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Perguntas perguntas = new Perguntas();
        int valorrespostaselecionada = 0;
        public List<RadioButton> lstbotoes = new List<RadioButton>();
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            perguntas.lstperguntas = Perguntas.generatePerguntas();
            updateStackPanel(0);
  
            lstbotoes.Add(Resposta1);
            lstbotoes.Add(Resposta2);
            lstbotoes.Add(Resposta3);
            lstbotoes.Add(Resposta4);


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        public void updateStackPanel(int perguntaAtual)
        {
            this.txtnumpergunta.Text = "PERGUNTA " + (perguntaAtual + 1);
            this.txtpergunta.Text = perguntas.lstperguntas.ElementAt(perguntaAtual).perguntatxt;
            this.Resposta1.Content = perguntas.lstperguntas.ElementAt(perguntaAtual).lstrespostas.ElementAt(0).respostatext;
            this.Resposta2.Content = perguntas.lstperguntas.ElementAt(perguntaAtual).lstrespostas.ElementAt(1).respostatext;
            this.Resposta3.Content = perguntas.lstperguntas.ElementAt(perguntaAtual).lstrespostas.ElementAt(2).respostatext;
            this.Resposta4.Content = perguntas.lstperguntas.ElementAt(perguntaAtual).lstrespostas.ElementAt(3).respostatext;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            App thisApp = Application.Current as App;
            if (thisApp.perguntaAtual != 8)
            {


                if (valorrespostaselecionada != 0)
                {
                   
                    thisApp.randomParam += valorrespostaselecionada;

                    thisApp.perguntaAtual++;

                    updateStackPanel(thisApp.perguntaAtual);
                    valorrespostaselecionada = 0;
                    unselectradiobuttons();
                }
                else
                {
                    MessageBox.Show("Selecione uma Pergunta!");
                }
            }
            else
            {
                NavigationService.Navigate(new Uri("/ResultPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }


        private void ListBoxItem_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App thisApp = Application.Current as App;
            valorrespostaselecionada = perguntas.lstperguntas.ElementAt(thisApp.perguntaAtual).lstrespostas.ElementAt(0).valor;
            updateradiobuttons(0);
        }

        private void Item2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App thisApp = Application.Current as App;
            valorrespostaselecionada = perguntas.lstperguntas.ElementAt(thisApp.perguntaAtual).lstrespostas.ElementAt(1).valor;
            updateradiobuttons(1);
        }

        private void Item3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App thisApp = Application.Current as App;
            valorrespostaselecionada = perguntas.lstperguntas.ElementAt(thisApp.perguntaAtual).lstrespostas.ElementAt(2).valor;
            updateradiobuttons(2);
        }

        private void Item4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App thisApp = Application.Current as App;
            valorrespostaselecionada = perguntas.lstperguntas.ElementAt(thisApp.perguntaAtual).lstrespostas.ElementAt(3).valor;
            updateradiobuttons(3);
        }


        private void updateradiobuttons(int selectedButton)
        {
            for (int i = 0; i < lstbotoes.ToArray().Length; i++)
            {
                if (i != selectedButton)
                {
                    lstbotoes.ElementAt(i).IsChecked = false;
                }
            }
        }

        private void unselectradiobuttons()
        {
            for (int i = 0; i < lstbotoes.ToArray().Length; i++)
            {
           
                    lstbotoes.ElementAt(i).IsChecked = false;
                
            }
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}