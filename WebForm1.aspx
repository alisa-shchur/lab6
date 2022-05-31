<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>Lab 6.1</p>
        <asp:Button ID="ButtonForError" runat="server" OnClick="ButtonForError_Click" Text="Сlick on me" />
        <br />
        <p>Lab 6.2</p>
        <asp:Button ID="ButtonLab62" runat="server" OnClick="ButtonLab62_Click" Text="Click on me" />
        <br />
        <p style="width: 70px">Lab 6.3</p>
        <asp:Button ID="ButtonFirstPage" runat="server" OnClick="ButtonFirstPage_Click" Text="First page" />
        <asp:Button ID="ButtonSecondPage" runat="server" OnClick="ButtonSecondPage_Click" style="margin-left: 43px" Text="Second page" />

    </form>
</body>
</html>
