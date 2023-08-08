using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using LmsClone.Model;

namespace LmsClone.Model
{
    public class Admin
    {
        public static List<AdminObject> GetListAdmin(String path)
        {
            List<AdminObject> list;
            // Đọc file
            XmlSerializer reader = new XmlSerializer(typeof(List<AdminObject>));
            StreamReader file = new StreamReader(path);
            list = (List<AdminObject>)reader.Deserialize(file);
            file.Close();
            return list;

        }
    }
}