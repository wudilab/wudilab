<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MainWeb.Index" MasterPageFile="~/MasterPage/Main.Master"%>

<asp:Content runat="server" ID="content" ContentPlaceHolderId="ContentPlaceHolder1">
  <%--  <div id="HeaderBar">
        <asp:TextBox ID="txtOverrideBasePremium3Value" runat="server" CssClass="textBoxContent" onkeypress="return MaskMoney(this, event);" Text="0" Width="89px" ></asp:TextBox>
    </div>--%>
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
</asp:Content>
