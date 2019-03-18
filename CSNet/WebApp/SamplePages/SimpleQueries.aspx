<%@ Page Title="Simple Queries" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQueries.aspx.cs" Inherits="WebApp.SamplePages.SimpleQueries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Simple Queries<table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Enter a Product ID"></asp:Label>
                <input id="SearchArg" type="text" /><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                <asp:Button ID="Clear" runat="server" Text="Clear" CausesValidation="false" OnClick="Clear_Click"/>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
    </h1>

</asp:Content>
