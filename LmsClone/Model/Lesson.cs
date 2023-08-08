using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using LmsClone.Model;

namespace LmsClone.Model
{
    public class Lesson
    {
        public static List<LessonObject> GetList(String path)
        {
            List<LessonObject> list;
            // Đọc file
            XmlSerializer reader = new XmlSerializer(typeof(List<LessonObject>));
            StreamReader file = new StreamReader(path);
            list = (List<LessonObject>)reader.Deserialize(file);
            file.Close();
            return list;
        }
        public static bool Insert(LessonObject member, String path)
        {
            bool test = false;
            List<LessonObject> array = GetList(path);
            foreach (LessonObject each in array)
            {
                if (each.Id == member.Id && each.Idclass == member.Idclass)
                {
                    test = true;
                    break;
                }
            }
            if (test == false)
            {
                array.Add(member);
                XmlSerializer writer = new XmlSerializer(typeof(List<LessonObject>));
                FileStream _file = File.Create(path);
                writer.Serialize(_file, array);
                _file.Close();
                return true;
            }

            return false;
        }
    }
}