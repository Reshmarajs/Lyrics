using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lyrics.com.Models.Login
{
    public class UserModel
    {
        public UserModel()
        {
            this.Id = 0;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long PhoneNo { get; set; }
        public string PinCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}