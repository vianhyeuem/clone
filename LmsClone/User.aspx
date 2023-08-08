<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="LmsClone.User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #user-menu {
            background: #009FE1;
            color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%GetUser(); %>
    <div runat="server" id="user_info">
        <h5>Sinh viên: </h5>
            A
        <h5>Tài khoản: </h5>
            B
        <h5>Email: </h5>
            C
        <br>
            -------------------------------------
    </div>
</asp:Content>
