<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SigninAdmin.aspx.cs" Inherits="LmsClone.SigninAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập giáo viên</title>
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

    </style>
</head>
<body>
    <div id="all">
        <div class="form">
            <form runat="server" method="post">
                <h2>Admin</h2>
                <p>Tài khoản</p>
                <input type="text" name="username"/>
                <p>Mật khẩu</p>
                <input type="password" name="password" value=""/>
                <br />
                <button runat="server" onserverclick="SigninClick">Đăng nhập</button>
                <%--<asp:Button runat="server" OnClick="SigninClick" Text="Đăng nhập"/>--%>
            </form>
        </div>
    </div>
</body>
</html>
