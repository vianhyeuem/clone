using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LmsClone.Model;

namespace LmsClone
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void SignupClick(object sender, EventArgs e)
        {

            string name = Request.Form["name"];
            string username = Request.Form["username"];
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            string comfirm_password = Request.Form["comfirm_password"];
            if (name == "" && email == "" && username == "" && password == "" && comfirm_password == password)
            {
                Response.Write("<script> alert('VUi lòng nhập đầy đủ thông tin!!!');</script>");
            }
            else if (name != "" && email != "" && username != "" && password != "" && comfirm_password == password)
            {

                StudentObject each = new StudentObject();
                each.Name = name;
                each.Username = username;
                each.Email = email;
                each.Password = password;

                string path = Server.MapPath("~/Data/Student.xml");
                if (Student.InsertStudent(each, path))
                {
                    //Response.Write("<script> var result = confirm('Đăng kí thành công vui lòng đăng nhập lại !!!');if (result){window.location='Dangnhap.aspx';}else{alert('ok!');} </script>");
                    Response.Write("<script> alert('Đăng kí thành công vui lòng đăng nhập lại !!!');</script>");
                    Response.Redirect("Signin.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Lỗi đăng kí!. Vui lòng kiểm tra lại dữ liệu'); </script>");
                }
            }

        }
    }
}