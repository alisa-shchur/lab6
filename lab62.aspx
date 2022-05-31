<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab62.aspx.cs" Inherits="lab6.lab62" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="ButtonDatabase" runat="server" Text="Get data from the database" OnClick="ButtonDatabase_Click" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridViewDatabase" runat="server">
            </asp:GridView>
            <asp:Label ID="LabelData" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonCache" runat="server" Text="Get data from cache" OnClick="ButtonCache_Click" />
            <br />
            <br />
            <asp:GridView ID="GridViewCache" runat="server">
            </asp:GridView>
            <asp:Label ID="LabelCache" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
