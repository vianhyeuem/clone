using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LmsClone
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //class_menu.Visible = true;
            class_menu.Visible = false;
            signout_admin.Visible = false;
            //if (String.IsNullOrEmpty((string)Session["loginstudent"]) && String.IsNullOrEmpty((string)Session["loginadmin"]))
            //{
            //    Response.Redirect("Signin.aspx");
            //}
            if (!String.IsNullOrEmpty((string)Session["loginadmin"]))
            {
                class_menu.Visible = true;
                signout_admin.Visible = true;
            }

        }
        protected void SignoutClick(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["name"] = "";
            Session["email"] = "";
            if (Session["loginstudent"] == "true")
            {
                Session["loginstudent"] = "";
                Session["loginadmin"] = "";
                Response.Redirect("Signin.aspx");
            }
            else if (Session["loginadmin"] == "true")
            {
                Session["loginstudent"] = "";
                Session["loginadmin"] = "";
                Response.Redirect("SigninAdmin.aspx");
            }
            else
            {
                Response.Redirect("Signin.aspx");
            }
        }
    }
}