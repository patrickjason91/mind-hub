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

namespace mindHub.HomePage
{
    public partial class HomePage : PhoneApplicationPage
    {
        public HomePage()
        {
            InitializeComponent();
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { FeedImage = "/applicationicon.png", TitleFeed = "angelHack Manila", Contents = "Neque porro quisquam est qui..." });
            newsFeedLV.Items.Add(new NewsFeed() { ViewAll = "view all news feed" });

            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });
            messageLV.Items.Add(new NewsFeed() { UserImg = "/UserImg.png", Names = "Lorem Ipsum", Contents = "Neque porro quisquam est qui..." });


            
        }

        private void Grid_Tap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/NewsFeed/NewsFeed.xaml", UriKind.Relative));
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
    }
}