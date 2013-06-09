using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace mindHub
{
    public partial class ProjectPage : PhoneApplicationPage
    {
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now collaborating on this project!");
            var btn = (sender as ApplicationBarIconButton);
            btn.IsEnabled = false;
        }
    }
}