<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebDev_Oef2_WebApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Inschrijven nieuwsbroef</title>
    <link rel="stylesheet" href="stijl.css" /> 
</head>
<body>
    <header>
        <h1>Inschrijven nieuwsbrief</h1>
    </header>
    <article>text text text</article>
    <form id="form1" runat="server">
        <asp:Label ID="naam" runat="server" Text="Naam"></asp:Label>
        <div>
            <input id="txtName" placeholder="Geef uw naam in..." required="required" type="text"  runat="server"/></div>
        <asp:Label ID="Label2" runat="server" Text="E-Mail"></asp:Label>
        <p>
            <input id="txtMail" type="email" placeholder="xxx@yyy.com" required="required"  runat="server"/></p>
        <asp:Button ID="VerstuurBTN" runat="server" Text="Inschrijven" OnClick="VerstuurBTN_Click" />
    </form>
</body>
</html>
