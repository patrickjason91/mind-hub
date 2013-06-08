using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace mindHub
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uNametxt.Text) && string.IsNullOrWhiteSpace(passtxt.Text))
            {
                MessageBox.Show("Please complete all informations needed");
            }
            else
            {
                NavigationService.Navigate(new Uri("/HomePage/HomePage.xaml", UriKind.Relative));

            }
        }
    }
}