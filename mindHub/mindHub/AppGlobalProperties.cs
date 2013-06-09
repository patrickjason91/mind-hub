using mindHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindHub
{
    public class AppGlobalProperties
    {
        public static LoginInfo LoggedIn{ get; set; }
        public static NewsFeed.NewsFeed CurrentProjectViewed { get; set; }
    }
}
