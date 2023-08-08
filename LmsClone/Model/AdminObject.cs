using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LmsClone.Model
{
    public class AdminObject
    {
        private string name;
        private string username;
        private string email;
        private string password;
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }

        public string Password { get => password; set => password = value; }
    }
}