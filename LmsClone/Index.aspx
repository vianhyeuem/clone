<%@ Page Title="Trang chủ" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LmsClone.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #index-menu {
            background: #009FE1;
            color: #fff;
        }

/*        #ContentPlaceHolder1_bot_admin {
            width: 80%;
            height: 90%;
            margin: 0 auto;
            margin-top: 2%;
            padding: 3% 3% 5% 3%;
            border-top: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        #ContentPlaceHolder1_bot_student {
            width: 80%;
            height: 90%;
            margin: 0 auto;
            margin-top: 2%;
            padding: 3% 3% 5% 3%;
            border-top: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }      */  
        #ContentPlaceHolder1_bot_class {
            width: 80%;
            height: 90%;
            margin: 0 auto;
            margin-top: 2%;
            padding: 3% 3% 5% 3%;
            border-top: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        a {
            text-decoration: none;
            color: black;
        }

        .each-class {
            width: 30%;
            height: 50%;
            display: inline;
            float: left;
            text-align: center;
            margin-right: 2%;
            margin-bottom: 2%;
            border: solid 1px #e5e5e5;
            background-color: rgba(214,228,215,0.2);
            box-shadow: 0px 0px 15px 1px #d1d1d1;
            border-radius: 10px;
        }

        .class-img {
            width: 100%;
            height: 60%;
        }
        @media (max-width:767px) {
            .each-class {
            width: 46%;
            height: 50%;
            }
            h1{
                font-size:6vw;
            }
            h5{
                font-size:3vw;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<%--    <div id="bot_admin" runat="server">
        <div style="width: 100%; text-align: center; height: 10%;">
            <h1>Danh sách lớp học do bạn quản lý.</h1>
        </div>
        <div style="width: 100%; height: 90%; margin-left: 3%;">
            <% GetListClass(); %>
        </div>
    </div>
    <div id="bot_student" runat="server">
        <div style="width: 100%; text-align: center; height: 10%;">
            <h1>Danh sách lớp học</h1>
        </div>
        <div style="width: 100%; height: 90%; margin-left: 3%;">
            <% GetListClass(); %>
        </div>
    </div>--%>
        <div id="bot_class" runat="server">
        <div style="width: 100%; text-align: center; height: 10%;">
            <h1>Danh sách lớp học</h1>
        </div>
        <div style="width: 100%; height: 90%; margin-left: 3%;">
            <% GetListClass(); %>
        </div>
    </div>

</asp:Content>
