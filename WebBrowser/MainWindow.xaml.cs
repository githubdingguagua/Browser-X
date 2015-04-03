using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebBrowser
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            back.IsEnabled = false;
            forward.IsEnabled = false;

            ProgressBar.IsIndeterminate = true;

            urlBox.Text = "http://www.google.com/";
            browserWindow.Navigate(urlBox.Text);

                 
        }

        private bool CheckForAbuse()
        {
            if (urlBox.Text.Equals("terrorism")==false)
                return true;
            else
                return false;
        }

      

        private void onPageLoad(object sender, NavigationEventArgs e)
        {
            ProgressBar.IsIndeterminate = false;
        }

        private void onURLBoxFocus(object sender, RoutedEventArgs e)
        {
            urlBox.Text = "";
        }

        private void forward_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.IsIndeterminate = true;
            browserWindow.GoForward();
            back.IsEnabled = true;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.IsIndeterminate = true;
            browserWindow.GoBack();
            forward.IsEnabled = true;
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.IsIndeterminate = true;
            browserWindow.Refresh();
        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar.IsIndeterminate = true;
            back.IsEnabled = true;
            browserWindow.Navigate(urlBox.Text);

            //browserWindow.Navigate("E:\\.NET Apps\\WebBrowser\\WebBrowser\\WebBrowser\\404.html");
        }

       
        
    }
}
