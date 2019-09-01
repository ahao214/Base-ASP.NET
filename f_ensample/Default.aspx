<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="f_ensample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label runat="server" ID="lblName">输入输入：</asp:Label>
        <asp:TextBox ID="txtNumber" runat="server">
        </asp:TextBox>
        <asp:Button ID="btnClick" runat="server"  Text="判断" OnClick="btnClick_Click"/>

        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:Button ID="btnAge" runat="server" OnClick="btnAge_Click" Text="点击" />
    </div>
    <div class="jumbotron">
        <asp:TextBox ID="txtMonth" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtShow" runat="server"></asp:TextBox>
        <asp:Button ID="btnMonth" runat="server" Text="月份" OnClick="btnMonth_Click" />
    </div>



</asp:Content>
