<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="if_nesting.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:Button ID="btnAge" runat="server" OnClick="btnAge_Click" Text="点击" />
        </div>
    </form>
</body>
</html>
