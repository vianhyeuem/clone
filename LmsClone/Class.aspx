<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Class.aspx.cs" Inherits="LmsClone.Class" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #class_menu {
            background: #009FE1;
            color: #fff;
        }

        #form_insert_class {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div id="form_insert_class">
            <form>
                <br />
                Mã lớp
            <br />
                <input type="text" name="id">
                <br />
                Tên lớp
            <br />
                <br />
                <input type="text" name="name">
                <br />
                Mô tả
            <br />
                <br />
                <input type="text" name="description">
                <br />
                <button runat="server" onserverclick="InsertClassClick">Thêm lớp</button>
                <%--<asp:Button runat="server" OnClick="InsertClassClick" Text="Thêm lớp" />--%>
            </form>
        </div>
        <div>
        </div>
    </div>
</asp:Content>

