using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using LmsClone.Model;

namespace LmsClone.Model
{
    public class Class
    {
        //doc ds hoc sinh  file Class.xml
        public static List<ClassObject> GetList(String path)
        {
            List<ClassObject> list;
            // Đọc file
            XmlSerializer reader = new XmlSerializer(typeof(List<ClassObject>));
            StreamReader file = new StreamReader(path);
            list = (List<ClassObject>)reader.Deserialize(file);
            file.Close();
            return list;

        }

        // thêm hoc sinh
        public static bool Insert(ClassObject member, String path)
        {
            bool test = false;
            List<ClassObject> array = GetList(path);
            foreach (ClassObject each in array)
            {
                if (each.Id == member.Id)
                {
                    test = true;
                    break;
                }
            }
            if (test == false)
            {
                array.Add(member);
                XmlSerializer writer = new XmlSerializer(typeof(List<ClassObject>));
                FileStream _file = File.Create(path);
                writer.Serialize(_file, array);
                _file.Close();
                return true;
            }

            return false;
        }

    }
}