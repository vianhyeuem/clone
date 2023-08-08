using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LmsClone
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user_info.Visible = true;
            if (!String.IsNullOrEmpty((string)Session["loginadmin"]))
            {
                user_info.Visible = false;
            }
        }
        public void GetUser()
        {
            Response.Write("<h1>Thông tin cá nhân ...</h1> <br>");
            if (Session["loginadmin"] == "true")
            {
                Response.Write("<h5>Giáo viên: </h5>" + Session["name"]);
                Response.Write("<h5>Tài khoản: </h5>" + Session["username"] +
                                "<h5>Email: </h5>" + Session["email"] +
                                "<br>-------------------------------------");
            }
            else if (Session["loginstudent"] == "true")
            {
                Response.Write("<h5>Sinh viên: </h5>" + Session["name"]);
                Response.Write("<h5>Tài khoản: </h5>" + Session["username"] +
                                "<h5>Email: </h5>" + Session["email"] +
                                "<br>-------------------------------------");
            }
        }
    }
}