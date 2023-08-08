<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="LmsClone.Signup" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Đăng kí</title>
    <style type="text/css">
        * {
            padding: 0;
            margin: 0;
        }

        #all {
            width: 100%;
            height: 700px;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .form {
            width: 25%;
            height: 70%;
            border: 1px solid black;
            border-radius: 10px;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        h2 {
            color: aqua;
            font-family: sans-serif;
            text-align: center;
        }

        input {
            width: 100%;
            line-height: 220%;
            margin: 5% 5% 10% 0;
            border-radius: 5px;
            background-color: antiquewhite;
        }

        button {
            width: 100%;
            line-height: 220%;
            margin: 5% 5% 5% 0;
            border: 1px solid black;
            border-radius: 5px;
        }

            button:hover {
                font-size: 110%;
            }

        a {
            width: 100%;
            line-height: 150%;
            border: 1px solid black;
            border-radius: 5px;
            display: flex;
            justify-content: center;
            align-items: center;
        }
    </style>
</head>
<body>
    <div id="all">
        <div class="form">
            <form runat="server" method="post">
                <h2>Đăng ký</h2>
                <p>Họ và tên</p>
                <input type="text" name="name" value="" />
                <p>Tài khoản</p>
                <input type="text" name="username" value="" />
                <p>Email</p>
                <input type="email" name="email" value="" />
                <p>Mật khẩu</p>
                <input type="password" name="password" value="" />
                <p>Nhập lại mật khẩu</p>
                <input type="password" name="comfirm_password" value="" />
                <br />
                <button runat="server" onserverclick="SignupClick">Đăng kí</button>
                <a href="Signin.aspx">Đăng nhập</a>
                <%--<asp:Button runat="server" OnClick="SignupClick" Text="Đăng kí"/>--%>
            </form>
        </div>
    </div>
</body>
</html>
