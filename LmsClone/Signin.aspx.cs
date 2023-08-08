﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loginstudent"] == "true")
            {
                Response.Redirect("Index.aspx");
            }
        }
        protected void SigninClick(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/Data/Student.xml");
            List<StudentObject> array = Student.GetListStudent(path);


            string username = Request.Form["username"];
            string password = Request.Form["password"];
            if (username == "" && password == "")
            {
                Response.Write("<script> alert('Nhập đầy đủ tài khoản và mật khẩu !!!'); </script>");

            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i].Username == username && array[i].Password == password)
                    {
                        //Tạo session
                        Session["loginstudent"] = "true";
                        Session["loginadmin"] = "";
                        Session["name"] = array[i].Name;
                        Session["username"] = array[i].Username;
                        Session["email"] = array[i].Email;
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        Response.Write("<script> alert('Tài khoản không hợp lệ! Mời nhập lại.'); </script>");
                    }
                }   
            }
        }
    }
}