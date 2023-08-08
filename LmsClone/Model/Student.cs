using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using LmsClone.Model;

namespace LmsClone.Model
{
    public class Student
    {
        //doc ds hoc sinh  file student.xml
        public static List<StudentObject> GetListStudent(String path)
        {
            List<StudentObject> list;
            // Đọc file
            XmlSerializer reader = new XmlSerializer(typeof(List<StudentObject>));
            StreamReader file = new StreamReader(path);
            list = (List<StudentObject>)reader.Deserialize(file);
            file.Close();
            return list;

        }

        // thêm hoc sinh
        public static bool InsertStudent(StudentObject member, String path)
        {
            bool test = false;
            List<StudentObject> array = GetListStudent(path);
            //List < User > list = new List<User>();
            foreach (StudentObject each in array)
            {
                if (each.Username == member.Username || each.Name == member.Name || each.Password == member.Password || each.Email == member.Email)
                {
                    test = true;
                    break;
                }
            }
            if (test == false)
            {
                array.Add(member);
                XmlSerializer writer = new XmlSerializer(typeof(List<StudentObject>));
                FileStream _file = File.Create(path);
                writer.Serialize(_file, array);
                _file.Close();
                return true;
            }

            return false;
        }

    }
}