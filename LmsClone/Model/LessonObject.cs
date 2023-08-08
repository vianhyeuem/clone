using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace LmsClone.Model
{
    public class LessonObject
    {
        private string idclass;
        private string id;
        private string name;
        private string description;
        private string detail;

        //public LessonObject(string idclass, string id, string name, string description, string detail)
        //{
        //    this.idclass = idclass;
        //    this.id = id;
        //    this.name = name;
        //    this.description = description;
        //    this.detail = detail;
        //}

        public string Idclass { get { return idclass; } set { idclass = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Detail { get { return detail; } set { detail = value; } }

    }
}