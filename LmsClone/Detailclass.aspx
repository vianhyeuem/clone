<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Detailclass.aspx.cs" Inherits="LmsClone.Detailclass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .hidden {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input id="check" type="checkbox" onchange="ShowHide(this)" runat="server" />
    <label runat="server" id="txtcheck">Thêm bài học</label>
    <form>
        <label class="hidden">ID</label>
        <input type="text" name="id" class="hidden">
        <label class="hidden">Tên bài học</label>
        <input type="text" name="name" class="hidden">
        <label class="hidden">Mô tả</label>
        <input type="text" name="description" class="hidden">
        <label class="hidden">Nội dung</label>
        <input type="text" name="detail" class="hidden">
        <button runat="server" class="hidden" onserverclick="btnInserLesson">Thêm bài học</button>
    </form>
    <div>
        <% GetListLesson(); %>
    </div>
    <script type="text/javascript">
        function ShowHide(el) {
            var hidden = document.getElementsByClassName("hidden");
            for (var i = 0; i != hidden.length; i++) {
                if (el.checked) {
                    hidden[i].style.display = "block";
                } else {
                    hidden[i].style.display = "none";
                }
            }
        }
    </script>
</asp:Content>
