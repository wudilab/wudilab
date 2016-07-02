<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs"
     Inherits="MainWeb.Index" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>XML Format</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="ErrorMessage" runat="server" Text="" Visible ="False"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Input xml"></asp:Label>
        <br />
        <asp:TextBox ID="inputBox" runat="server" Height="198px" TextMode="MultiLine" Width="452px"></asp:TextBox>
        <asp:Button ID="btnIndent" runat="server" OnClick="btnIndent_Click" Text="Indent XML" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="OutputXml"></asp:Label>
        <br />
        <asp:TextBox ID="outputBox" runat="server" Height="188px" TextMode="MultiLine" Width="449px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
