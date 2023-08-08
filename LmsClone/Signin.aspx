<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="LmsClone.Signin" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Đăng nhập</title>
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

/*        @media (max-width:767px) {
            .form {
                width: 70%;
                height: 50%;
            }
            input {
                width: 98%;
            }
        }*/
    </style>
</head>
<body>
    <div id="all">
        <div class="form">
            <form runat="server" method="post">
                <h2>Đăng nhập</h2>
                <p>Tài khoản</p>
                <input type="text" name="username" />
                <p>Mật khẩu</p>
                <input type="password" name="password" value="" />
                <br />
                <button runat="server" onserverclick="SigninClick">Đăng nhập</button>
                <a href="Signup.aspx">Đăng kí</a>
            </form>
        </div>
    </div>
</body>
</html>
