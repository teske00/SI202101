<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShopItems.aspx.cs" Inherits="WEB_VEZBA1.ShopItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Ispis svih Itema"></asp:Label>
    <br />

    <asp:ListBox ID="items_list" runat="server" Height="400px" Width="500px"></asp:ListBox>

</asp:Content>
