using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //bot_admin.Visible = false;
            //bot_student.Visible = false;
            //if (Session["loginadmin"] == "true")
            //{
            //    bot_admin.Visible = true;
            //}
            //else if (Session["loginstudent"] == "true")
            //{
            //    bot_student.Visible = true;
            //}
        }
        public void GetListClass()
        {
            String path = Server.MapPath("~/Data/Class.xml");
            List<ClassObject> Class = Model.Class.GetList(path);
            List<ClassObject> Classfilter = new List<ClassObject>();

            if (Session["loginadmin"] == "true")
            {
                foreach (Model.ClassObject each in Class)
                {
                    if (each.Usernameadmin.Equals(Session["username"]))
                    {
                        Classfilter.Add(each);
                    }
                }

            }
            else if (Session["loginstudent"] == "true")
            {
                foreach (Model.ClassObject each in Class)
                {
                    Classfilter.Add(each);
                }

            }
            else
            {
                foreach (Model.ClassObject each in Class)
                {
                    Classfilter.Add(each);
                }

            }

            foreach (ClassObject each in Classfilter)
            {
                Response.Write("<div class='each-class'>" +
                    "<a href='DetailClass.aspx?id="+ each.Id +"'>" +
                    "<img class='class-img' src='./img/book.jpg'/>" +
                    "<h5>Lớp: "+each.Name+"</h5>"+
                    "<h5>GV: " + each.Usernameadmin + "</h5>"+
                    "<h5>Mô tả: " + each.Description + "</h5>" +
                    "</a></div>");
            }
        }

    }
}