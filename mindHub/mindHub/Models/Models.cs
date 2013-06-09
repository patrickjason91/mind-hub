using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindHub.Models
{
    public class LoginInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistered { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int Userid { get; set; }
        public DateTime DateSent { get; set; }
    }

    public class NewsFeed
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime DatePosted { get; set; }
    }

    public class ContactInfo
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }

    public class BasicInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
    }
}
