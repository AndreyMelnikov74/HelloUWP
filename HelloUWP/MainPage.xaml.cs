using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace HelloUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {        
        public MainPage()
        {
            this.InitializeComponent();

            // привет мир!
            hellowordtb.Text = "Привет мир!";

            languagebn.Content = "АНГЛИЙСКИЙ";

            languagebn.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green);
            hellowordbr.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green);

            // получаем ссылку на внешний вид приложения
            Windows.UI.ViewManagement.ApplicationView appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
            // установка заголовка
            appView.Title = "ПРИВЕТ МИР!";
        }

        // Обрабочик.
        private void languagebutton_Click(object sender, RoutedEventArgs e)
        {
            if(languagebn.Content.ToString() == "АНГЛИЙСКИЙ")
            {
                languagebn.Content = "РУССКИЙ";
                hellowordtb.Text = "Hello world!";
                languagebn.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Yellow);
                hellowordbr.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Yellow);
            }
            else
            {
                languagebn.Content = "АНГЛИЙСКИЙ";
                hellowordtb.Text = "Привет мир!";
                languagebn.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green);
                hellowordbr.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Green);
            }
        }
    }
}
