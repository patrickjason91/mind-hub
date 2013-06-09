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
using mindHub.Models;
using Microsoft.Phone.Net;
using Microsoft.Phone.Net.NetworkInformation;

namespace mindHub
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var networkAvailable = NetworkInterface.GetIsNetworkAvailable();
            if (networkAvailable)
            {
                if (string.IsNullOrWhiteSpace(uNametxt.Text))
                {
                    MessageBox.Show("Please complete all informations needed");
                }
                else
                {

                    var loginOk = from login in App.MobileService.GetTable<LoginInfo>()
                                  where login.UserName == uNametxt.Text && login.Password == passtxt.Password
                                  select login;

                    var loginList = await loginOk.ToListAsync();
                    var cred = loginList.FirstOrDefault();
                    if (cred != null)
                    {
                        NavigationService.Navigate(new Uri("/HomePage/HomePage.xaml", UriKind.Relative));
                        this.NavigationService.RemoveBackEntry();
                    }
                    else
                    {
                        MessageBox.Show("Error logging in");
                    }
                }
            }
            else
            {
                MessageBox.Show("No internet connection!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/SignUpPage.xaml", UriKind.Relative));
        }
    }
}