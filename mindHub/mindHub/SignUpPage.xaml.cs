using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using mindHub.Models;

namespace mindHub
{
    public partial class SignUpPage : PhoneApplicationPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var loginInfo = new LoginInfo { UserName = uNametxt.Text, Password = passtxt.Password, DateRegistered = DateTime.Now };
            var loginInfoTable = App.MobileService.GetTable<LoginInfo>();
            var loginEnum = from login in loginInfoTable
                            where login.UserName == uNametxt.Text
                            select login;
            var log = await loginEnum.ToListAsync();
            var log2 = log.FirstOrDefault();
            if (log2 != null)
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                await loginInfoTable.InsertAsync(loginInfo);
                NavigateBack();
            }
        }

        private void NavigateBack()
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                this.NavigationService.RemoveBackEntry();
                this.NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }
    }
}