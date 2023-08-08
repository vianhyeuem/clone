using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LmsClone.Model
{
    public class ClassObject
    {
        private string id;
        private string name;
        private string usernameadmin;
        private string description;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Usernameadmin { get => usernameadmin; set => usernameadmin = value; }
        public string Description { get => description; set => description = value; }

    }
}