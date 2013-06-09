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
using Microsoft.WindowsAzure.MobileServices;
using mindHub.Models;
using Microsoft.Phone.Tasks;

namespace mindHub.HomePage
{
    public partial class HomePage : PhoneApplicationPage
    {
       
        public HomePage()
        {
            InitializeComponent();
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "AngelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { ViewAll = "view all news feed" });

            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });

            projectsLV.Items.Add(new NewsFeed() { ProjectTitle = "AngelHack Student Edition", ProjectLead = "Paul Villena" });
            projectsLV.Items.Add(new NewsFeed() { ProjectTitle = "AngelHack Student Edition", ProjectLead = "Paul Villena" });
            projectsLV.Items.Add(new NewsFeed() { ProjectTitle = "AngelHack Student Edition", ProjectLead = "Paul Villena" });
            projectsLV.Items.Add(new NewsFeed() { ProjectTitle = "AngelHack Student Edition", ProjectLead = "Paul Villena" });
            projectsLV.Items.Add(new NewsFeed() { ProjectTitle = "AngelHack Student Edition", ProjectLead = "Paul Villena" });

        }

        private void Grid_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewsFeed/NewsFeed.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.NavigationService.RemoveBackEntry();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            SmsComposeTask task = new SmsComposeTask();
            task.Show();
        }

        private void Panorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PanoramaMain.SelectedItem != null)
            {
                if (PanoramaMain.SelectedIndex != 1)
                {
                    ApplicationBar.IsVisible = false;
                }
                else
                {
                    ApplicationBar.IsVisible = true;
                }
            }
        }

        private void Grid_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/ProjectPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AskQuestionPage.xaml", UriKind.Relative));
        }
    }

    public class NewsFeed
    {
        public string FeedImage { get; set; }
        public string TitleFeed { get; set; }
        public string ViewAll { get; set; }

        public string UserImg { get; set; }
        public string Names { get; set; }
        public string Contents { get; set; }

        public string ProjectTitle {get;set;}
        public string ProjectLead {get;set;}
        public string ProjectDescription {get;set;}
    }
}